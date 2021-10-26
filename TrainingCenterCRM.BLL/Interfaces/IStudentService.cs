using System.Collections.Generic;
using System.Threading.Tasks;
using TrainingCenterCRM.Core.Filters;
using TrainingCenterCRM.Core.Models;

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
        Task<IEnumerable<Student>> GetStudentsByGroupAsync(int groupId);
        Task<IEnumerable<Student>> GetStudentsByPaginationAsync(PaginationFilter filter);
    }
}
