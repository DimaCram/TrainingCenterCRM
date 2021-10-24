using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using TrainingCenterCRM.Core.Filters;
using TrainingCenterCRM.Core.Models;

namespace TrainingCenterCRM.BLL.Interfaces
{
    public interface ICourseService
    {
        Task AddCourseAsync(Course courseDTO);
        Task EditCourseAsync(Course courseDTO);
        Task DeleteCourseAsync(int id);
        Task<Course> GetCourseAsync(int id);
        Task<List<Course>> GetCoursesAsync();
        Task<IEnumerable<Course>> GetCoursesByPaginationAsync(PaginationFilter pagination);
        Task<IEnumerable<Course>> Search(string search);
        Task<IEnumerable<Course>> Filter(CourseFilter filter);
    }
}
