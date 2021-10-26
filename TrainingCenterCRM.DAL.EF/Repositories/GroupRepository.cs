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
    public class GroupRepository : IGroupRepository
    {
        private readonly TrainingCenterContext db;
        public GroupRepository(TrainingCenterContext db)
        {
            this.db = db;
        }

        public Task<Group> Get(int id)
        {
            return db.Groups.Include(s => s.Students).FirstOrDefaultAsync(g => g.Id == id);
        }

        public async Task<IEnumerable<Group>> Find(Expression<Func<Group, bool>> predicate)
        {
            return await db.Groups.Include(g => g.Course).Where(predicate).ToListAsync();
        }

        public async Task Create(Group item)
        {
            await db.Groups.AddAsync(item);
            await db.SaveChangesAsync();
        }

        public async Task Update(Group item)
        {
            db.Entry(item).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var group = await db.Groups.FindAsync(id);
            if (group == null)
                throw new ArgumentException("Group not found");

            db.Groups.Remove(group);
            await db.SaveChangesAsync();
        }

        public Task<List<Group>> GetAll()
        {
            return db.Groups.Include(g => g.Teacher)
                            .ToListAsync();
        }

        public async Task<IEnumerable<Group>> GetAllByPagination(PaginationFilter pagination)
        {
            return await db.Groups.Skip((pagination.Offset - 1) * pagination.Limit)
                                  .Take(pagination.Limit)
                                  .ToListAsync();
        }
    }
}
