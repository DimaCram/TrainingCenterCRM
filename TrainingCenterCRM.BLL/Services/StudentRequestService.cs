using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrainingCenterCRM.BLL.Interfaces;
using TrainingCenterCRM.BLL.Models;
using TrainingCenterCRM.DAL.Interfaces;

namespace TrainingCenterCRM.BLL.Services
{
    public class StudentRequestService : IStudentRequestService
    {
        private readonly IRepository<StudentRequest> studentRequestRepository;

        public StudentRequestService(IRepository<StudentRequest> studentRequestRepository)
        {
            this.studentRequestRepository = studentRequestRepository;
        }

        public void AddRequest(StudentRequest model)
        {
            if (model == null)
                throw new ArgumentException();

            studentRequestRepository.Create(model);
        }

        public void DeleteRequest(int id)
        {
            studentRequestRepository.Delete(id);
        }

        public void EditRequest(StudentRequest model)
        {
            if (model == null)
                throw new ArgumentException();

            studentRequestRepository.Update(model);
        }

        public StudentRequest GetRequest(int id)
        {
            return studentRequestRepository.Get(id);
        }

        public List<StudentRequest> GetRequests()
        {
            return studentRequestRepository.GetAll();
        }
        public List<StudentRequest> GetOpenRequests()
        {
            return studentRequestRepository.GetAll().Where(sr => sr.RequestStatus == RequestStatus.Open).ToList();
        }
        public List<StudentRequest> GetOpenRequestsByCourse(int courseId)
        {
            return studentRequestRepository.GetAll()
                .Where(sr => sr.RequestStatus == RequestStatus.Open && sr.CourseId == courseId)
                .Distinct()
                .ToList();
        }
        public IEnumerable<Student> GetStudentsRequestedForCourse(int courseId)
        {
            return studentRequestRepository.GetAll()
                .Where(sr => sr.CourseId == courseId && sr.RequestStatus == RequestStatus.Open)
                .Select(s => s.Student)
                .Distinct();
        }

        public void ReOpenRequest(int studentId, int courseId)
        {
            var request = studentRequestRepository.Find(sr => sr.StudentId == studentId &&
                                                        sr.CourseId == courseId &&
                                                        sr.RequestStatus == RequestStatus.Closed).LastOrDefault();

            if(request != null)
            {
                request.RequestStatus = RequestStatus.Open;
                studentRequestRepository.Update(request);
            }
        }

        public void CloseRequests(List<int> studentsId, int courseId)
        {
            var requests = GetOpenRequestsByCourse(courseId).Where(r => studentsId.Contains(r.StudentId));

            foreach (var request in requests)
            {
                request.RequestStatus = RequestStatus.Closed;
                EditRequest(request);
            }
        }
    }
}
