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
        public IEnumerable<Student> GetStudentsByCourse(int courseId)
        {
            return studentRequestRepository.GetAll().Where(sr => sr.CourseId == courseId).Select(s => s.Student).Distinct();
        }
    }
}
