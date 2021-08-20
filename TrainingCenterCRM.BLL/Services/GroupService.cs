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
        private readonly IRepository<StudentToGroupAssignment> studentToGroupRepository;
        private readonly IRepository<Student> studentRepository;
        private readonly IRepository<StudentRequest> studentRequestRepository;

        public GroupService(IRepository<Group> groupRepository,
                            IRepository<StudentToGroupAssignment> studentToGroupRepository,
                            IRepository<Student> studentRepository, 
                            IRepository<StudentRequest> studentRequestRepository)
        {
            this.groupRepository = groupRepository;
            this.studentToGroupRepository = studentToGroupRepository;
            this.studentRepository = studentRepository;
            this.studentRequestRepository = studentRequestRepository;
        }
        public void AddGroup(Group group, List<int> studentsId)
        {
            if (group == null)
                throw new ArgumentException();

            groupRepository.Create(group);

            foreach(var studentId in studentsId)
            {
                var assignment = new StudentToGroupAssignment {
                    GroupId = group.Id,
                    StudentId = studentId,
                    AssignmentDate = DateTime.Now,
                    Result = ResultType.Graduated
                };
                studentToGroupRepository.Create(assignment);

                var student = studentRepository.Get(studentId);
                student.GroupId = group.Id;
                studentRepository.Update(student);
            }

            var requestsId = studentRequestRepository.Find(r => studentsId.Contains(r.StudentId) && r.CourseId == group.CourseId)
                                                     .Select(r => r.Id);

            foreach(var requestId in requestsId)
            {
                studentRequestRepository.Delete(requestId);
            }
        }

        public void DeleteGroup(int id)
        {
            groupRepository.Delete(id);
        }

        public void EditGroup(Group group, List<int> studentsId)
        {
            if (group == null)
                throw new ArgumentException();

            var assignmentsForDelete = studentToGroupRepository.Find(stg => stg.GroupId == group.Id).Where(stg => !studentsId.Contains(stg.StudentId)).ToList();

            foreach(var assigment in assignmentsForDelete)
            {
                studentToGroupRepository.Delete(assigment.StudentToGroupAssignmentId);

                var student = studentRepository.Get(assigment.StudentId);
                student.GroupId = null;
                studentRepository.Update(student);

                var studentRequests = new StudentRequest
                {
                    ReadyToStartDate = DateTime.Today,
                    CourseId = group.CourseId,
                    StudentId = assigment.StudentId,
                    Comments = ""
                };
                studentRequestRepository.Create(studentRequests);
            }


            foreach (var studentId in studentsId)
            {
                var assignment = studentToGroupRepository.Find(stg => stg.StudentId == studentId).FirstOrDefault();
                
                if (assignment == null)
                {
                    assignment = new StudentToGroupAssignment
                    {
                        GroupId = group.Id,
                        StudentId = studentId,
                        AssignmentDate = DateTime.Now,
                        Result = ResultType.Graduated
                    };
                    studentToGroupRepository.Create(assignment);

                    var student = studentRepository.Get(studentId);
                    student.GroupId = group.Id;
                    studentRepository.Update(student);
                }
            }

            var requestsId = studentRequestRepository.Find(r => studentsId.Contains(r.StudentId) && r.CourseId == group.CourseId)
                                                     .Select(r => r.Id);

            foreach (var requestId in requestsId)
            {
                studentRequestRepository.Delete(requestId);
            }
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
