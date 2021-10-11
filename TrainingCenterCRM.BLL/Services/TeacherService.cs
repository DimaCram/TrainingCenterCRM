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
    public class TeacherService : ITeacherService
    {
        private readonly IRepository<Teacher> repository;

        public TeacherService(IRepository<Teacher> repository)
        {
            this.repository = repository;
        }
        public async Task AddTeacherAsync(Teacher teacher)
        {
            await repository.CreateAsync(teacher);
        }

        public async Task DeleteTeacherAsync(int id)
        {
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

        public Task<IEnumerable<Teacher>> GetTeachersByPaginationAsync(PaginationFilter pagination)
        {
            return repository.GetAllByPaginationAsync(pagination);
        }
    }
}
