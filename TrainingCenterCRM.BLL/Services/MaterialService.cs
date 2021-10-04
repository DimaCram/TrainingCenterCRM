using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TrainingCenterCRM.BLL.Interfaces;
using TrainingCenterCRM.Core.Models;
using TrainingCenterCRM.DAL.EF.Interfaces;

namespace TrainingCenterCRM.BLL.Services
{
    public class MaterialService : IMaterialService
    {
        private readonly IRepository<Material> repository;
        private readonly IFileToMaterialAssignmentService _materialAssignmentService;

        public MaterialService(IRepository<Material> repository,
                               IFileToMaterialAssignmentService materialAssignmentService)
        {
            this.repository = repository;
            _materialAssignmentService = materialAssignmentService;
        }

        public async Task AddMaterialAsync(Material material, List<int> fileIds)
        {
            if (material == null)
                throw new ArgumentException();

            await repository.CreateAsync(material);

            foreach(var fileId in fileIds)
            {
                await _materialAssignmentService.AddAssignmentAsync(new FileToMaterialAssignment
                {
                    FileId = fileId,
                    MaterialId = material.Id,
                    TeacherId = 1
                });
            }
        }

        public async Task DeleteMaterialAsync(int id)
        {
            await repository.DeleteAsync(id);
        }

        public async Task EditMaterialAsync(Material material, List<int> fileIds)
        {
            if (material == null)
                throw new ArgumentException();

            //remove old assignment
            await _materialAssignmentService.DeleteAssignmentsByMaterial(material.Id);

            //add new assignment
            foreach (var fileId in fileIds)
            {
                await _materialAssignmentService.AddAssignmentAsync(new FileToMaterialAssignment 
                { 
                    MaterialId = material.Id,
                    FileId = fileId,
                    TeacherId = 1
                });
            }

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

        public IEnumerable<Material> GetMaterialsByGroup(int groupId)
        {
            return repository.Find(m => m.GroupId == groupId);
        }
    }
}
