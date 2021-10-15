using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TrainingCenterCRM.BLL.Interfaces;
using TrainingCenterCRM.Core.Models;
using TrainingCenterCRM.DAL.EF.Repositories;

namespace TrainingCenterCRM.BLL.Services
{
    public class CourseReviewService : ICourseReviewService
    {
        private readonly CourseReviewRepository _courseReviewRepository;
        public CourseReviewService(CourseReviewRepository courseReviewRepository)
        {
            _courseReviewRepository = courseReviewRepository;
        }
        public async Task AddCourseReviewAsync(CourseReview courseDTO)
        {
            if (courseDTO == null)
                throw new ArgumentException();

            await _courseReviewRepository.CreateAsync(courseDTO);
        }

        public async Task DeleteCourseReviewAsync(int id)
        {
            await _courseReviewRepository.DeleteAsync(id);
        }

        public async Task EditCourseReviewAsync(CourseReview courseDTO)
        {
            if (courseDTO == null)
                throw new ArgumentException();

            await _courseReviewRepository.UpdateAsync(courseDTO);
        }

        public Task<CourseReview> GetCourseReviewAsync(int id)
        {
            return _courseReviewRepository.GetAsync(id);
        }

        public Task<List<CourseReview>> GetCourseReviewsAsync()
        {
            return _courseReviewRepository.GetAllAsync();
        }
    }
}
