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
    public class StudentRepository : IStudentRepository
    {
        public TrainingCenterContext db;

        public StudentRepository(TrainingCenterContext db)
        {
            this.db = db;
        }
        public Task<List<Student>> GetAll()
        {
            return db.Students.Include(x => x.Group).ToListAsync();
        }

        public Task<Student> Get(int id)
        {
            return db.Students.Include(s => s.User).FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task<IEnumerable<Student>> Find(Expression<Func<Student, bool>> predicate)
        {
            return await db.Students.Where(predicate).ToListAsync();
        }

        public async Task Create(Student item)
        {
            await db.Students.AddAsync(item);
            await db.SaveChangesAsync();
        }

        public async Task Update(Student item)
        {
            db.Entry(item).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var student = await db.Students.Include(s => s.User).SingleAsync(s => s.Id == id);
            if (student == null)
                throw new ArgumentException("Student not found");

            if(student.User != null)
                db.Users.Remove(student.User);

            db.Students.Remove(student);
            await db.SaveChangesAsync();
        }

        public async Task<IEnumerable<Student>> GetAllByPagination(PaginationFilter pagination)
        {
            return await db.Students.Skip((pagination.Offset - 1) * pagination.Limit)
                                    .Take(pagination.Limit)
                                    .ToListAsync();
        }

        public async Task<Student> GetStudentWithUserById(int id)
        {
            var studentWithUser = await db.Students.Include(s => s.User).SingleOrDefaultAsync(s => s.Id == id);
            return studentWithUser;
        }
    }
}
