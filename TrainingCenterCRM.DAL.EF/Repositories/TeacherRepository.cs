using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingCenterCRM.Core.Filters;
using TrainingCenterCRM.Core.Models;
using TrainingCenterCRM.DAL.EF.Context;
using TrainingCenterCRM.DAL.EF.Interfaces;

namespace TrainingCenterCRM.DAL.EF.Repositories
{
    public class TeacherRepository : IRepository<Teacher>
    {
        private readonly TrainingCenterContext db;

        public TeacherRepository(TrainingCenterContext db)
        {
            this.db = db;
        }
        public async Task CreateAsync(Teacher item)
        {
            await db.AddAsync(item);
            await db.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var teacher = await db.Teachers.Include(s => s.User).SingleAsync(s => s.Id == id);

            if (teacher == null)
                throw new ArgumentException("Teacher not found");

            if (teacher.User != null)
                db.Users.Remove(teacher.User);

            db.Teachers.Remove(teacher);
            await db.SaveChangesAsync();
        }

        public IEnumerable<Teacher> Find(Func<Teacher, bool> predicate)
        {
            return db.Teachers.Where(predicate).ToList();
        }

        public Task<Teacher> GetAsync(int id)
        {
            return db.Teachers.FirstOrDefaultAsync(t => t.Id == id);
        }

        public Task<List<Teacher>> GetAllAsync()
        {
            return db.Teachers.ToListAsync();
        }

        public async Task UpdateAsync(Teacher item)
        {
            db.Entry(item).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }

        public Task<IEnumerable<Teacher>> GetAllByPaginationAsync(PaginationFilter pagination)
        {
            throw new NotImplementedException();
        }
    }
}
