using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TrainingCenterCRM.BLL.Interfaces;
using TrainingCenterCRM.BLL.Models;
using TrainingCenterCRM.DAL.Interfaces;

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
    }
}
