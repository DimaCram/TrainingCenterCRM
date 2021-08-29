using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public void AddGroup(Group group, List<int> studentsId)
        {
            if (group == null)
                throw new ArgumentException();

            groupRepository.Create(group);

            foreach(var studentId in studentsId)
            {
                assignmentService.AddAssignment(new StudentToGroupAssignment
                {
                    GroupId = group.Id,
                    StudentId = studentId,
                    AssignmentDate = DateTime.Now,
                    Result = ResultType.Graduated
                });

                var student = studentService.GetStudent(studentId);
                student.GroupId = group.Id;
                studentService.EditStudent(student);
            }

            studentRequestService.CloseRequests(studentsId, group.CourseId);
        }

        public void DeleteGroup(int id)
        {
            groupRepository.Delete(id);
        }

        public void EditGroup(Group group, List<int> studentsId)
        {
            if (group == null)
                throw new ArgumentException();

            var assignmentsForDelete = assignmentService.GetAssignmentsByGroup(group.Id)
                                                        .Where(stg => !studentsId.Contains(stg.StudentId)).ToList();

            foreach(var assigment in assignmentsForDelete)
            {
                assignmentService.DeleteAssignment(assigment.StudentToGroupAssignmentId);

                var student = studentService.GetStudent(assigment.StudentId);
                student.GroupId = null;
                studentService.EditStudent(student);

                studentRequestService.ReOpenRequest(assigment.StudentId, group.CourseId);
            }

            foreach (var studentId in studentsId)
            {
                var assignment = assignmentService.GetAssignmentByStudent(studentId);
                
                if (assignment == null)
                {

                    assignmentService.AddAssignment(new StudentToGroupAssignment
                    {
                        GroupId = group.Id,
                        StudentId = studentId,
                        AssignmentDate = DateTime.Now,
                        Result = ResultType.Graduated
                    });

                    var student = studentService.GetStudent(studentId);
                    student.GroupId = group.Id;
                    studentService.EditStudent(student);
                }
            }

            studentRequestService.CloseRequests(studentsId, group.CourseId);

            groupRepository.Update(group);
        }

        public Group GetGroup(int id)
        {
            return groupRepository.Get(id);
        }

        public List<Group> GetGroups()
        {
            return groupRepository.GetAll();
        }
        public IEnumerable<Student> GetStudentsWithGroup(int groupId, int courseId)
        {
            var group = groupRepository.Get(groupId);
            return group.CourseId == courseId ? group.Students : new List<Student>();
        }
    }
}
