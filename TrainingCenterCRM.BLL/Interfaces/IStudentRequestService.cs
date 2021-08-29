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
        List<StudentRequest> GetOpenRequests();
        List<StudentRequest> GetOpenRequestsByCourse(int courseId);
        IEnumerable<Student> GetStudentsRequestedForCourse(int courseId);
        void ReOpenRequest(int studentId, int courseId);
        void CloseRequests(List<int> studentsId, int courseId);
    }
}
