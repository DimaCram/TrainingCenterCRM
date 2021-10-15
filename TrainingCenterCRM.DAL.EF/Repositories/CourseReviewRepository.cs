using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public async Task CreateAsync(CourseReview item)
        {
            await _context.CourseReviews.AddAsync(item);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var courseReview = await _context.CourseReviews.FindAsync(id);
            if (courseReview == null)
                throw new ArgumentException("Course review not found");

            _context.CourseReviews.Remove(courseReview);
            await _context.SaveChangesAsync();
        }

        public IEnumerable<CourseReview> Find(Func<CourseReview, bool> predicate)
        {
            return _context.CourseReviews.Where(predicate);
        }

        public Task<List<CourseReview>> GetAllAsync()
        {
            return _context.CourseReviews.ToListAsync();
        }

        public Task<IEnumerable<CourseReview>> GetAllByPaginationAsync(PaginationFilter pagination)
        {
            throw new NotImplementedException();
        }

        public Task<CourseReview> GetAsync(int id)
        {
            return _context.CourseReviews.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task UpdateAsync(CourseReview item)
        {
            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}