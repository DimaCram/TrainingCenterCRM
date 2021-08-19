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
    public class TeacherRepository : IRepository<Teacher>
    {
        private readonly TrainingCenterContext db;

        public TeacherRepository(TrainingCenterContext db)
        {
            this.db = db;
        }
        public void Create(Teacher item)
        {
            db.Add(item);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var teacher = db.Teachers.Find(id);
            if (teacher == null)
                throw new ArgumentException("Teacher not found");

            db.Teachers.Remove(teacher);
            db.SaveChanges();
        }

        public IEnumerable<Teacher> Find(Func<Teacher, bool> predicate)
        {
            return db.Teachers.Where(predicate).ToList();
        }

        public Teacher Get(int id)
        {
            return db.Teachers.Find(id);
        }

        public List<Teacher> GetAll()
        {
            return db.Teachers.ToList();
        }

        public void Update(Teacher item)
        {
            db.Entry(item).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
