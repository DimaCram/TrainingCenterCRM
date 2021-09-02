using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TrainingCenterCRM.BLL.Models;

namespace TrainingCenterCRM.BLL.Interfaces
{
    public interface IStudentService
    {
        Task AddStudentAsync(Student studentDTO);
        Task EditStudentAsync(Student studentDTO);
        Task DeleteStudentAsync(int id);
        Task<Student> GetStudentAsync(int id);
        Task<Student> GetStudentWithGroupAsync(int id);
        Task<List<Student>> GetStudentsAsync();
    }
}
