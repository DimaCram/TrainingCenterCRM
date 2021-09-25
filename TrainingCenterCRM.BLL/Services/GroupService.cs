using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingCenterCRM.BLL.Interfaces;
using TrainingCenterCRM.BLL.Models;
using TrainingCenterCRM.DAL.Interfaces;

namespace TrainingCenterCRM.BLL.Services
{
    public class GroupService : IGroupService
    {
        private readonly IRepository<Group> groupRepository;

        private readonly IStudentRequestService studentRequestService;
        private readonly IStudentToGroupAssignmentService assignmentService;
        private readonly IStudentService studentService;

        public GroupService(IRepository<Group> groupRepository,
                            IStudentRequestService studentRequestService,
                            IStudentService studentService, 
                            IStudentToGroupAssignmentService assignmentService)
        {
            this.groupRepository = groupRepository;
            this.studentRequestService = studentRequestService;
            this.studentService = studentService;
            this.assignmentService = assignmentService;
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
        public async Task<IEnumerable<Student>> GetStudentsWithGroupAsync(int groupId, int courseId)
        {
            var group = await groupRepository.GetAsync(groupId);
            return group.CourseId == courseId ? group.Students : new List<Student>();
        }
    }
}
