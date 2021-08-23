using AutoMapper;
using Microsoft.AspNetCore.Authorization;
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
    [Authorize]
    public class CoursesController : Controller
    {
        private readonly ICourseService courseService;
        private readonly ITopicService topicService;

        private readonly IMapper mapper;
        private readonly ILogger logger;

        public CoursesController(IMapper mapper,
                                 ICourseService courseService,
                                 ITopicService topicService,
                                 ILogger<CoursesController> logger)
        {
            this.mapper = mapper;
            this.logger = logger;

            this.courseService = courseService;
            this.topicService = topicService;
        }

        public IActionResult Index()
        {
            try
            {
                var courses = courseService.GetCourses();
                var coursesDto = mapper.Map<List<Course>>(courses);

                return View(coursesDto);
            }
            catch (Exception ex)
            {
                logger.LogError(ex.ToString());
                return StatusCode(500);
            }
        }

        [HttpGet]
        public IActionResult EditCourse(int? id)
        {   
            try
            {
                ViewData["Topics"] = topicService.GetTopics();
                var course = id.HasValue ? mapper.Map<CourseModel>(courseService.GetCourse(id.Value)) : new CourseModel();
                return View(course);
            }
            catch (Exception ex) {
                logger.LogError(ex.ToString());
                return StatusCode(500);
            }
        }

        [HttpPost]
        public IActionResult EditCourse(CourseModel courseModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var course = mapper.Map<Course>(courseModel);

                    if (course.Id == 0)
                        courseService.AddCourse(course);
                    else
                        courseService.EditCourse(course);

                    return RedirectToAction("Index");
                }

                ViewData["Topics"] = topicService.GetTopics();
                return View(courseModel);
            }
            catch (Exception ex)
            {
                logger.LogError(ex.ToString());
                return StatusCode(500);
            }
        }

        [HttpGet]
        public IActionResult DeleteCourse(int id)
        {
            try
            {
                courseService.DeleteCourse(id);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                logger.LogError(ex.ToString());
                return StatusCode(500);
            }
        }
    }
}
