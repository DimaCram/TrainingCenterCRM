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
        private readonly IRepository<FileToMaterialAssignment> repository;

        public FileToMaterialAssignmentService(IRepository<FileToMaterialAssignment> repository)
        {
            this.repository = repository;
        }
        public async Task AddAssignmentAsync(FileToMaterialAssignment assignment)
        {
            if(assignment == null)
                throw new ArgumentException();

            await repository.CreateAsync(assignment);
        }

        public async Task DeleteAssignmentAsync(int id)
        {
            await repository.DeleteAsync(id);
        }

        public async Task EditAssignmentAsync(FileToMaterialAssignment assignment)
        {
            if (assignment == null)
                throw new ArgumentException();

            await repository.UpdateAsync(assignment);
        }

        public Task<FileToMaterialAssignment> GetAssignmentAsync(int id)
        {
            return repository.GetAsync(id);
        }

        public Task<List<FileToMaterialAssignment>> GetAssignmentsAsync()
        {
            return repository.GetAllAsync();
        }

        public IEnumerable<File> GetFilesByMaterial(int materialId)
        {
            return repository.Find(r => r.MaterialId == materialId).Select(r => r.File);
        }
        public async Task DeleteAssignmentsByMaterial(int materialId)
        {
            var assigmentForMaterial = repository.Find(a => a.MaterialId == materialId).ToList();
            foreach(var assigment in assigmentForMaterial)
            {
                await repository.DeleteAsync(assigment.Id);
            }
        }
    }
}
