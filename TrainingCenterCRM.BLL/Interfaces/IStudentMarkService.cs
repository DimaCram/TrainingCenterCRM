using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TrainingCenterCRM.Core.Models;

namespace TrainingCenterCRM.BLL.Interfaces
{
    public interface IStudentMarkService
    {
        Task AddMarkAsync(StudentMark studentMark);
        Task EditMarkAsync(StudentMark studentMark);
        Task DeleteMarkAsync(int id);
        Task<StudentMark> GetMarkAsync(int id);
        Task<List<StudentMark>> GetMarksAsync();
        Task<IEnumerable<StudentMark>> GetMarksByGroup(int groupId);
        Task<IEnumerable<StudentMark>> GetStudentMarksByGroup(int groupId, string userEmail);
        Task<double> GetStudentAverageMarkByGroup(int groupId, string userEmail);
    }
}
