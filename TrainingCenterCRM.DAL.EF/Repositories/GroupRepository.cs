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
    public class GroupRepository : IRepository<Group>
    {
        private readonly TrainingCenterContext db;
        public GroupRepository(TrainingCenterContext db)
        {
            this.db = db;
        }
        public List<Group> GetAll()
        {
            return db.Groups.Include(g => g.Teacher).ToList();
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
            db.SaveChanges();
        }

        public void Update(Group item)
        {
            db.Entry(item).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var group = db.Groups.Find(id);
            if (group == null)
                throw new ArgumentException("Group not found");

            db.Groups.Remove(group);
            db.SaveChanges();
        }
    }
}
