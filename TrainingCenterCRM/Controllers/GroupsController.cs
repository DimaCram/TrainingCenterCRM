using AutoMapper;
using Microsoft.AspNetCore.Authorization;
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
    public class GroupsController : Controller
    {
        private readonly IGroupService groupService;
        private readonly ITeacherService teacherService;
        private readonly ICourseService courseService;

        private readonly IMapper mapper;

        public GroupsController(IMapper mapper, 
                                IGroupService groupService,
                                ITeacherService teacherService,
                                ICourseService courseService)
        {
            this.mapper = mapper;

            this.groupService = groupService;
            this.teacherService = teacherService;
            this.courseService = courseService;
        }

        public IActionResult Index()
        {
            var groups = groupService.GetGroups();

            return View(groups);
        }

        [HttpGet]
        public IActionResult EditGroup(int? id)
        {
            var groupModel = id.HasValue ?
                mapper.Map<GroupModel>(groupService.GetGroup(id.Value)) :
                new GroupModel() { StartDate = DateTime.Today };

            ViewBag.Teachers = teacherService.GetTeachers();
            ViewBag.Courses = courseService.GetCourses();

            return View(groupModel);
        }
        [HttpGet]
        public IActionResult AddGroup(int? id)
        {
            var groupModel = id.HasValue ?
                mapper.Map<GroupModel>(groupService.GetGroup(id.Value)) :
                new GroupModel() { StartDate = DateTime.Today };

            ViewBag.Teachers = teacherService.GetTeachers();
            ViewBag.Courses = courseService.GetCourses();

            return View("EditGroup", groupModel);
        }
        [HttpPost]
        public IActionResult EditGroup(GroupModel groupModel, List<int> studentsId)
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

        [HttpGet]
        public IActionResult DeleteGroup(int id)
        {
            groupService.DeleteGroup(id);
            return RedirectToAction("Index", "Groups");
        }
    }
}
