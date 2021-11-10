using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingCenterCRM.BLL.Interfaces;
using TrainingCenterCRM.Core.Models;
using TrainingCenterCRM.Models;

namespace TrainingCenterCRM.Controllers
{
    //[Authorize(Roles = "manager")]
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
                                         ILogger<StudentRequestsController> logger)
        {
            this.mapper = mapper;
            this.logger = logger;

            this.studentRequestService = studentRequestService;
            this.studentService = studentService;
            this.courseService = courseService;
            this.groupService = groupService;
        }

        public async Task<IActionResult> IndexAsync()
        {
            try
            {
                var requests = await studentRequestService.GetOpenRequestsAsync();
                return View(requests);
            }
            catch (Exception ex)
            {
                logger.LogError(ex.ToString());
                return StatusCode(500);
            }
        }
        [HttpGet]
        public async Task<IActionResult> EditRequestAsync(int? id, int studentId)
        {
            try
            {
                var request = id.HasValue ?
                    mapper.Map<StudentRequestModel>(await studentRequestService.GetRequestAsync(id.Value)) :
                    new StudentRequestModel() { ReadyToStartDate = DateTime.Today };

                request.Student = mapper.Map<StudentModel>(await studentService.GetStudentAsync(studentId));
                ViewBag.Courses = await courseService.GetCoursesAsync();

                return View(request);
            }
            catch (Exception ex)
            {
                logger.LogError(ex.ToString());
                return StatusCode(500);
            }
        }
        [HttpPost]
        public async Task<IActionResult> EditRequestAsync(StudentRequestModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var request = mapper.Map<StudentRequest>(model);

                    if (model.Id == 0)
                        await studentRequestService.AddRequestAsync(request);
                    else
                        await studentRequestService.EditRequestAsync(request);

                    return RedirectToAction("Index", "StudentRequests");
                }
                model.Student = mapper.Map<StudentModel>(await studentService.GetStudentAsync(model.StudentId));
                ViewBag.Courses = await courseService.GetCoursesAsync();
                return View(model);
            }
            catch (Exception ex)
            {
                logger.LogError(ex.ToString());
                return StatusCode(500);
            }
        }

        [HttpGet]
        public async Task<IActionResult> DeleteRequestAsync(int id)
        {
            try
            {
                await studentRequestService.DeleteRequestAsync(id);
                return RedirectToAction("Index", "StudentRequests");
            }
            catch (Exception ex)
            {
                logger.LogError(ex.ToString());
                return StatusCode(500);
            }
        }

        public async Task<JsonResult> GetStudentsByCourseAsync(int courseId, int groupId)
        {
            try
            {
                var students = mapper.Map<List<StudentModel>>(await studentRequestService.GetStudentsRequestedForCourseAsync(courseId));

                if (groupId != 0)
                {
                    var studentsWithGroup = mapper.Map<List<StudentModel>>(await groupService.GetStudentsWithGroupAsync(groupId, courseId));
                    foreach (var studentWithGroup in studentsWithGroup)
                    {
                        studentWithGroup.HasGroup = true;
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
