using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingCenterCRM.BLL.Interfaces;
using TrainingCenterCRM.Core.Models;
using TrainingCenterCRM.DAL.EF.Interfaces;

namespace TrainingCenterCRM.BLL.Services
{
    public class FileToMaterialAssignmentService : IFileToMaterialAssignmentService
    {
        private readonly IFileToMaterialAssignmentRepository repository;

        public FileToMaterialAssignmentService(IFileToMaterialAssignmentRepository repository)
        {
            this.repository = repository;
        }
        public async Task AddAssignmentAsync(FileToMaterialAssignment assignment)
        {
            if(assignment == null)
                throw new ArgumentException();

            await repository.Create(assignment);
        }

        public async Task DeleteAssignmentAsync(int id)
        {
            await repository.Delete(id);
        }

        public async Task EditAssignmentAsync(FileToMaterialAssignment assignment)
        {
            if (assignment == null)
                throw new ArgumentException();

            await repository.Update(assignment);
        }

        public Task<FileToMaterialAssignment> GetAssignmentAsync(int id)
        {
            return repository.Get(id);
        }

        public Task<List<FileToMaterialAssignment>> GetAssignmentsAsync()
        {
            return repository.GetAll();
        }

        public async Task<IEnumerable<File>> GetFilesByMaterial(int materialId)
        {
            return (await repository.Find(r => r.MaterialId == materialId)).Select(r => r.File);
        }
        public async Task DeleteAssignmentsByMaterial(int materialId)
        {
            var assigmentsForMaterial = await repository.Find(a => a.MaterialId == materialId);
            
            await repository.DeleteRange(assigmentsForMaterial.Select(a => a.Id));
        }
    }
}
