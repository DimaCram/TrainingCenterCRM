using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TrainingCenterCRM.BLL.DTO;
using TrainingCenterCRM.BLL.Interfaces;
using TrainingCenterCRM.DAL.Enttities;
using TrainingCenterCRM.DAL.Interfaces;

namespace TrainingCenterCRM.BLL.Services
{
    public class CourseService : ICourseService
    {
        private readonly IUnitOfWork db;
        private readonly IMapper mapper;

        public CourseService(IUnitOfWork db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }
        public void AddCourse(CourseDTO courseDTO)
        {
            if (courseDTO == null)
                throw new ArgumentException();

            var course = mapper.Map<Course>(courseDTO);
            
            db.Courses.Create(course);
            db.Save();
        }

        public void DeleteCourse(int id)
        {
            db.Courses.Delete(id);
            db.Save();
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public void EditGroup(CourseDTO courseDTO)
        {
            if (courseDTO == null)
                throw new ArgumentException();

            var course = mapper.Map<Course>(courseDTO);

            db.Courses.Update(course);
            db.Save();
        }

        public CourseDTO GetCourse(int id)
        {
            var course = db.Courses.Get(id);

            return mapper.Map<CourseDTO>(course);
        }

        public List<Course> GetCourses()
        {
            return db.Courses.GetAll();
        }
    }
}
