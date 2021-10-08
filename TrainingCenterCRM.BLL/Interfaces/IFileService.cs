using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using TrainingCenterCRM.Core.Models;

namespace TrainingCenterCRM.BLL.Interfaces
{
    public interface IFileService
    {
        Task AddFilesAsync(List<IFormFile> files, int courseId);
        Task AddFileAsync(File file);
        Task EditFileAsync(File file);
        Task DeleteFileAsync(int id);
        Task<File> GetFileAsync(int id);
        Task<List<File>> GetFilesAsync();
        Task<IEnumerable<File>> GetFilesByCourseAsync(int groupId);
    }
}
