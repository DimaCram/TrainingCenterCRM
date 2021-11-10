using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TrainingCenterCRM.BLL.Interfaces;
using TrainingCenterCRM.Core.Enums;

namespace TrainingCenterCRM.BLL.Services
{
    public class LocalFileService : ILocalFileService
    {
        private readonly string _pathToAssets;
        private readonly IConfiguration _configuration;

        public LocalFileService(string webRootPath, IConfiguration configuration)
        {
            _configuration = configuration;
            _pathToAssets = webRootPath;
        }
        public async Task AddFile(IFormFile file, string pathToFile)
        {
            string fullPathToFile = $@"{_pathToAssets}\{pathToFile}";
            if (file != null && !File.Exists(fullPathToFile))
            {
                using var fileStream = new FileStream(fullPathToFile, FileMode.Create);
                await file.CopyToAsync(fileStream);
            }
        }

        public void DeleteFile(string path)
        {
            string pathToFile = $@"{_pathToAssets}\{path}";
            if (File.Exists(pathToFile))
                File.Delete(pathToFile);
        }

        public bool FileExists(string path)
        {
            string pathToFile = $@"{_pathToAssets}\{path}";
            return File.Exists(pathToFile);
        }

        public string GetFilePath(string nameFile, FileDestiny fileDestiny)
        {
            var uniqueFileName = GenerateUniqueFileName(nameFile);
            var pathToFolder = GetFilePathByDestiny(fileDestiny);
            return $@"{pathToFolder}\{uniqueFileName}";
        }

        private string GetFilePathByDestiny(FileDestiny fileDestiny)
        {
            return fileDestiny switch
            {
                FileDestiny.Course => _configuration["FilePathOptions:PathToCourseImg"],
                FileDestiny.Teacher => _configuration["FilePathOptions:PathToTeacherImg"],
                _ => throw new ArgumentException("File destiny not found"),
            };
        }
        private string GenerateUniqueFileName(string fileName)
        {
            var fileType = fileName.Split('.').LastOrDefault();
            
            if (string.IsNullOrEmpty(fileType))
                throw new ArgumentException("Cannot get file type");

            return $"{Guid.NewGuid()}.{fileType}";
        }
    }
}
