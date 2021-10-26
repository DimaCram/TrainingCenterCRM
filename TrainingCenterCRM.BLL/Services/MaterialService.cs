using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TrainingCenterCRM.BLL.Interfaces;
using TrainingCenterCRM.Core.Filters;
using TrainingCenterCRM.Core.Models;
using TrainingCenterCRM.DAL.EF.Interfaces;

namespace TrainingCenterCRM.BLL.Services
{
    public class MaterialService : IMaterialService
    {
        private readonly IMaterialRepository repository;
        private readonly IFileToMaterialAssignmentService _materialAssignmentService;

        public MaterialService(IMaterialRepository repository,
                               IFileToMaterialAssignmentService materialAssignmentService)
        {
            this.repository = repository;
            _materialAssignmentService = materialAssignmentService;
        }

        public async Task AddMaterialAsync(Material material, List<int> fileIds)
        {
            if (material == null)
                throw new ArgumentException();

            await repository.Create(material);

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
            await repository.Delete(id);
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

            await repository.Update(material);
        }

        public Task<Material> GetMaterialAsync(int id)
        {
            return repository.Get(id);
        }

        public Task<List<Material>> GetMaterialsAsync()
        {
            return repository.GetAll();
        }

        public async Task<IEnumerable<Material>> GetMaterialsByGroupAsync(int groupId)
        {
            return await repository.Find(m => m.GroupId == groupId);
        }

        public Task<IEnumerable<Material>> GetMaterialsByPaginationAsync(PaginationFilter pagination)
        {
            return repository.GetAllByPagination(pagination);
        }
    }
}
