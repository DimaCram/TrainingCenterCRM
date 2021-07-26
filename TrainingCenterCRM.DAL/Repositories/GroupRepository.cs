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
    public class GroupRepository : IRepository<Group>
    {
        private readonly TrainingCenterContext db;
        public GroupRepository(TrainingCenterContext db)
        {
            this.db = db;
        }
        public IEnumerable<Group> GetAll()
        {
            return db.Groups;
        }

        public Group Get(int id)
        {
            return db.Groups.Find(id);
        }

        public IEnumerable<Group> Find(Func<Group, bool> predicate)
        {
            return db.Groups.Where(predicate).ToList();
        }

        public void Create(Group item)
        {
            db.Groups.Add(item);
        }

        public void Update(Group item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            var group = db.Groups.Find(id);
            if (group != null)
                db.Groups.Remove(group);
            else
                throw new ArgumentException("Group not found");
        }
    }
}
