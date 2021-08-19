using AutoMapper;
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
    public class StudentRequestsController : Controller
    {
        private readonly IMapper mapper;

        private readonly IStudentRequestService studentRequestService;
        private readonly IStudentService studentService;
        private readonly ICourseService courseService;

        public StudentRequestsController(IMapper mapper, 
                                         IStudentRequestService studentRequestService,
                                         IStudentService studentService,
                                         ICourseService courseService)
        {
            this.mapper = mapper;
            this.studentRequestService = studentRequestService;
            this.studentService = studentService;
            this.courseService = courseService;
        }

        public IActionResult Index()
        {
            var requests = studentRequestService.GetRequests();
            return View(requests);
        }
        [HttpGet]
        public IActionResult EditRequest(int? id, int studentId)
        {
            var request = id.HasValue ? 
                mapper.Map<StudentRequestModel>(studentRequestService.GetRequest(id.Value)) : 
                new StudentRequestModel() { ReadyToStartDate = DateTime.Today };

            request.Student = mapper.Map<StudentModel>(studentService.GetStudent(studentId));
            ViewBag.Courses = courseService.GetCourses();
            
            return View(request);
        }
        [HttpPost]
        public IActionResult EditRequest(StudentRequestModel model)
        {
            if (ModelState.IsValid)
            {
                var request = mapper.Map<StudentRequest>(model);

                if (model.Id == 0)
                    studentRequestService.AddRequest(request);
                else
                    studentRequestService.EditRequest(request);

                return RedirectToAction("Index", "StudentRequests");
            }
            model.Student = mapper.Map<StudentModel>(studentService.GetStudent(model.StudentId));
            ViewBag.Courses = courseService.GetCourses();
            return View(model);
        }

        [HttpGet]
        public IActionResult DeleteRequest(int id)
        {
            studentRequestService.DeleteRequest(id);
            return RedirectToAction("Index", "StudentRequests");
        }

        public JsonResult GetStudentsByCourse(int courseId)
        {
            var students = studentRequestService.GetStudentsByCourse(courseId);
            return Json(students);
        }
    }
}
