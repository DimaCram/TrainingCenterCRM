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
    public class TeacherService : ITeacherService
    {
        private readonly IRepository<Teacher> repository;
        private readonly ILocalFileService localFileService;

        public TeacherService(IRepository<Teacher> repository, ILocalFileService localFileService)
        {
            this.repository = repository;

            this.localFileService = localFileService;
        }
        public async Task AddTeacherAsync(Teacher teacher)
        {
            if (teacher == null)
                throw new ArgumentException();

            await repository.CreateAsync(teacher);
        }

        public async Task DeleteTeacherAsync(int id)
        {

            var teacher = await repository.GetAsync(id);
            localFileService.DeleteFile(teacher.PathToIcon);

            await repository.DeleteAsync(id);
        }

        public async Task EditTeacherAsync(Teacher teacher)
        {
            if (teacher == null)
                throw new ArgumentException();

            await repository.UpdateAsync(teacher);
        }

        public Task<Teacher> GetTeacherAsync(int id)
        {
            return repository.GetAsync(id);
        }

        public Task<List<Teacher>> GetTeachersAsync()
        {
            return repository.GetAllAsync();
        }
    }
}
