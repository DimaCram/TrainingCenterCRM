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
    public class FileRepository : IFileRepository
    {
        private readonly TrainingCenterContext db;

        public FileRepository(TrainingCenterContext db)
        {
            this.db = db;
        }

        public async Task Create(File item)
        {
            await db.Files.AddAsync(item);
            await db.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var file = await db.Files.FindAsync(id);
            if (file == null)
                throw new ArgumentException("File not found");

            db.Files.Remove(file);
            await db.SaveChangesAsync();
        }

        public async Task<IEnumerable<File>> Find(Expression<Func<File, bool>> predicate)
        {
            return await db.Files.Where(predicate).ToListAsync();
        }

        public Task<List<File>> GetAll()
        {
            return db.Files.ToListAsync();
        }

        public async Task<IEnumerable<File>> GetAllByPagination(PaginationFilter pagination)
        {
            return await db.Files.Skip((pagination.Offset - 1) * pagination.Limit)
                                 .Take(pagination.Limit)
                                 .ToListAsync();
        }

        public Task<File> Get(int id)
        {
            return db.Files.FirstOrDefaultAsync(f => f.Id == id);
        }

        public async Task Update(File item)
        {
            db.Entry(item).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }
    }
}
