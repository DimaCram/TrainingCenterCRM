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
    public class StudentToGroupAssignmentRepository : IRepository<StudentToGroupAssignment>
    {

        private readonly TrainingCenterContext db;

        public StudentToGroupAssignmentRepository(TrainingCenterContext db)
        {
            this.db = db;
        }
        public async Task CreateAsync(StudentToGroupAssignment item)
        {
            await db.StudentToGroupAssignments.AddAsync(item);
            await db.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var studentToGroupAssignment = await db.StudentToGroupAssignments.FindAsync(id);
            if (studentToGroupAssignment == null)
                throw new ArgumentException("Student to group assignment not found");

            db.StudentToGroupAssignments.Remove(studentToGroupAssignment);
            await db.SaveChangesAsync();
        }

        public IEnumerable<StudentToGroupAssignment> Find(Func<StudentToGroupAssignment, bool> predicate)
        {
            return db.StudentToGroupAssignments.Where(predicate).ToList();
        }

        public Task<StudentToGroupAssignment> GetAsync(int id)
        {
            return db.StudentToGroupAssignments.FirstOrDefaultAsync(a => a.StudentToGroupAssignmentId == id);
        }

        public Task<List<StudentToGroupAssignment>> GetAllAsync()
        {
            return db.StudentToGroupAssignments.ToListAsync();
        }

        public async Task UpdateAsync(StudentToGroupAssignment item)
        {
            db.Entry(item).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }
    }
}
