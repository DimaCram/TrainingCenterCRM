using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingCenterCRM.BLL.Models;
using TrainingCenterCRM.DAL.EF.Context;
using TrainingCenterCRM.DAL.Interfaces;

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
            var teacher = await db.Teachers.FindAsync(id);
            if (teacher == null)
                throw new ArgumentException("Teacher not found");
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
    }
}
