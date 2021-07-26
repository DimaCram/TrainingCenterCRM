using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingCenterCRM.BLL.DTO;
using TrainingCenterCRM.BLL.Interfaces;
using TrainingCenterCRM.BLL.Services;
using TrainingCenterCRM.Models;

namespace TrainingCenterCRM.Controllers
{
    public class StudentsController : Controller
    {
        private readonly IStudentService studentService;
        public StudentsController()
        {
            studentService = new StudentService();
        }

        public IActionResult Index()
        {
            var studentsDto = studentService.GetStudents();
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<StudentDTO, StudentModel>()).CreateMapper();
            var students = mapper.Map<IEnumerable<StudentDTO>, List<StudentModel>>(studentsDto);

            return View(students);
        }

        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddStudent(StudentModel student)
        {
            studentService.AddStudent(new StudentDTO()
            {
                Name = student.Name,
                Surname = student.Surname,
                Age = student.Age
            });

            return RedirectToAction("Index", "Students");
        }

        [HttpGet]
        public IActionResult EditStudent(int id)
        {
            var studentDto = studentService.GetStudent(id);

            var student = new StudentModel()
            {
                Id = studentDto.Id,
                Name = studentDto.Name,
                Surname = studentDto.Surname,
                Age = studentDto.Age
            };

            return View(student);
        }

        [HttpPost]
        public IActionResult EditStudent(StudentModel student)
        {
            studentService.EditStudent(new StudentDTO()
            {
                Id = student.Id,
                Name = student.Name,
                Surname = student.Surname,
                Age = student.Age
            });

            return RedirectToAction("Index", "Students");
        }

        [HttpGet]
        public IActionResult DeleteStudent(int id)
        {
            studentService.DeleteStudent(id);
            return RedirectToAction("Index", "Students");
        }
    }
}
