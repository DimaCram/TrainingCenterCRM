using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TrainingCenterCRM.Core.Models;

namespace TrainingCenterCRM.DAL.EF.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetUserWithTeacherByEmail(string email);
        Task<User> GetUserWithStudentByEmail(string email);
    }
}
