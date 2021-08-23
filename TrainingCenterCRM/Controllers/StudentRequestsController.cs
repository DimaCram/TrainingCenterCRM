using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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
        private readonly ILogger logger;

        private readonly IStudentRequestService studentRequestService;
        private readonly IStudentService studentService;
        private readonly ICourseService courseService;
        private readonly IGroupService groupService;

        public StudentRequestsController(IMapper mapper,
                                         IStudentRequestService studentRequestService,
                                         IStudentService studentService,
                                         ICourseService courseService,
                                         IGroupService groupService,
                                         ILogger logger)
        {
            this.mapper = mapper;
            this.logger = logger;

            this.studentRequestService = studentRequestService;
            this.studentService = studentService;
            this.courseService = courseService;
            this.groupService = groupService;
        }

        public IActionResult Index()
        {
            try
            {
                var requests = studentRequestService.GetRequests();
                return View(requests);
            }
            catch (Exception ex)
            {
                logger.LogError(ex.ToString());
                return StatusCode(500);
            }
        }
        [HttpGet]
        public IActionResult EditRequest(int? id, int studentId)
        {
            try
            {
                var request = id.HasValue ?
                    mapper.Map<StudentRequestModel>(studentRequestService.GetRequest(id.Value)) :
                    new StudentRequestModel() { ReadyToStartDate = DateTime.Today };

                request.Student = mapper.Map<StudentModel>(studentService.GetStudent(studentId));
                ViewBag.Courses = courseService.GetCourses();

                return View(request);
            }
            catch (Exception ex)
            {
                logger.LogError(ex.ToString());
                return StatusCode(500);
            }
        }
        [HttpPost]
        public IActionResult EditRequest(StudentRequestModel model)
        {
            try
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
            catch (Exception ex)
            {
                logger.LogError(ex.ToString());
                return StatusCode(500);
            }
        }

        [HttpGet]
        public IActionResult DeleteRequest(int id)
        {
            try
            {
                studentRequestService.DeleteRequest(id);
                return RedirectToAction("Index", "StudentRequests");
            }
            catch (Exception ex)
            {
                logger.LogError(ex.ToString());
                return StatusCode(500);
            }
        }

        public JsonResult GetStudentsByCourse(int courseId, int groupId)
        {
            try
            {
                var students = mapper.Map<List<StudentModel>>(studentRequestService.GetStudentsByCourse(courseId));

                if (groupId != 0)
                {
                    var studentsWithGroup = mapper.Map<List<StudentModel>>(groupService.GetStudentsWithGroup(groupId, courseId));
                    foreach (var studentWithGroup in studentsWithGroup)
                    {
                        studentWithGroup.HasGroup = true;
                        studentWithGroup.Group = null;
                    }

                    students.AddRange(studentsWithGroup);
                }

                return Json(students.OrderBy(s => s.Name));
            }
            catch (Exception ex)
            {
                logger.LogError(ex.ToString());
                return null;
            }
        }
    }
}
