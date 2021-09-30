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
    public class MaterialRepository : IRepository<Material>
    {
        private readonly TrainingCenterContext db;

        public MaterialRepository(TrainingCenterContext db)
        {
            this.db = db;
        }

        public async Task CreateAsync(Material item)
        {
            await db.Materials.AddAsync(item);
            await db.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var material = await db.Materials.FindAsync(id);
            if (material == null)
                throw new ArgumentException("Course not found");

            db.Materials.Remove(material);
            await db.SaveChangesAsync();
        }

        public IEnumerable<Material> Find(Func<Material, bool> predicate)
        {
            return db.Materials.Where(predicate);
        }

        public Task<List<Material>> GetAllAsync()
        {
            //return db.Materials.Include(m => m.Files).ToListAsync();
            return null;
        }

        public Task<Material> GetAsync(int id)
        {
            //return db.Materials.Include(m => m.Files).FirstOrDefaultAsync(c => c.Id == id);
            return null;
        }

        public async Task UpdateAsync(Material item)
        {
            db.Entry(item).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }
    }
}
