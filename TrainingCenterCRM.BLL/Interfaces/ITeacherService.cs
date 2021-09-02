using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TrainingCenterCRM.BLL.Models;

namespace TrainingCenterCRM.BLL.Interfaces
{
    public interface ITeacherService
    {

        Task AddTeacherAsync(Teacher teacherDTO);
        Task EditTeacherAsync(Teacher teacherDTO);
        Task DeleteTeacherAsync(int id);
        Task<Teacher> GetTeacherAsync(int id);
        Task<List<Teacher>> GetTeachersAsync();
    }
}
