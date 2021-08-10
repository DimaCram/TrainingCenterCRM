using System;
using System.Collections.Generic;
using System.Text;
using TrainingCenterCRM.BLL.Models;

namespace TrainingCenterCRM.BLL.Interfaces
{
    public interface ITeacherService
    {

        void AddTeacher(Teacher teacherDTO);
        void EditTeacher(Teacher teacherDTO);
        void DeleteTeacher(int id);
        Teacher GetTeacher(int id);
        List<Teacher> GetTeachers();
    }
}
