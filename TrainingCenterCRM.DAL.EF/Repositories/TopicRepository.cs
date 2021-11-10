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
    public class TopicRepository : ITopicRepository
    {
        private readonly TrainingCenterContext db;
        public TopicRepository(TrainingCenterContext db)
        {
            this.db = db;
        }

        public async Task Create(Topic item)
        {
            await db.AddAsync(item);
            await db.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var topic = await db.Topics.FindAsync(id);
            if (topic == null)
                throw new ArgumentException("Topic not found");

            db.Topics.Remove(topic);
            await db.SaveChangesAsync();
        }

        public async Task<IEnumerable<Topic>> Find(Expression<Func<Topic, bool>> predicate)
        {
            return await db.Topics.Where(predicate).ToListAsync();
        }

        public Task<Topic> Get(int id)
        {
            return db.Topics.FirstOrDefaultAsync(t => t.Id == id);
        }

        public Task<List<Topic>> GetAll()
        {
            return db.Topics.Include(t => t.Courses).ToListAsync();
        }

        public async Task Update(Topic item)
        {
            db.Entry(item).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }

        public async Task<IEnumerable<Topic>> GetAllByPagination(PaginationFilter pagination)
        {
            return await db.Topics.Skip((pagination.Offset - 1) * pagination.Limit)
                                  .Take(pagination.Limit)
                                  .ToListAsync();
        }
    }
}
