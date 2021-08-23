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
using TrainingCenterCRM.BLL.Services;
using TrainingCenterCRM.Models;

namespace TrainingCenterCRM.Controllers
{
    [Authorize]
    public class GroupsController : Controller
    {
        private readonly IGroupService groupService;
        private readonly ITeacherService teacherService;
        private readonly ICourseService courseService;

        private readonly IMapper mapper;
        private readonly ILogger logger;

        public GroupsController(IMapper mapper,
                                IGroupService groupService,
                                ITeacherService teacherService,
                                ICourseService courseService,
                                ILogger logger)
        {
            this.mapper = mapper;
            this.logger = logger;

            this.groupService = groupService;
            this.teacherService = teacherService;
            this.courseService = courseService;
        }

        public IActionResult Index()
        {
            try
            {
                var groups = groupService.GetGroups();

                return View(groups);
            }
            catch (Exception ex)
            {
                logger.LogError(ex.ToString());
                return StatusCode(500);
            }
        }

        [HttpGet]
        public IActionResult EditGroup(int? id)
        {
            try
            {
                var groupModel = id.HasValue ?
                    mapper.Map<GroupModel>(groupService.GetGroup(id.Value)) :
                    new GroupModel() { StartDate = DateTime.Today };

                ViewBag.Teachers = teacherService.GetTeachers();
                ViewBag.Courses = courseService.GetCourses();

                return View(groupModel);
            }
            catch (Exception ex)
            {
                logger.LogError(ex.ToString());
                return StatusCode(500);
            }
        }
        [HttpGet]
        public IActionResult AddGroup(int? id)
        {
            try
            {
                var groupModel = id.HasValue ?
                    mapper.Map<GroupModel>(groupService.GetGroup(id.Value)) :
                    new GroupModel() { StartDate = DateTime.Today };

                ViewBag.Teachers = teacherService.GetTeachers();
                ViewBag.Courses = courseService.GetCourses();

                return View("EditGroup", groupModel);
            }
            catch (Exception ex)
            {
                logger.LogError(ex.ToString());
                return StatusCode(500);
            }
        }
        [HttpPost]
        public IActionResult EditGroup(GroupModel groupModel, List<int> studentsId)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var group = mapper.Map<Group>(groupModel);

                    if (group.Id == 0)
                        groupService.AddGroup(group, studentsId);
                    else
                        groupService.EditGroup(group, studentsId);

                    return RedirectToAction("Index", "Groups");
                }

                ViewBag.Courses = courseService.GetCourses();
                ViewBag.Teachers = teacherService.GetTeachers();
                return View(groupModel);
            }
            catch (Exception ex)
            {
                logger.LogError(ex.ToString());
                return StatusCode(500);
            }
        }

        [HttpGet]
        public IActionResult DeleteGroup(int id)
        {
            try
            {
                groupService.DeleteGroup(id);
                return RedirectToAction("Index", "Groups");
            }
            catch (Exception ex)
            {
                logger.LogError(ex.ToString());
                return StatusCode(500);
            }
        }
    }
}
