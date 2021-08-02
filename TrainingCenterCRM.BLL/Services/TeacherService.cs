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
    public class TeacherService : ITeacherService
    {
        private readonly IUnitOfWork db;
        private readonly IMapper mapper;

        public TeacherService(IUnitOfWork db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }
        public void AddTeacher(TeacherDTO teacherDTO)
        {
            if (teacherDTO == null)
                throw new ArgumentException();

            var teacher = mapper.Map<Teacher>(teacherDTO);

            db.Teachers.Create(teacher);
            db.Save();
        }

        public void DeleteTeacher(int id)
        {
            db.Teachers.Delete(id);
            db.Save();
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public void EditTeacher(TeacherDTO teacherDTO)
        {
            if (teacherDTO == null)
                throw new ArgumentException();

            var teacher = mapper.Map<Teacher>(teacherDTO);

            db.Teachers.Update(teacher);
            db.Save();
        }

        public TeacherDTO GetTeacher(int id)
        {
            var teacher = db.Teachers.Get(id);

            return mapper.Map<TeacherDTO>(teacher);
        }

        public List<Teacher> GetTeachers()
        {
            return db.Teachers.GetAll();
        }
    }
}
