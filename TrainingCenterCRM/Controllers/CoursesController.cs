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
            var coursesDto = mapper.Map<List<CourseDTO>>(courses);

            return View(coursesDto);
        }

        [HttpGet]
        public IActionResult AddCourse()
        {
            var topics = topicService.GetTopics();
            ViewData["Topics"] = mapper.Map<List<Topic>, List<TopicDTO>>(topics);

            ViewData["Action"] = "Add";

            return View("EditCourse");
        }

        [HttpPost]
        public IActionResult AddCourse(CourseModel course)
        {
            courseService.AddCourse(mapper.Map<CourseDTO>(course));

            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult EditCourse(int id)
        {
            var topics = topicService.GetTopics();
            ViewData["Topics"] = mapper.Map<List<Topic>, List<TopicDTO>>(topics);

            var courseDto = courseService.GetCourse(id);
            ViewData["Action"] = "Edit";

            return View(mapper.Map<CourseModel>(courseDto));
        }

        [HttpPost]
        public IActionResult EditCourse(CourseModel course)
        {
            courseService.EditCourse(mapper.Map<CourseDTO>(course));

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeleteCourse(int id)
        {
            courseService.DeleteCourse(id);
            return RedirectToAction("Index");
        }
    }
}
