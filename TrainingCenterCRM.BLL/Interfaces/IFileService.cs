using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TrainingCenterCRM.BLL.Models;

namespace TrainingCenterCRM.BLL.Interfaces
{
    public interface IFileService
    {
        Task AddFileAsync(File file);
        Task EditFileAsync(File file);
        Task DeleteFileAsync(int id);
        Task<File> GetFileAsync(int id);
        Task<List<File>> GetFilesAsync();
    }
}
