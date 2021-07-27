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
using TrainingCenterCRM.DAL.Enttities;
using TrainingCenterCRM.Models;

namespace TrainingCenterCRM.Controllers
{
    public class StudentsController : Controller
    {
        private readonly IStudentService studentService;
        private readonly IGroupService groupService;

        private readonly IMapper mapper;
        public StudentsController(IMapper mapper, IGroupService groupService, IStudentService studentService)
        {
            this.mapper = mapper;

            this.studentService = studentService;
            this.groupService = groupService;
        }

        public IActionResult Index()
        {
            var students = new List<StudentModel>();
            foreach (var studentsDTO in studentService.GetStudents())
            {
                students.Add(new StudentModel()
                {
                    Id = studentsDTO.Id,
                    Name = studentsDTO.Name,
                    Surname = studentsDTO.Surname,
                    Age = studentsDTO.Age,
                    Group = new GroupModel()
                    {
                        Name = studentsDTO.Group.Name,
                        StartDate = studentsDTO.Group.StartDate
                    },
                });
            }

            return View(students);
        }

        [HttpGet]
        public IActionResult AddStudent()
        {
            var groups = groupService.GetGroups();
            ViewData["Groups"] = mapper.Map<IEnumerable<Group>, List<GroupDTO>>(groups);

            return View();
        }

        [HttpPost]
        public IActionResult AddStudent(StudentModel student)
        {
            studentService.AddStudent(new StudentDTO()
            {
                Name = student.Name,
                Surname = student.Surname,
                Age = student.Age,
                GroupId = student.GroupId
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
