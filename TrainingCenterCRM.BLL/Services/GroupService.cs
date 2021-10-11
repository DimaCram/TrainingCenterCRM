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
        private readonly IRepository<Group> groupRepository;

        private readonly IStudentRequestService studentRequestService;
        private readonly IStudentToGroupAssignmentService assignmentService;
        private readonly IStudentService studentService;
        private readonly IUserService _userService;

        public GroupService(IRepository<Group> groupRepository,
                            IStudentRequestService studentRequestService,
                            IStudentService studentService,
                            IStudentToGroupAssignmentService assignmentService,
                            IUserService userService)
        {
            this.groupRepository = groupRepository;
            this.studentRequestService = studentRequestService;
            this.studentService = studentService;
            this.assignmentService = assignmentService;
            _userService = userService;
        }
        public async Task AddGroupAsync(Group group, IEnumerable<int> studentsId)
        {
            if (group == null)
                throw new ArgumentException();

            group.Students = null;

            await groupRepository.CreateAsync(group);

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
            await groupRepository.DeleteAsync(id);
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

            await groupRepository.UpdateAsync(group);
        }

        public Task<Group> GetGroupAsync(int id)
        {
            return groupRepository.GetAsync(id);
        }

        public Task<List<Group>> GetGroupsAsync()
        {
            return groupRepository.GetAllAsync();
        }

        public Task<IEnumerable<Group>> GetGroupsByPaginationAsync(PaginationFilter pagination)
        {
            return groupRepository.GetAllByPaginationAsync(pagination);
        }

        public async Task<IEnumerable<Student>> GetStudentsWithGroupAsync(int groupId, int courseId)
        {
            var group = await groupRepository.GetAsync(groupId);
            return group.CourseId == courseId ? group.Students : new List<Student>();
        }

        public async Task<IEnumerable<Group>> GetTeacherGroups(string email)
        {
            var user = await _userService.GetUserWithTeacherByEmail(email);
            if (user.Teacher == null)
                throw new NullReferenceException("Teacher not found");

            var groups = groupRepository.Find(g => g.TeacherId == user.Teacher.Id);
            return groups;
        }
    }
}
