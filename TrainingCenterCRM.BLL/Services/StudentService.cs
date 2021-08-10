using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TrainingCenterCRM.BLL.Interfaces;
using TrainingCenterCRM.BLL.Models;
using TrainingCenterCRM.DAL.Interfaces;

namespace TrainingCenterCRM.BLL.Services
{
    public class StudentService : IStudentService
    {
        private readonly IRepository<Student> repository;

        public StudentService(IRepository<Student> repository)
        {
            this.repository = repository;
        }
        public void AddStudent(Student student)
        {
            if (student == null)
                throw new ArgumentException();

            repository.Create(student);
        }
        public void EditStudent(Student student)
        {
            if (student == null)
                throw new ArgumentException();

            repository.Update(student);
        }
        public void DeleteStudent(int id)
        {
            repository.Delete(id);
        }
        public Student GetStudent(int id)
        {
            return repository.Get(id);
        }
        public List<Student> GetStudents()
        {
            return repository.GetAll();
        }
    }
}
