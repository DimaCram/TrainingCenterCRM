using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TrainingCenterCRM.BLL.Interfaces;
using TrainingCenterCRM.Core.Filters;
using TrainingCenterCRM.Core.Models;
using TrainingCenterCRM.DAL.EF.Interfaces;

namespace TrainingCenterCRM.BLL.Services
{
    public class CourseService : ICourseService
    {
        private readonly IRepository<Course> _courseRepository;

        public CourseService(IRepository<Course> repository)
        {
            _courseRepository = repository;
        }
        public async Task AddCourseAsync(Course course)
        {
            if (course == null)
                throw new ArgumentException();

            await _courseRepository.CreateAsync(course);
        }

        public async Task DeleteCourseAsync(int id)
        {
            await _courseRepository.DeleteAsync(id);
        }

        public async Task EditCourseAsync(Course course)
        {
            if (course == null)
                throw new ArgumentException();

            await _courseRepository.UpdateAsync(course);
        }

        public Task<Course> GetCourseAsync(int id)
        {
            return _courseRepository.GetAsync(id);
        }

        public Task<List<Course>> GetCoursesAsync()
        {
            return _courseRepository.GetAllAsync();
        }

        public Task<IEnumerable<Course>> GetCoursesByPaginationAsync(PaginationFilter pagination)
        {
            return _courseRepository.GetAllByPaginationAsync(pagination);
        }
    }
}
