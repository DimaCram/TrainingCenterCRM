using System.Collections.Generic;
using System.Threading.Tasks;
using TrainingCenterCRM.Core.Models;

namespace TrainingCenterCRM.BLL.Interfaces
{
    public interface IFileToMaterialAssignmentService
    {
        Task AddAssignmentAsync(FileToMaterialAssignment assignment);
        Task EditAssignmentAsync(FileToMaterialAssignment assignment);
        Task DeleteAssignmentAsync(int id);
        Task<FileToMaterialAssignment> GetAssignmentAsync(int id);
        Task<List<FileToMaterialAssignment>> GetAssignmentsAsync();
        Task<IEnumerable<File>> GetFilesByMaterial(int materialId);
        Task DeleteAssignmentsByMaterial(int materialId);
    }
}
