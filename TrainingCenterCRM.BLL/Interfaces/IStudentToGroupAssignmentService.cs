using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TrainingCenterCRM.BLL.Models;

namespace TrainingCenterCRM.BLL.Interfaces
{
    public interface IStudentToGroupAssignmentService
    {
        Task AddAssignmentAsync(StudentToGroupAssignment dto);
        Task EditAssignmentAsync(StudentToGroupAssignment dto);
        Task DeleteAssignmentAsync(int id);
        Task<StudentToGroupAssignment> GetAssignmentAsync(int id);
        Task<StudentToGroupAssignment> GetAssignmentByStudentAsync(int studentId);
        Task<List<StudentToGroupAssignment>> GetAssignmentsAsync();
        Task<IEnumerable<StudentToGroupAssignment>> GetAssignmentsByGroupAsync(int groupId);

    }
}
