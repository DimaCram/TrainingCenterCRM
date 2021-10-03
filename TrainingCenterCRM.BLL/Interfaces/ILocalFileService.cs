using Microsoft.AspNetCore.Http;
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
