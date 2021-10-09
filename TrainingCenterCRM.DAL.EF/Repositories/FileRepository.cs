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
    public class FileRepository : IRepository<File>
    {
        private readonly TrainingCenterContext db;

        public FileRepository(TrainingCenterContext db)
        {
            this.db = db;
        }

        public async Task CreateAsync(File item)
        {
            await db.Files.AddAsync(item);
            await db.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var file = await db.Files.FindAsync(id);
            if (file == null)
                throw new ArgumentException("File not found");

            db.Files.Remove(file);
            await db.SaveChangesAsync();
        }

        public IEnumerable<File> Find(Func<File, bool> predicate)
        {
            return db.Files.Where(predicate);
        }

        public Task<List<File>> GetAllAsync()
        {
            return db.Files.ToListAsync();
        }

        public async Task<IEnumerable<File>> GetAllByPaginationAsync(PaginationFilter pagination)
        {
            return await db.Files.Skip((pagination.Offset - 1) * pagination.Limit)
                                 .Take(pagination.Limit)
                                 .ToListAsync();
        }

        public Task<File> GetAsync(int id)
        {
            return db.Files.FirstOrDefaultAsync(f => f.Id == id);
        }

        public async Task UpdateAsync(File item)
        {
            db.Entry(item).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }
    }
}
