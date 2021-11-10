using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TrainingCenterCRM.Core.Filters;
using TrainingCenterCRM.Core.Models;
using TrainingCenterCRM.DAL.EF.Context;
using TrainingCenterCRM.DAL.EF.Interfaces;

namespace TrainingCenterCRM.DAL.EF.Repositories
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly TrainingCenterContext db;

        public TeacherRepository(TrainingCenterContext db)
        {
            this.db = db;
        }
        public async Task Create(Teacher item)
        {
            await db.AddAsync(item);
            await db.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var teacher = await db.Teachers.Include(s => s.User).SingleAsync(s => s.Id == id);

            if (teacher == null)
                throw new ArgumentException("Teacher not found");

            if (teacher.User != null)
                db.Users.Remove(teacher.User);

            db.Teachers.Remove(teacher);
            await db.SaveChangesAsync();
        }

        public async Task<IEnumerable<Teacher>> Find(Expression<Func<Teacher, bool>> predicate)
        {
            return await db.Teachers.Where(predicate).ToListAsync();
        }

        public Task<Teacher> Get(int id)
        {
            return db.Teachers.FirstOrDefaultAsync(t => t.Id == id);
        }

        public Task<List<Teacher>> GetAll()
        {
            return db.Teachers.ToListAsync();
        }

        public async Task Update(Teacher item)
        {
            db.Entry(item).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }

        public async Task<IEnumerable<Teacher>> GetAllByPagination(PaginationFilter pagination)
        {
            return await db.Teachers.Skip((pagination.Offset - 1) * pagination.Limit)
                                    .Take(pagination.Limit)
                                    .ToListAsync();
        }
    }
}
