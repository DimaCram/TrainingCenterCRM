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
    public class StudentToGroupAssignmentRepository : IRepository<StudentToGroupAssignment>
    {

        private readonly TrainingCenterContext db;

        public StudentToGroupAssignmentRepository(TrainingCenterContext db)
        {
            this.db = db;
        }
        public async Task Create(StudentToGroupAssignment item)
        {
            await db.StudentToGroupAssignments.AddAsync(item);
            await db.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var studentToGroupAssignment = await db.StudentToGroupAssignments.FindAsync(id);
            if (studentToGroupAssignment == null)
                throw new ArgumentException("Student to group assignment not found");

            db.StudentToGroupAssignments.Remove(studentToGroupAssignment);
            await db.SaveChangesAsync();
        }

        public async Task<IEnumerable<StudentToGroupAssignment>> Find(Expression<Func<StudentToGroupAssignment, bool>> predicate)
        {
            return await db.StudentToGroupAssignments.Where(predicate).ToListAsync();
        }

        public Task<StudentToGroupAssignment> Get(int id)
        {
            return db.StudentToGroupAssignments.FirstOrDefaultAsync(a => a.StudentToGroupAssignmentId == id);
        }

        public Task<List<StudentToGroupAssignment>> GetAll()
        {
            return db.StudentToGroupAssignments.ToListAsync();
        }

        public async Task Update(StudentToGroupAssignment item)
        {
            db.Entry(item).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }

    }
}
