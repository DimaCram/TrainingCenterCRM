using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingCenterCRM.Core.Models;
using TrainingCenterCRM.DAL.EF.Context;
using TrainingCenterCRM.DAL.EF.Interfaces;

namespace TrainingCenterCRM.DAL.EF.Repositories
{
    public class GroupRepository : IRepository<Group>
    {
        private readonly TrainingCenterContext db;
        public GroupRepository(TrainingCenterContext db)
        {
            this.db = db;
        }

        public Task<Group> GetAsync(int id)
        {
            return db.Groups.Include(s => s.Students).FirstOrDefaultAsync(g => g.Id == id);
        }

        public IEnumerable<Group> Find(Func<Group, bool> predicate)
        {
            return db.Groups.Include(g => g.Course).Where(predicate).ToList();
        }

        public async Task CreateAsync(Group item)
        {
            await db.Groups.AddAsync(item);
            await db.SaveChangesAsync();
        }

        public async Task UpdateAsync(Group item)
        {
            db.Entry(item).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var group = await db.Groups.FindAsync(id);
            if (group == null)
                throw new ArgumentException("Group not found");

            db.Groups.Remove(group);
            await db.SaveChangesAsync();
        }

        public Task<List<Group>> GetAllAsync()
        {
            return db.Groups.Include(g => g.Teacher)
                            .ToListAsync();
        }
    }
}
