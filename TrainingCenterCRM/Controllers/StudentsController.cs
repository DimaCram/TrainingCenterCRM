using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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
        private readonly ILogger logger;
        public StudentsController(IMapper mapper,
                                  IGroupService groupService,
                                  IStudentService studentService,
                                  ILogger<StudentsController> logger)
        {
            this.mapper = mapper;
            this.logger = logger;

            this.studentService = studentService;
            this.groupService = groupService;
        }

        public IActionResult Index()
        {
            try
            {
                var students = studentService.GetStudents();
                var studentsDto = mapper.Map<IEnumerable<Student>, List<Student>>(students);
                return View(studentsDto);
            }
            catch(Exception ex)
            {
                logger.LogError(ex.ToString());
                return StatusCode(500);
            }
        }

        [HttpGet]
        public IActionResult EditStudent(int? id)
        {
            try
            {
                var studentModel = id.HasValue ?
                    mapper.Map<StudentModel>(studentService.GetStudent(id.Value)) :
                    new StudentModel();

                ViewBag.Groups = groupService.GetGroups();

                return View(studentModel);
            }
            catch(Exception ex)
            {
                logger.LogError(ex.ToString());
                return StatusCode(500);
            }
        }

        [HttpPost]
        public IActionResult EditStudent(StudentModel studentModel)
        {
            try
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
            catch (Exception ex)
            {
                logger.LogError(ex.ToString());
                return StatusCode(500);
            }
        }

        [HttpGet]
        public IActionResult DeleteStudent(int id)
        {
            try
            {
                studentService.DeleteStudent(id);
                return RedirectToAction("Index", "Students");
            }
            catch (Exception ex)
            {
                logger.LogError(ex.ToString());
                return StatusCode(500);
            }
        }

        [HttpGet]
        public JsonResult GetStudent(int id)
        {
            try
            {
                var studentModel = mapper.Map<StudentModel>(studentService.GetStudentWithGroup(id));

                return Json(studentModel);
            }
            catch (Exception ex)
            {
                logger.LogError(ex.ToString());
                return null;
            }
        }
    }
}
