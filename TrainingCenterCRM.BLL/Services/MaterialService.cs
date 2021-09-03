using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TrainingCenterCRM.BLL.Interfaces;
using TrainingCenterCRM.BLL.Models;
using TrainingCenterCRM.DAL.Interfaces;

namespace TrainingCenterCRM.BLL.Services
{
    public class MaterialService : IMaterialService
    {
        private readonly IRepository<Material> repository;

        public MaterialService(IRepository<Material> repository)
        {
            this.repository = repository;
        }

        public async Task AddMaterialAsync(Material material)
        {
            if (material == null)
                throw new ArgumentException();

            await repository.CreateAsync(material);
        }

        public async Task DeleteMaterialAsync(int id)
        {
            await repository.DeleteAsync(id);
        }

        public async Task EditMaterialAsync(Material material)
        {
            if (material == null)
                throw new ArgumentException();

            await repository.UpdateAsync(material);
        }

        public Task<Material> GetMaterialAsync(int id)
        {
            return repository.GetAsync(id);
        }

        public Task<List<Material>> GetMaterialsAsync()
        {
            return repository.GetAllAsync();
        }
    }
}
