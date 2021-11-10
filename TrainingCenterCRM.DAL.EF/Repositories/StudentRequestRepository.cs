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
    public class StudentRequestRepository : IRequestRepository
    {
        private readonly TrainingCenterContext db;

        public StudentRequestRepository(TrainingCenterContext db)
        {
            this.db = db;
        }

        public async Task Create(StudentRequest item)
        {
            await db.StudentRequests.AddAsync(item);
            await db.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var request = await db.StudentRequests.FindAsync(id);
            if (request == null)
                throw new ArgumentException("Student request not found");
            db.StudentRequests.Remove(request);
            await db.SaveChangesAsync();
        }

        public async Task<IEnumerable<StudentRequest>> Find(Expression<Func<StudentRequest, bool>> predicate)
        {
            return await db.StudentRequests.Where(predicate)
                                           .Include(s => s.Student)
                                           .Include(c => c.Course)
                                           .ToListAsync();
        }

        public Task<StudentRequest> Get(int id)
        {
            return db.StudentRequests.FirstOrDefaultAsync(sr => sr.Id == id);
        }

        public Task<List<StudentRequest>> GetAll()
        {
            return db.StudentRequests.Include(s => s.Student)
                                     .Include(c => c.Course)
                                     .ToListAsync();
        }

        public async Task Update(StudentRequest item)
        {
            db.Entry(item).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }

        public async Task UpdateRange(IEnumerable<StudentRequest> requests)
        {
            db.UpdateRange(requests);
            await db.SaveChangesAsync();
        }

    }
}
