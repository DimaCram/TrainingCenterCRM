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
    public class CoursesController : Controller
    {
        private readonly ICourseService courseService;
        private readonly ITopicService topicService;

        private readonly IMapper mapper;

        public CoursesController(IMapper mapper, ICourseService courseService, ITopicService topicService)
        {
            this.mapper = mapper;

            this.courseService = courseService; 
            this.topicService = topicService; 
        }

        public IActionResult Index()
        {
            var courses = courseService.GetCourses();
            var coursesDto = mapper.Map<List<Course>>(courses);

            return View(coursesDto);
        }

        [HttpGet]
        public IActionResult EditCourse(int? id)
        {
            ViewData["Topics"] = topicService.GetTopics();

            var course = id.HasValue ?
                mapper.Map<CourseModel>(courseService.GetCourse(id.Value)) :
                new CourseModel();

            return View(course);
        }

        [HttpPost]
        public IActionResult EditCourse(CourseModel courseModel)
        {
            if (ModelState.IsValid)
            {
                var course = mapper.Map<Course>(courseModel);

                if(course.Id == 0)
                    courseService.AddCourse(course);
                else
                    courseService.EditCourse(course);
                
                return RedirectToAction("Index");
            }

            ViewData["Topics"] = topicService.GetTopics();
            return View(courseModel);
        }

        [HttpGet]
        public IActionResult DeleteCourse(int id)
        {
            courseService.DeleteCourse(id);
            return RedirectToAction("Index");
        }
    }
}
