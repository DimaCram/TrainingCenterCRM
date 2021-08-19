using System;
using System.Collections.Generic;
using System.Text;
using TrainingCenterCRM.BLL.Models;

namespace TrainingCenterCRM.BLL.Interfaces
{
    public interface IStudentRequestService
    {
        void AddRequest(StudentRequest model);
        void EditRequest(StudentRequest model);
        void DeleteRequest(int id);
        StudentRequest GetRequest(int id);
        List<StudentRequest> GetRequests();
        IEnumerable<Student> GetStudentsByCourse(int courseId);
    }
}
