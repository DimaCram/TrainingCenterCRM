using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TrainingCenterCRM.BLL.Interfaces;
using TrainingCenterCRM.BLL.Models;
using TrainingCenterCRM.DAL.Interfaces;

namespace TrainingCenterCRM.BLL.Services
{
    public class FileService : IFileService
    {
        private readonly IRepository<File> repository;

        public FileService(IRepository<File> repository)
        {
            this.repository = repository;
        }

        public async Task AddFileAsync(File file)
        {
            if (file == null)
                throw new ArgumentException();

            await repository.CreateAsync(file);
        }

        public async Task AddFilesAsync(List<File> files)
        {
            if(files == null || files.Count == 0)
                throw new ArgumentException();

            foreach (var file in files)
                await repository.CreateAsync(file);
        }

        public async Task DeleteFileAsync(int id)
        {
            await repository.DeleteAsync(id);
        }

        public async Task EditFileAsync(File file)
        {
            await repository.UpdateAsync(file);
        }

        public Task<File> GetFileAsync(int id)
        {
            return repository.GetAsync(id);
        }

        public Task<List<File>> GetFilesAsync()
        {
            return repository.GetAllAsync();
        }
    }
}
