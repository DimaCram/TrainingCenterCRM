using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TrainingCenterCRM.Core.Filters;
using TrainingCenterCRM.Core.Models;
using TrainingCenterCRM.DAL.EF.Context;
using TrainingCenterCRM.DAL.EF.Interfaces;

namespace TrainingCenterCRM.DAL.EF.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly TrainingCenterContext db;

        public CourseRepository(TrainingCenterContext db)
        {
            this.db = db;
        }
        public async Task Create(Course item)
        {
            await db.Courses.AddAsync(item);
            await db.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var course = await db.Courses.FindAsync(id);
            if (course == null)
                throw new ArgumentException("Course not found");

            db.Courses.Remove(course);
            await db.SaveChangesAsync();
        }

        public async Task<IEnumerable<Course>> Find(Expression<Func<Course, bool>> predicate)
        {
            return await db.Courses.Where(predicate).ToListAsync();
        }

        public Task<Course> Get(int id)
        {
            return db.Courses.FirstOrDefaultAsync(c => c.Id == id);
        }

        public Task<List<Course>> GetAll()
        {
            return db.Courses.ToListAsync();
        }

        public async Task Update(Course item)
        {
            db.Entry(item).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }

        public async Task<IEnumerable<Course>> GetAllByPagination(PaginationFilter pagination)
        {
            return await db.Courses.Skip((pagination.Offset - 1) * pagination.Limit)
                                   .Take(pagination.Limit)
                                   .ToListAsync();
        }

        public IEnumerable<Course> Filter(CourseFilter filter)
        {
            var filteredCourses = db.Courses.AsQueryable();

            if (!string.IsNullOrWhiteSpace(filter.Title))
                filteredCourses = filteredCourses.Where(c =>
                c.Title.Contains(filter.Title));

            if (!string.IsNullOrWhiteSpace(filter.Description))
                filteredCourses = filteredCourses.Where(c =>
                c.Description.Contains(filter.Description));

            if (filter.Level.HasValue)
                filteredCourses = filteredCourses.Where(c => c.Level == filter.Level.Value);

            if (filter.PriceFrom.HasValue)
                filteredCourses = filteredCourses.Where(c => c.Price >= filter.PriceFrom.Value);

            if (filter.PriceTo.HasValue)
                filteredCourses = filteredCourses.Where(c => c.Price <= filter.PriceTo.Value);

            return filteredCourses.ToList();
        }
    }
}
