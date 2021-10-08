using Microsoft.AspNetCore.Http;
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
        private readonly IRepository<Course> repository;
        private readonly ILocalFileService localFileService;

        public CourseService(IRepository<Course> repository,
                             ILocalFileService localFileService)
        {
            this.repository = repository;

            this.localFileService = localFileService;
        }
        public async Task AddCourseAsync(Course course, IFormFile file)
        {
            if (course == null)
                throw new ArgumentException();

            if (file != null)
            {
                string pathToImg = @$"\assets\files\courses\{file.FileName}";

                await localFileService.AddFile(file, pathToImg);
                course.PathToIcon = pathToImg;
            }

            await repository.CreateAsync(course);
        }

        public async Task DeleteCourseAsync(int id)
        {
            var course = await repository.GetAsync(id);

            localFileService.DeleteFile(course.PathToIcon);
            await repository.DeleteAsync(id);
        }

        public async Task EditCourseAsync(Course course, IFormFile file)
        {
            if (course == null)
                throw new ArgumentException();

            if (file != null)
            {
                string pathToImg = @$"\assets\files\courses\{file.FileName}";

                await localFileService.AddFile(file, pathToImg);
                course.PathToIcon = pathToImg;
            }

            await repository.UpdateAsync(course);
        }

        public Task<Course> GetCourseAsync(int id)
        {
            return repository.GetAsync(id);
        }

        public Task<List<Course>> GetCoursesAsync()
        {
            return repository.GetAllAsync();
        }

        public Task<IEnumerable<Course>> GetCoursesByPaginationAsync(PaginationFilter pagination)
        {
            return repository.GetAllByPaginationAsync(pagination);
        }
    }
}
