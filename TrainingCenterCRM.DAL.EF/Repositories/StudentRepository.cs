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
    public class StudentRepository : IRepository<Student>
    {
        public TrainingCenterContext db;

        public StudentRepository(TrainingCenterContext db)
        {
            this.db = db;
        }
        public List<Student> GetAll()
        {
            return db.Students.Include(x => x.Group).ToList();
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
            db.SaveChanges();
        }

        public void Update(Student item)
        {
            db.Entry(item).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var student = db.Students.Find(id);
            if (student == null)
                throw new ArgumentException("Student not found");

            db.Students.Remove(student);
            db.SaveChanges();
        }
    }
}
