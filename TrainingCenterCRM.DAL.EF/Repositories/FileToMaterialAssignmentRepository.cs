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
    public class FileToMaterialAssignmentRepository : IRepository<FileToMaterialAssignment>
    {
        private readonly TrainingCenterContext db;

        public FileToMaterialAssignmentRepository(TrainingCenterContext db)
        {
            this.db = db;
        }
        public async Task CreateAsync(FileToMaterialAssignment item)
        {
            await db.FileToMaterialAssignments.AddAsync(item);
            await db.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var assignment = await db.FileToMaterialAssignments.FindAsync(id);
            if (assignment == null)
                throw new ArgumentException("File to material assignments not found");

            db.FileToMaterialAssignments.Remove(assignment);
            await db.SaveChangesAsync();
        }

        public IEnumerable<FileToMaterialAssignment> Find(Func<FileToMaterialAssignment, bool> predicate)
        {
            return db.FileToMaterialAssignments.Include(a => a.File)
                                               .Include(a => a.Material)
                                               .AsNoTracking()
                                               .Where(predicate);
        }

        public Task<FileToMaterialAssignment> GetAsync(int id)
        {
            return db.FileToMaterialAssignments.FirstOrDefaultAsync(c => c.Id == id);
        }

        public Task<List<FileToMaterialAssignment>> GetAllAsync()
        {
            return db.FileToMaterialAssignments.ToListAsync();
        }

        public async Task UpdateAsync(FileToMaterialAssignment item)
        {
            db.Entry(item).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }
    }
}
