using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrainingCenterCRM.DAL.Context;
using TrainingCenterCRM.DAL.Enttities;
using TrainingCenterCRM.DAL.Interfaces;

namespace TrainingCenterCRM.DAL.Repositories
{
    public class TopicRepository : IRepository<Topic>
    {
        private readonly TrainingCenterContext db;
        public TopicRepository(TrainingCenterContext db)
        {
            this.db = db;
        }

        public void Create(Topic item)
        {
            db.Add(item);
        }

        public void Delete(int id)
        {
            var topic = db.Topics.Find(id);
            if (topic != null)
                db.Topics.Remove(topic);
            else
                throw new ArgumentException("Topic not found");
        }

        public IEnumerable<Topic> Find(Func<Topic, bool> predicate)
        {
            return db.Topics.Where(predicate).ToList();
        }

        public Topic Get(int id)
        {
            return db.Topics.Find(id);
        }

        public List<Topic> GetAll()
        {
            return db.Topics.ToList();
        }

        public void Update(Topic item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
    }
}
