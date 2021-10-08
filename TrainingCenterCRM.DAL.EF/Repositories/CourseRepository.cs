using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingCenterCRM.Core.Filters;
using TrainingCenterCRM.Core.Models;
using TrainingCenterCRM.DAL.EF.Context;
using TrainingCenterCRM.DAL.EF.Interfaces;

namespace TrainingCenterCRM.DAL.EF.Repositories
{
    public class CourseRepository : IRepository<Course>
    {
        private readonly TrainingCenterContext db;

        public CourseRepository(TrainingCenterContext db)
        {
            this.db = db;
        }
        public async Task CreateAsync(Course item)
        {
            await db.Courses.AddAsync(item);
            await db.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var course = await db.Courses.FindAsync(id);
            if (course == null)
                throw new ArgumentException("Course not found");

            db.Courses.Remove(course);
            await db.SaveChangesAsync();
        }

        public IEnumerable<Course> Find(Func<Course, bool> predicate)
        {
            return db.Courses.Where(predicate);
        }

        public Task<Course> GetAsync(int id)
        {
            return db.Courses.FirstOrDefaultAsync(c => c.Id == id);
        }

        public Task<List<Course>> GetAllAsync()
        {
            return db.Courses.ToListAsync();
        }

        public async Task UpdateAsync(Course item)
        {
            db.Entry(item).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }

        public async Task<IEnumerable<Course>> GetAllByPaginationAsync(PaginationFilter pagination)
        {
            return await db.Courses.Skip((pagination.Offset - 1) * pagination.Limit)
                                   .Take(pagination.Limit)
                                   .ToListAsync();
        }
    }
}
