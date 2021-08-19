using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingCenterCRM.BLL.Interfaces;
using TrainingCenterCRM.BLL.Models;
using TrainingCenterCRM.Models;

namespace TrainingCenterCRM.Controllers
{
    [Authorize]
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

            var teachersDto = mapper.Map<List<Teacher>>(teachers);

            return View(teachersDto);
        }

        [HttpGet]
        public IActionResult EditTeacher(int? id)
        {
            var teacherModel = id.HasValue ?
                mapper.Map<TeacherModel>(teacherService.GetTeacher(id.Value)) :
                new TeacherModel();

            return View(teacherModel);
        }

        [HttpPost]
        public IActionResult EditTeacher(TeacherModel teacherModel)
        {
            if (ModelState.IsValid)
            {
                var teacher = mapper.Map<Teacher>(teacherModel);

                if (teacherModel.Id == 0)
                    teacherService.AddTeacher(teacher);
                else
                    teacherService.EditTeacher(teacher);
    
                return RedirectToAction("Index", "Teachers");
            }
            return View(teacherModel);
        }

        [HttpGet]
        public IActionResult DeleteTeacher(int id)
        {
            teacherService.DeleteTeacher(id);
            return RedirectToAction("Index", "Teachers");
        }
    }
}
