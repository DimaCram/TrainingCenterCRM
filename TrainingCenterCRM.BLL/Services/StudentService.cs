using AutoMapper;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingCenterCRM.BLL.Interfaces;
using TrainingCenterCRM.BLL.Models;
using TrainingCenterCRM.DAL.Interfaces;

namespace TrainingCenterCRM.BLL.Services
{
    public class StudentService : IStudentService
    {
        private readonly IRepository<Student> repository;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public StudentService(IRepository<Student> repository,
                              UserManager<User> userManager,
                              RoleManager<IdentityRole> roleManager)
        {
            this.repository = repository;
            _userManager = userManager;
            _roleManager = roleManager;
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
