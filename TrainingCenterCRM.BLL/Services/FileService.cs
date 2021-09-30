﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
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
        private readonly IGroupService groupService;

        public FileService(IRepository<File> repository,
                           IGroupService groupService)
        {
            this.repository = repository;
            this.groupService = groupService;
        }

        public async Task AddFileAsync(File file)
        {
            if (file == null)
                throw new ArgumentException();

            await repository.CreateAsync(file);
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

                await repository.CreateAsync(file);
            }
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

        public async Task<IEnumerable<File>> GetFilesByGroupAsync(int groupId)
        {
            var group = await groupService.GetGroupAsync(groupId);
            return repository.Find(f => f.CourseId == group.CourseId);
        }
        public List<File> GetFilesByMaterialAsync(int materialId)
        {
            return repository.Find(f => f.Materials.Any(m => m.Id == materialId)).ToList();
        }
    }
}
