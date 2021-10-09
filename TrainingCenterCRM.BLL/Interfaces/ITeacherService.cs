using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using TrainingCenterCRM.Core.Filters;
using TrainingCenterCRM.Core.Models;

namespace TrainingCenterCRM.BLL.Interfaces
{
    public interface ITeacherService
    {
        Task AddTeacherAsync(Teacher teacherDTO, IFormFile file);
        Task EditTeacherAsync(Teacher teacherDTO, IFormFile file);
        Task DeleteTeacherAsync(int id);
        Task<Teacher> GetTeacherAsync(int id);
        Task<List<Teacher>> GetTeachersAsync();
        Task<IEnumerable<Teacher>> GetTeachersByPaginationAsync(PaginationFilter pagination);
    }
}
