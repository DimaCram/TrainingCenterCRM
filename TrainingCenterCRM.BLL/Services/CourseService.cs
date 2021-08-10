using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TrainingCenterCRM.BLL.Interfaces;
using TrainingCenterCRM.BLL.Models;
using TrainingCenterCRM.DAL.Interfaces;

namespace TrainingCenterCRM.BLL.Services
{
    public class CourseService : ICourseService
    {
        private readonly IRepository<Course> repository;

        public CourseService(IRepository<Course> repository)
        {
            this.repository = repository;
        }
        public void AddCourse(Course course)
        {
            if (course == null)
                throw new ArgumentException();
            
            repository.Create(course);
        }

        public void DeleteCourse(int id)
        {
            repository.Delete(id);
        }

        public void EditCourse(Course course)
        {
            if (course == null)
                throw new ArgumentException();

            repository.Update(course);
        }

        public Course GetCourse(int id)
        {
            return repository.Get(id);
        }

        public List<Course> GetCourses()
        {
            return repository.GetAll();
        }
    }
}
