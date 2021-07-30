using System;
using System.Collections.Generic;
using System.Text;
using TrainingCenterCRM.BLL.DTO;
using TrainingCenterCRM.DAL.Enttities;

namespace TrainingCenterCRM.BLL.Interfaces
{
    public interface ITeacherService
    {

        void AddTeacher(TeacherDTO teacherDTO);
        void EditTeacher(TeacherDTO teacherDTO);
        void DeleteTeacher(int id);
        TeacherDTO GetTeacher(int id);
        List<Teacher> GetTeachers();
        void Dispose();
    }
}
