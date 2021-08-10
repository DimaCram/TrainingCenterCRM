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
    public class CourseRepository : IRepository<Course>
    {
        private readonly TrainingCenterContext db;

        public CourseRepository(TrainingCenterContext db)
        {
            this.db = db;
        }
        public void Create(Course item)
        {
            db.Courses.Add(item);
        }

        public void Delete(int id)
        {
            var course = db.Courses.Find(id);
            if (course != null)
                db.Courses.Remove(course);
            else
                throw new ArgumentException("Course not found");
        }

        public IEnumerable<Course> Find(Func<Course, bool> predicate)
        {
            return db.Courses.Where(predicate).ToList();
        }

        public Course Get(int id)
        {
            return db.Courses.Find(id);
        }

        public List<Course> GetAll()
        {
            return db.Courses.ToList();
        }

        public void Update(Course item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
    }
}
