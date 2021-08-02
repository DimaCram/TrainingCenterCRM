using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingCenterCRM.BLL.DTO;
using TrainingCenterCRM.BLL.Interfaces;
using TrainingCenterCRM.DAL.Enttities;
using TrainingCenterCRM.Models;

namespace TrainingCenterCRM.Controllers
{
    public class TeachersController : Controller
    {
        private readonly ITeacherService teacherService;

        private readonly IMapper mapper;
        public TeachersController(IMapper mapper, ITeacherService teacherService)
        {
            this.mapper = mapper;

            this.teacherService = teacherService;
        }

        public IActionResult Index()
        {
            var teachers = teacherService.GetTeachers();

            var teachersDto = mapper.Map<List<TeacherDTO>>(teachers);

            return View(teachersDto);
        }

        [HttpGet]
        public IActionResult AddTeacher()
        {
            ViewData["Action"] = "Add";

            return View("EditTeacher");
        }

        [HttpPost]
        public IActionResult AddTeacher(TeacherModel teacher)
        {
            teacherService.AddTeacher(mapper.Map<TeacherDTO>(teacher));

            return RedirectToAction("Index", "Teachers");
        }

        [HttpGet]
        public IActionResult EditTeacher(int id)
        {
            var teacherDto = teacherService.GetTeacher(id);

            ViewData["Action"] = "Edit";

            return View(mapper.Map<TeacherModel>(teacherDto));
        }

        [HttpPost]
        public IActionResult EditTeacher(TeacherModel teacher)
        {
            teacherService.EditTeacher(mapper.Map<TeacherDTO>(teacher));

            return RedirectToAction("Index", "Teachers");
        }

        [HttpGet]
        public IActionResult DeleteTeacher(int id)
        {
            teacherService.DeleteTeacher(id);
            return RedirectToAction("Index", "Teachers");
        }
    }
}
