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
    public class StudentRepository : IRepository<Student>
    {
        public TrainingCenterContext db;

        public StudentRepository(TrainingCenterContext db)
        {
            this.db = db;
        }
        public Task<List<Student>> GetAllAsync()
        {
            return db.Students.Include(x => x.Group).ToListAsync();
        }

        public Task<Student> GetAsync(int id)
        {
            return db.Students.Include(s => s.User).FirstOrDefaultAsync(s => s.Id == id);
        }

        public IEnumerable<Student> Find(Func<Student, bool> predicate)
        {
            return db.Students.Where(predicate).ToList();
        }

        public async Task CreateAsync(Student item)
        {
            await db.Students.AddAsync(item);
            await db.SaveChangesAsync();
        }

        public async Task UpdateAsync(Student item)
        {
            db.Entry(item).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var student = await db.Students.Include(s => s.User).SingleAsync(s => s.Id == id);
            if (student == null)
                throw new ArgumentException("Student not found");

            if(student.User != null)
                db.Users.Remove(student.User);

            db.Students.Remove(student);
            await db.SaveChangesAsync();
        }

        public Task<IEnumerable<Student>> GetAllByPaginationAsync(PaginationFilter pagination)
        {
            throw new NotImplementedException();
        }
    }
}
