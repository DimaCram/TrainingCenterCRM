using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TrainingCenterCRM.BLL.Models;

namespace TrainingCenterCRM.BLL.Interfaces
{
    public interface IFileToMaterialAssignmentService
    {
        Task AddAssignmentAsync(FileToMaterialAssignment assignment);
        Task EditAssignmentAsync(FileToMaterialAssignment assignment);
        Task DeleteAssignmentAsync(int id);
        Task<FileToMaterialAssignment> GetAssignmentAsync(int id);
        Task<List<FileToMaterialAssignment>> GetAssignmentsAsync();
    }
}
