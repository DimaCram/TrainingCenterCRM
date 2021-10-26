using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TrainingCenterCRM.Core.Filters;
using TrainingCenterCRM.Core.Models;
using TrainingCenterCRM.DAL.EF.Context;
using TrainingCenterCRM.DAL.EF.Interfaces;

namespace TrainingCenterCRM.DAL.EF.Repositories
{
    public class CourseReviewRepository : ICourseReviewRepository
    {
        private readonly TrainingCenterContext _context;
        public CourseReviewRepository(TrainingCenterContext context)
        {
            _context = context;
        }
        public async Task Create(CourseReview item)
        {
            await _context.CourseReviews.AddAsync(item);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var courseReview = await _context.CourseReviews.FindAsync(id);
            if (courseReview == null)
                throw new ArgumentException("Course review not found");

            _context.CourseReviews.Remove(courseReview);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<CourseReview>> Find(Expression<Func<CourseReview, bool>> predicate)
        {
            return await _context.CourseReviews.Where(predicate).ToListAsync();
        }

        public Task<List<CourseReview>> GetAll()
        {
            return _context.CourseReviews.ToListAsync();
        }

        public Task<CourseReview> Get(int id)
        {
            return _context.CourseReviews.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task Update(CourseReview item)
        {
            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}