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
    public class TopicRepository : IRepository<Topic>
    {
        private readonly TrainingCenterContext db;
        public TopicRepository(TrainingCenterContext db)
        {
            this.db = db;
        }

        public async Task CreateAsync(Topic item)
        {
            await db.AddAsync(item);
            await db.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var topic = await db.Topics.FindAsync(id);
            if (topic == null)
                throw new ArgumentException("Topic not found");

            db.Topics.Remove(topic);
            await db.SaveChangesAsync();
        }

        public IEnumerable<Topic> Find(Func<Topic, bool> predicate)
        {
            return db.Topics.Where(predicate).ToList();
        }

        public Task<Topic> GetAsync(int id)
        {
            return db.Topics.FirstOrDefaultAsync(t => t.Id == id);
        }

        public Task<List<Topic>> GetAllAsync()
        {
            return db.Topics.Include(t => t.Courses).ToListAsync();
        }

        public async Task UpdateAsync(Topic item)
        {
            db.Entry(item).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }
    }
}
