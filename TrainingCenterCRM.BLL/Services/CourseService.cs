using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using TrainingCenterCRM.BLL.Interfaces;
using TrainingCenterCRM.Core.Extensions;
using TrainingCenterCRM.Core.Filters;
using TrainingCenterCRM.Core.Models;
using TrainingCenterCRM.DAL.EF.Interfaces;

namespace TrainingCenterCRM.BLL.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;

        public CourseService(ICourseRepository repository)
        {
            _courseRepository = repository;
        }
        public async Task AddCourseAsync(Course course)
        {
            if (course == null)
                throw new ArgumentException();

            await _courseRepository.Create(course);
        }

        public async Task DeleteCourseAsync(int id)
        {
            await _courseRepository.Delete(id);
        }

        public async Task EditCourseAsync(Course course)
        {
            if (course == null)
                throw new ArgumentException();

            await _courseRepository.Update(course);
        }

        public async Task<IEnumerable<Course>> Filter(CourseFilter filter)
        {
            var filteredCourses = _courseRepository.Filter(filter);

            return filteredCourses;
        }

        public Task<Course> GetCourseAsync(int id)
        {
            return _courseRepository.Get(id);
        }

        public Task<List<Course>> GetCoursesAsync()
        {
            return _courseRepository.GetAll();
        }

        public Task<IEnumerable<Course>> GetCoursesByPaginationAsync(PaginationFilter pagination)
        {
            return _courseRepository.GetAllByPagination(pagination);
        }

        public async Task<Stream> GetCsvContent()
        {
            var courses = await _courseRepository.GetAll();

            var sb = new StringBuilder();

            foreach (var course in courses)
            {
                sb.AppendLine($"{course.Title};{course.Description};{course.Price};{course.Level}");
            }

            return sb.ToString().GetMemoryStreamFromString();
        }

        public async Task<IEnumerable<Course>> Search(string search)
        {
            return await _courseRepository.Find(s => s.Title.Contains(search.NormalizeSearchString(), StringComparison.OrdinalIgnoreCase) ||
                                                s.Description.Contains(search.NormalizeSearchString(), StringComparison.OrdinalIgnoreCase));
        }
    }
}
