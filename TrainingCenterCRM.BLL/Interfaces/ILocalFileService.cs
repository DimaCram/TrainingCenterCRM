using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TrainingCenterCRM.BLL.Interfaces
{
    public interface ILocalFileService
    {
        Task AddFile(IFormFile file, string path);
        void DeleteFile(string path);
        bool FileExists(string path);
    }
}
