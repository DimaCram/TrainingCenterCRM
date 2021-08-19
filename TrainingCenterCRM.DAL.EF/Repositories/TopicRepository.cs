using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public void Create(Topic item)
        {
            db.Add(item);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var topic = db.Topics.Find(id);
            if (topic == null)
                throw new ArgumentException("Topic not found");

            db.Topics.Remove(topic);
            db.SaveChanges();
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
            db.SaveChanges();
        }
    }
}
