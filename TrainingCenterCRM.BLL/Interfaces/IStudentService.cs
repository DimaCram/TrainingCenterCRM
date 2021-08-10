using System;
using System.Collections.Generic;
using System.Text;
using TrainingCenterCRM.BLL.Models;

namespace TrainingCenterCRM.BLL.Interfaces
{
    public interface IStudentService
    {
        void AddStudent(Student studentDTO);
        void EditStudent(Student studentDTO);
        void DeleteStudent(int id);
        Student GetStudent(int id);
        List<Student> GetStudents();
    }
}
