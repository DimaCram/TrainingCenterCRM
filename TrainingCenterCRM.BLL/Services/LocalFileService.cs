using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using TrainingCenterCRM.BLL.Interfaces;

namespace TrainingCenterCRM.BLL.Services
{
    public class LocalFileService : ILocalFileService
    {
        private readonly string pathToAssets;
        public LocalFileService(string pathToAssets)
        {
            this.pathToAssets = $@"{pathToAssets}\..\ClientApp\src\";
        }
        public async Task AddFile(IFormFile file, string path)
        {
            string pathToFile = $"{pathToAssets}{path}";
            if (file != null && !File.Exists(pathToFile))
            {
                using var fileStream = new FileStream(pathToFile, FileMode.Create);
                await file.CopyToAsync(fileStream);
            }
        }
        public void DeleteFile(string path)
        {
            string pathToFile = $"{pathToAssets}{path}";
            if (File.Exists(pathToFile))
                File.Delete(pathToFile);
        }

        public bool FileExists(string path)
        {
            string pathToFile = $"{pathToAssets}{path}";
            return File.Exists(pathToFile);
        }
    }
}
