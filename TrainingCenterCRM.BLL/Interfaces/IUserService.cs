using System.Collections.Generic;
using System.Threading.Tasks;
using TrainingCenterCRM.Core.Models;

namespace TrainingCenterCRM.BLL.Interfaces
{
    public interface IUserService
    {
        Task AddUser(string email, string password, string role);
        Task<string> GetUserIdByEmail(string email);
        Task<bool> CheckPassword(string email, string password);
        Task<string> GetToken(string email);
        Task<List<string>> GetUserRoles(string email);
        Task<User> GetUserWithTeacherByEmail(string email);
    }
}
