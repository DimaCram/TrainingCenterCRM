using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TrainingCenterCRM.BLL.DTO;
using TrainingCenterCRM.BLL.Interfaces;
using TrainingCenterCRM.DAL;
using TrainingCenterCRM.DAL.Enttities;
using TrainingCenterCRM.DAL.Interfaces;

namespace TrainingCenterCRM.BLL.Services
{
    public class StudentService : IStudentService
    {
        private readonly IUnitOfWork db;
        private readonly IMapper mapper;

        public StudentService(IUnitOfWork db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }
        public void AddStudent(StudentDTO studentDTO)
        {
            if (studentDTO == null)
                throw new ArgumentException();

            var student = mapper.Map<Student>(studentDTO);

            db.Students.Create(student);
            db.Save();
        }
        public void EditStudent(StudentDTO studentDTO)
        {
            if (studentDTO == null)
                throw new ArgumentException();

            var student = mapper.Map<Student>(studentDTO);

            db.Students.Update(student);
            db.Save();
        }
        public void DeleteStudent(int id)
        {
            db.Students.Delete(id);
            db.Save();
        }
        public StudentDTO GetStudent(int id)
        {
            var student = db.Students.Get(id);

            return mapper.Map<StudentDTO>(student);
        }
        public List<Student> GetStudents()
        {
            return db.Students.GetAll();
        }
        public void Dispose()
        {
            db.Dispose();
        }
    }
}
