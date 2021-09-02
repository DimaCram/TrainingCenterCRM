using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TrainingCenterCRM.BLL.Models;

namespace TrainingCenterCRM.BLL.Interfaces
{
    public interface ICourseService
    {
        Task AddCourseAsync(Course courseDTO);
        Task EditCourseAsync(Course courseDTO);
        Task DeleteCourseAsync(int id);
        Task<Course> GetCourseAsync(int id);
        Task<List<Course>> GetCoursesAsync();
    }
}
