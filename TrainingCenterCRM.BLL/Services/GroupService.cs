using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingCenterCRM.BLL.Interfaces;
using TrainingCenterCRM.Core.Enums;
using TrainingCenterCRM.Core.Filters;
using TrainingCenterCRM.Core.Models;
using TrainingCenterCRM.DAL.EF.Interfaces;

namespace TrainingCenterCRM.BLL.Services
{
    public class GroupService : IGroupService
    {
        private readonly IGroupRepository groupRepository;

        private readonly IStudentRequestService studentRequestService;
        private readonly IStudentToGroupAssignmentService assignmentService;
        private readonly IStudentService studentService;
        private readonly IUserService _userService;
        private readonly IEmailService _emailService;

        public GroupService(IGroupRepository groupRepository,
                            IStudentRequestService studentRequestService,
                            IStudentService studentService,
                            IStudentToGroupAssignmentService assignmentService,
                            IUserService userService, 
                            IEmailService emailService)
        {
            this.groupRepository = groupRepository;
            this.studentRequestService = studentRequestService;
            this.studentService = studentService;
            this.assignmentService = assignmentService;
            _userService = userService;
            _emailService = emailService;
        }
        public async Task AddGroupAsync(Group group, IEnumerable<int> studentsId)
        {
            if (group == null)
                throw new ArgumentException();

            group.Students = null;

            await groupRepository.Create(group);

            foreach(var studentId in studentsId)
            {
                await assignmentService.AddAssignmentAsync(new StudentToGroupAssignment
                {
                    GroupId = group.Id,
                    StudentId = studentId,
                    AssignmentDate = DateTime.Now,
                    Result = ResultType.Graduated
                });

                var student = await studentService.GetStudentAsync(studentId);
                student.GroupId = group.Id;
                await studentService.EditStudentAsync(student);
            }

            await studentRequestService.CloseRequestsAsync(studentsId, group.CourseId);
        }

        public async Task DeleteGroupAsync(int id)
        {
            await groupRepository.Delete(id);
        }

        public async Task EditGroupAsync(Group group, IEnumerable<int> studentsId)
        {
            if (group == null)
                throw new ArgumentException();

            group.Students = null;

            var assignmentsByGroup = await assignmentService.GetAssignmentsByGroupAsync(group.Id);
                                                        
            var assignmentsForDelete = assignmentsByGroup.Where(stg => !studentsId.Contains(stg.StudentId)).ToList();

            foreach (var assigment in assignmentsForDelete)
            {
                await assignmentService.DeleteAssignmentAsync(assigment.StudentToGroupAssignmentId);

                var student = await studentService.GetStudentAsync(assigment.StudentId);
                student.GroupId = null;
                await studentService.EditStudentAsync(student);

                await studentRequestService.ReOpenRequestAsync(assigment.StudentId, group.CourseId);
            }

            foreach (var studentId in studentsId)
            {
                var assignment = await assignmentService.GetAssignmentByStudentAsync(studentId);
                
                if (assignment == null)
                {

                    await assignmentService.AddAssignmentAsync(new StudentToGroupAssignment
                    {
                        GroupId = group.Id,
                        StudentId = studentId,
                        AssignmentDate = DateTime.Now,
                        Result = ResultType.Graduated
                    });

                    var student = await studentService.GetStudentAsync(studentId);
                    student.GroupId = group.Id;
                    await studentService.EditStudentAsync(student);
                }
            }

            await studentRequestService.CloseRequestsAsync(studentsId, group.CourseId);

            await groupRepository.Update(group);
        }

        public Task<Group> GetGroupAsync(int id)
        {
            return groupRepository.Get(id);
        }

        public Task<List<Group>> GetGroupsAsync()
        {
            return groupRepository.GetAll();
        }

        public Task<IEnumerable<Group>> GetGroupsByPaginationAsync(PaginationFilter pagination)
        {
            return groupRepository.GetAllByPagination(pagination);
        }

        public async Task<Teacher> GetGroupTeacher(int groupId)
        {
            var group = await groupRepository.GetGroupWithTeacher(groupId);
            return group?.Teacher;
        }

        public async Task<IEnumerable<Group>> GetStudentGroups(string userEmail)
        {
            var user = await _userService.GetUserWithStudentByEmail(userEmail);

            if (user.Student == null)
                throw new NullReferenceException("Student not found");

            var groups = await groupRepository.Find(g => g.Students.Any(s => s.Id == user.Student.Id));
            return groups;
        }

        public async Task<IEnumerable<Student>> GetStudentsWithGroupAsync(int groupId, int courseId)
        {
            var group = await groupRepository.Get(groupId);
            return group.CourseId == courseId ? group.Students : new List<Student>();
        }

        public async Task<IEnumerable<Group>> GetTeacherGroups(string email)
        {
            var user = await _userService.GetUserWithTeacherByEmail(email);
            if (user.Teacher == null)
                throw new NullReferenceException("Teacher not found");

            var groups = await groupRepository.Find(g => g.TeacherId == user.Teacher.Id);
            return groups;
        }

        public async Task<bool> HasAccessToGroup(int groupId, string userEmail)
        {
            var user = await _userService.GetUserWithTeacherByEmail(userEmail);
            if (user.Teacher == null)
                return false;

            var group = await groupRepository.Get(groupId);
            if (group == null)
                return false;

            return group.TeacherId == user.Teacher.Id;
        }

        public async Task SendInviteNotifications(int groupId)
        {
            var group = await groupRepository.GetFullGroupInfo(groupId);
            var taskList = new List<Task>();
            foreach(var student in group.Students)
            {
                var message = _emailService.GenerateCourseInvitationMessage(group, student);
                var studentEmail = (await studentService.GetStudentWithUserById(student.Id)).User.Email;
                taskList.Add(Task.Run(() => _emailService.SendEmailAsync(studentEmail, "Сourse invitation notification", message)));
            }
            await Task.WhenAll(taskList);
        }
    }
}
