using System;
using System.Collections.Generic;
using System.Text;
using TrainingCenterCRM.BLL.DTO;
using TrainingCenterCRM.DAL.Enttities;

namespace TrainingCenterCRM.BLL.Interfaces
{
    public interface IStudentService
    {
        void AddStudent(StudentDTO studentDTO);
        void EditStudent(StudentDTO studentDTO);
        void DeleteStudent(int id);
        StudentDTO GetStudent(int id);
        List<Student> GetStudents();
        void Dispose();
    }
}
