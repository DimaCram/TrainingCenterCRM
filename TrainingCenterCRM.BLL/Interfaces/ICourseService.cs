using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TrainingCenterCRM.BLL.Models;

namespace TrainingCenterCRM.BLL.Interfaces
{
    public interface ICourseService
    {
        Task AddCourseAsync(Course courseDTO, IFormFile file);
        Task EditCourseAsync(Course courseDTO, IFormFile file);
        Task DeleteCourseAsync(int id);
        Task<Course> GetCourseAsync(int id);
        Task<List<Course>> GetCoursesAsync();
    }
}
