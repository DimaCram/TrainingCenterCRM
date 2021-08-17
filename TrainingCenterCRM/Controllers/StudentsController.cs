﻿using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingCenterCRM.BLL.Interfaces;
using TrainingCenterCRM.BLL.Models;
using TrainingCenterCRM.BLL.Services;
using TrainingCenterCRM.Models;

namespace TrainingCenterCRM.Controllers
{
    [Authorize]
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
            var students = studentService.GetStudents();
            var studentsDto = mapper.Map<IEnumerable<Student>, List<Student>>(students);

            return View(studentsDto);
        }

        [HttpGet]
        public IActionResult AddStudent()
        {
            var groups = groupService.GetGroups();
            ViewData["Groups"] = mapper.Map<List<Group>, List<Group>>(groups);

            ViewData["Action"] = "Add";

            return View("EditStudent");
        }

        [HttpPost]
        public IActionResult AddStudent(StudentModel student)
        {
            studentService.AddStudent(mapper.Map<Student>(student));

            return RedirectToAction("Index", "Students");
        }

        [HttpGet]
        public IActionResult EditStudent(int id)
        {
            var studentDto = studentService.GetStudent(id);

            var groups = groupService.GetGroups();
            ViewData["Groups"] = mapper.Map<List<Group>, List<Group>>(groups);

            ViewData["Action"] = "Edit";

            return View(mapper.Map<StudentModel>(studentDto));
        }

        [HttpPost]
        public IActionResult EditStudent(StudentModel student)
        {
            studentService.EditStudent(mapper.Map<Student>(student));

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
