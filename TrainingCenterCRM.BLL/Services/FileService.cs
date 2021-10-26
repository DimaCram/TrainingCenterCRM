using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TrainingCenterCRM.BLL.Interfaces;
using TrainingCenterCRM.Core.Models;
using TrainingCenterCRM.DAL.EF.Interfaces;

namespace TrainingCenterCRM.BLL.Services
{
    public class FileService : IFileService
    {
        private readonly IFileRepository repository;

        public FileService(IFileRepository repository)
        {
            this.repository = repository;
        }

        public async Task AddFileAsync(File file)
        {
            if (file == null)
                throw new ArgumentException();

            await repository.Create(file);
        }

        public async Task AddFilesAsync(List<IFormFile> formFiles, int courseId)
        {
            if(courseId == 0 || formFiles.Count == 0)
                throw new ArgumentException();


            foreach (var formFileModel in formFiles)
            {
                var file = new File
                {
                    Name = formFileModel.FileName,
                    FileType = formFileModel.ContentType,
                    CreateDate = DateTime.Now,
                    CourseId = courseId,
                };

                using (var target = new System.IO.MemoryStream())
                {
                    formFileModel.CopyTo(target);
                    file.Data = target.ToArray();
                }

                await repository.Create(file);
            }
        }

        public async Task DeleteFileAsync(int id)
        {
            await repository.Delete(id);
        }

        public async Task EditFileAsync(File file)
        {
            await repository.Update(file);
        }

        public Task<File> GetFileAsync(int id)
        {
            return repository.Get(id);
        }

        public Task<List<File>> GetFilesAsync()
        {
            return repository.GetAll();
        }

        public async Task<IEnumerable<File>> GetFilesByCourseAsync(int courseId)
        {
            return await repository.Find(f => f.CourseId == courseId);
        }
    }
}
