using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TrainingCenterCRM.BLL.Interfaces;
using TrainingCenterCRM.BLL.Models;
using TrainingCenterCRM.DAL.Interfaces;

namespace TrainingCenterCRM.BLL.Services
{
    public class TeacherService : ITeacherService
    {
        private readonly IRepository<Teacher> repository;

        public TeacherService(IRepository<Teacher> repository)
        {
            this.repository = repository;
        }
        public void AddTeacher(Teacher teacher)
        {
            if (teacher == null)
                throw new ArgumentException();

            repository.Create(teacher);
        }

        public void DeleteTeacher(int id)
        {
            repository.Delete(id);
        }

        public void EditTeacher(Teacher teacher)
        {
            if (teacher == null)
                throw new ArgumentException();

            repository.Update(teacher);
        }

        public Teacher GetTeacher(int id)
        {
            return repository.Get(id);
        }

        public List<Teacher> GetTeachers()
        {
            return repository.GetAll();
        }
    }
}
