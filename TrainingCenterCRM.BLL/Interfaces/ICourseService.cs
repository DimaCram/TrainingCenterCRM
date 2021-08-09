using System;
using System.Collections.Generic;
using System.Text;
using TrainingCenterCRM.BLL.DTO;
using TrainingCenterCRM.DAL.Enttities;

namespace TrainingCenterCRM.BLL.Interfaces
{
    public interface ICourseService
    {
        void AddCourse(CourseDTO courseDTO);
        void EditCourse(CourseDTO courseDTO);
        void DeleteCourse(int id);
        CourseDTO GetCourse(int id);
        List<Course> GetCourses();
        void Dispose();
    }
}
