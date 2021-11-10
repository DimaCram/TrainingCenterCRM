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
        private readonly ITeacherRepository repository;

        public TeacherService(ITeacherRepository repository)
        {
            this.repository = repository;
        }
        public async Task AddTeacherAsync(Teacher teacher)
        {
            await repository.Create(teacher);
        }

        public async Task DeleteTeacherAsync(int id)
        {
            await repository.Delete(id);
        }

        public async Task EditTeacherAsync(Teacher teacher)
        {
            if (teacher == null)
                throw new ArgumentException();

            await repository.Update(teacher);
        }

        public Task<Teacher> GetTeacherAsync(int id)
        {
            return repository.Get(id);
        }

        public Task<List<Teacher>> GetTeachersAsync()
        {
            return repository.GetAll();
        }

        public Task<IEnumerable<Teacher>> GetTeachersByPaginationAsync(PaginationFilter pagination)
        {
            return repository.GetAllByPagination(pagination);
        }
    }
}
