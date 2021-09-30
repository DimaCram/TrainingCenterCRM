using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TrainingCenterCRM.BLL.Models;

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
        Task<IEnumerable<File>> GetFilesByGroupAsync(int groupId);
        List<File> GetFilesByMaterialAsync(int materialId);
    }
}
