using AutoMapper;
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
        public IActionResult EditStudent(int? id)
        {
            var studentModel = id.HasValue ?
                mapper.Map<StudentModel>(studentService.GetStudent(id.Value)) :
                new StudentModel();

            ViewBag.Groups = groupService.GetGroups();

            return View(studentModel);
        }

        [HttpPost]
        public IActionResult EditStudent(StudentModel studentModel)
        {
            if (ModelState.IsValid)
            {
                var student = mapper.Map<Student>(studentModel);

                if (student.Id == 0)
                    studentService.AddStudent(student);
                else
                    studentService.EditStudent(student);

                return RedirectToAction("Index", "Students");
            }

            ViewBag.Groups = groupService.GetGroups();
            return View(studentModel);
        }

        [HttpGet]
        public IActionResult DeleteStudent(int id)
        {
            studentService.DeleteStudent(id);
            return RedirectToAction("Index", "Students");
        }
    }
}
