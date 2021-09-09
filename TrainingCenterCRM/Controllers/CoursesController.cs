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

        public async Task<IActionResult> IndexAsync()
        {
            try
            {
                var courses = await courseService.GetCoursesAsync();

                return View(courses);
            }
            catch (Exception ex)
            {
                logger.LogError(ex.ToString());
                return StatusCode(500);
            }
        }

        [HttpGet]
        public async Task<IActionResult> EditCourseAsync(int? id)
        {   
            try
            {
                ViewData["Topics"] = await topicService.GetTopicsAsync();
                var course = id.HasValue ? mapper.Map<CourseModel>(await courseService.GetCourseAsync(id.Value)) : new CourseModel();
                return View(course);
            }
            catch (Exception ex) {
                logger.LogError(ex.ToString());
                return StatusCode(500);
            }
        }

        [HttpPost]
        public async Task<IActionResult> EditCourseAsync(CourseModel courseModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var course = mapper.Map<Course>(courseModel);

                    if (course.Id == 0)
                        await courseService.AddCourseAsync(course);
                    else
                        await courseService.EditCourseAsync(course);

                    return RedirectToAction("Index");
                }

                ViewData["Topics"] = await topicService.GetTopicsAsync();
                return View(courseModel);
            }
            catch (Exception ex)
            {
                logger.LogError(ex.ToString());
                return StatusCode(500);
            }
        }

        [HttpGet]
        public async Task<IActionResult> DeleteCourseAsync(int id)
        {
            try
            {
                await courseService.DeleteCourseAsync(id);
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
