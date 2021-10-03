using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingCenterCRM.BLL.Interfaces;
using TrainingCenterCRM.Core.Models;
using TrainingCenterCRM.DAL.EF.Interfaces;

namespace TrainingCenterCRM.BLL.Services
{
    public class StudentService : IStudentService
    {
        private readonly IRepository<Student> repository;

        public StudentService(IRepository<Student> repository)
        {
            this.repository = repository;
        }
        public async Task AddStudentAsync(Student student)
        {
            if (student == null)
                throw new ArgumentException();

            await repository.CreateAsync(student);
        }
        public async Task EditStudentAsync(Student student)
        {
            if (student == null)
                throw new ArgumentException();

            await repository.UpdateAsync(student);
        }
        public async Task DeleteStudentAsync(int id)
        {
            await repository.DeleteAsync(id);
        }
        public Task<Student> GetStudentAsync(int id)
        {
            return repository.GetAsync(id);
        }
        public Task<List<Student>> GetStudentsAsync()
        {
            return repository.GetAllAsync();
        }

        public async Task<Student> GetStudentWithGroupAsync(int id)
        {
            var students = await repository.GetAllAsync();
            return students.FirstOrDefault(s => s.Id == id);
        }
    }
}
