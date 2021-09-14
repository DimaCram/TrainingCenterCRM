using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TrainingCenterCRM.BLL.Interfaces;
using TrainingCenterCRM.BLL.Models;
using TrainingCenterCRM.DAL.Interfaces;

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
        public async Task AddCourseAsync(Course course)
        {
            if (course == null)
                throw new ArgumentException();
            
            await repository.CreateAsync(course);
        }

        public async Task DeleteCourseAsync(int id)
        {
            var course = await repository.GetAsync(id);

            localFileService.DeleteFile(course.PathToIcon);
            await repository.DeleteAsync(id);
        }

        public async Task EditCourseAsync(Course course)
        {
            if (course == null)
                throw new ArgumentException();

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
    }
}
