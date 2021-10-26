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
    public class FileToMaterialAssignmentRepository : IFileToMaterialAssignmentRepository
    {
        private readonly TrainingCenterContext db;

        public FileToMaterialAssignmentRepository(TrainingCenterContext db)
        {
            this.db = db;
        }
        public async Task Create(FileToMaterialAssignment item)
        {
            await db.FileToMaterialAssignments.AddAsync(item);
            await db.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var assignment = await db.FileToMaterialAssignments.FindAsync(id);
            if (assignment == null)
                throw new ArgumentException("File to material assignments not found");

            db.FileToMaterialAssignments.Remove(assignment);
            await db.SaveChangesAsync();
        }
        public async Task DeleteRange(IEnumerable<int> ids)
        {
            if (ids == null)
                throw new ArgumentNullException("File to material assignments not found");

            var assignments = db.FileToMaterialAssignments.Where(a => ids.Contains(a.Id));

            db.FileToMaterialAssignments.RemoveRange(assignments);
            await db.SaveChangesAsync();
        }

        public async Task<IEnumerable<FileToMaterialAssignment>> Find(Expression<Func<FileToMaterialAssignment, bool>> predicate)
        {
            return await db.FileToMaterialAssignments.Include(a => a.File)
                                                     .Include(a => a.Material)
                                                     .AsNoTracking()
                                                     .Where(predicate)
                                                     .ToListAsync();
        }

        public Task<FileToMaterialAssignment> Get(int id)
        {
            return db.FileToMaterialAssignments.FirstOrDefaultAsync(c => c.Id == id);
        }

        public Task<List<FileToMaterialAssignment>> GetAll()
        {
            return db.FileToMaterialAssignments.ToListAsync();
        }

        public async Task Update(FileToMaterialAssignment item)
        {
            db.Entry(item).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }

    }
}
