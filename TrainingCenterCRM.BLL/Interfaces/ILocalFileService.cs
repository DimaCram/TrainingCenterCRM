using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using TrainingCenterCRM.Core.Enums;

namespace TrainingCenterCRM.BLL.Interfaces
{
    public interface ILocalFileService
    {
        Task AddFile(IFormFile file, string pathToFile);
        string GetFilePath(string nameFile, FileDestiny fileDestiny);
        void DeleteFile(string path);
        bool FileExists(string path);
    }
}
