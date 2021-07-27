﻿using AutoMapper;
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

        public StudentService()
        {
            db = new UnitOfWork();
        }
        public void AddStudent(StudentDTO studentDTO)
        {
            if (studentDTO == null)
                throw new ArgumentException();

            var student = new Student()
            {
                Id = studentDTO.Id,
                Name = studentDTO.Name,
                Surname = studentDTO.Surname,
                Age = studentDTO.Age,
                GroupId = studentDTO.GroupId
            };

            db.Students.Create(student);
            db.Save();
        }
        public void EditStudent(StudentDTO studentDTO)
        {
            if (studentDTO == null)
                throw new ArgumentException();

            var student = new Student()
            {
                Id = studentDTO.Id,
                Name = studentDTO.Name,
                Surname = studentDTO.Surname,
                Age = studentDTO.Age
            };

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
            return new StudentDTO()
            {
                Id = student.Id,
                Name = student.Name,
                Surname = student.Surname,
                Age = student.Age
            };
        }
        public List<StudentDTO> GetStudents()
        {
            var studentsDTO = new List<StudentDTO>();
            foreach(var student in db.Students.GetAll())
            {
                studentsDTO.Add(new StudentDTO()
                {
                    Id = student.Id,
                    Name = student.Name,
                    Surname = student.Surname,
                    Age = student.Age,
                    Group = new GroupDTO()
                    {
                        Name = student.Group.Name,
                        StartDate = student.Group.StartDate
                    },
                });
            }
            return studentsDTO;
        }
        public void Dispose()
        {
            db.Dispose();
        }
    }
}
