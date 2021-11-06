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
    public class MaterialRepository : IMaterialRepository
    {
        private readonly TrainingCenterContext db;

        public MaterialRepository(TrainingCenterContext db)
        {
            this.db = db;
        }

        public async Task Create(Material item)
        {
            await db.Materials.AddAsync(item);
            await db.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var material = await db.Materials.FindAsync(id);
            if (material == null)
                throw new ArgumentException("Course not found");

            db.Materials.Remove(material);
            await db.SaveChangesAsync();
        }

        public async Task<IEnumerable<Material>> Find(Expression<Func<Material, bool>> predicate)
        {
            return await db.Materials.Where(predicate).ToListAsync();
        }

        public Task<List<Material>> GetAll()
        {
            return db.Materials.ToListAsync();
        }

        public async Task<IEnumerable<Material>> GetAllByPagination(PaginationFilter pagination)
        {
            return await db.Materials.Skip((pagination.Offset - 1) * pagination.Limit)
                                     .Take(pagination.Limit)
                                     .ToListAsync();
        }

        public Task<Material> Get(int id)
        {
            return db.Materials.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task Update(Material item)
        {
            db.Entry(item).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }

        public async Task<IEnumerable<Material>> GetMaterialsWithFilesByGroup(int groupId)
        {
            return await db.Materials.Include(m => m.FileToMaterialAssignments)
                                     .ThenInclude(a => a.File)
                                     .Where(m => m.GroupId == groupId)
                                     .ToListAsync();
        }
    }
}
