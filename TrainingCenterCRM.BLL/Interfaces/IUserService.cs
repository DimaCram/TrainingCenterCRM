using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TrainingCenterCRM.BLL.Interfaces
{
    public interface IUserService
    {
        Task AddUser(string email, string password, string role);
        Task<string> GetUserIdByEmail(string email);
    }
}
