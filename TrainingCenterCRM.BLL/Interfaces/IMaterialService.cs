using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TrainingCenterCRM.BLL.Models;

namespace TrainingCenterCRM.BLL.Interfaces
{
    public interface IMaterialService
    {
        Task AddMaterialAsync(Material material, List<int> fileIds);
        Task EditMaterialAsync(Material material, List<int> fileIds);
        Task DeleteMaterialAsync(int id);
        Task<Material> GetMaterialAsync(int id);
        Task<List<Material>> GetMaterialsAsync();
    }
}
