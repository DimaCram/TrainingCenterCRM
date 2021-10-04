using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingCenterCRM.Core.Models;
using TrainingCenterCRM.DAL.EF.Context;
using TrainingCenterCRM.DAL.EF.Interfaces;

namespace TrainingCenterCRM.DAL.EF.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly TrainingCenterContext db;

        public UserRepository(TrainingCenterContext db)
        {
            this.db = db;
        }
        public Task<User> GetUserWithTeacherByEmail(string email)
        {
            return db.Users.Include(u => u.Teacher).SingleOrDefaultAsync(u => u.Email == email);
        }
    }
}
