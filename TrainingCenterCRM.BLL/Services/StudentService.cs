using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingCenterCRM.BLL.Interfaces;
using TrainingCenterCRM.Core.Filters;
using TrainingCenterCRM.Core.Models;
using TrainingCenterCRM.DAL.EF.Interfaces;

namespace TrainingCenterCRM.BLL.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository repository;

        public StudentService(IStudentRepository repository)
        {
            this.repository = repository;
        }
        public async Task AddStudentAsync(Student student)
        {
            if (student == null)
                throw new ArgumentException();

            await repository.Create(student);
        }
        public async Task EditStudentAsync(Student student)
        {
            if (student == null)
                throw new ArgumentException();

            await repository.Update(student);
        }
        public async Task DeleteStudentAsync(int id)
        {
            await repository.Delete(id);
        }
        public Task<Student> GetStudentAsync(int id)
        {
            return repository.Get(id);
        }
        public Task<List<Student>> GetStudentsAsync()
        {
            return repository.GetAll();
        }

        public async Task<Student> GetStudentWithGroupAsync(int id)
        {
            var students = await repository.GetAll();
            return students.FirstOrDefault(s => s.Id == id);
        }

        public async Task<IEnumerable<Student>> GetStudentsByGroupAsync(int groupId)
        {
            return await repository.Find(s => s.GroupId == groupId);
        }

        public Task<IEnumerable<Student>> GetStudentsByPaginationAsync(PaginationFilter filter)
        {
            return repository.GetAllByPagination(filter);
        }
    }
}
