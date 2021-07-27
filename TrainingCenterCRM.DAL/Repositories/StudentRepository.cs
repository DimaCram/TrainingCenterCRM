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
    public class StudentRepository : IRepository<Student>
    {
        public TrainingCenterContext db;

        public StudentRepository(TrainingCenterContext db)
        {
            this.db = db;
        }
        public IEnumerable<Student> GetAll()
        {
            return db.Students.Include(p => p.Group).ToList();
        }

        public Student Get(int id)
        {
            return db.Students.Find(id);
        }

        public IEnumerable<Student> Find(Func<Student, bool> predicate)
        {
            return db.Students.Where(predicate).ToList();
        }

        public void Create(Student item)
        {
            db.Students.Add(item);
        }

        public void Update(Student item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            var student = db.Students.Find(id);
            if (student != null)
                db.Students.Remove(student);
            else
                throw new ArgumentException("Student not found");
        }
    }
}
