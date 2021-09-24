using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TrainingCenterCRM.BLL.Models;

namespace TrainingCenterCRM.BLL.Interfaces
{
    public interface ITeacherService
    {
        Task AddTeacherAsync(Teacher teacherDTO, IFormFile file);
        Task EditTeacherAsync(Teacher teacherDTO, IFormFile file);
        Task DeleteTeacherAsync(int id);
        Task<Teacher> GetTeacherAsync(int id);
        Task<List<Teacher>> GetTeachersAsync();
    }
}
