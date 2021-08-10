using System;
using System.Collections.Generic;
using System.Text;
using TrainingCenterCRM.BLL.Models;

namespace TrainingCenterCRM.BLL.Interfaces
{
    public interface ICourseService
    {
        void AddCourse(Course courseDTO);
        void EditCourse(Course courseDTO);
        void DeleteCourse(int id);
        Course GetCourse(int id);
        List<Course> GetCourses();
    }
}
