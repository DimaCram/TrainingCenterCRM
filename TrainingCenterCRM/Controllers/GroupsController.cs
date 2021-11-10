using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TrainingCenterCRM.BLL.Interfaces;
using TrainingCenterCRM.Core.Models;
using TrainingCenterCRM.Models;

namespace TrainingCenterCRM.Controllers
{
    [Authorize(Roles = "manager")]
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
                                ILogger<GroupsController> logger)
        {
            this.mapper = mapper;
            this.logger = logger;

            this.groupService = groupService;
            this.teacherService = teacherService;
            this.courseService = courseService;
        }

        public async Task<IActionResult> IndexAsync()
        {
            try
            {
                var groups = await groupService.GetGroupsAsync();

                return View(groups);
            }
            catch (Exception ex)
            {
                logger.LogError(ex.ToString());
                return StatusCode(500);
            }
        }

        [HttpGet]
        public async Task<IActionResult> EditGroupAsync(int? id)
        {
            try
            {
                var groupModel = id.HasValue ?
                    mapper.Map<GroupModel>(await groupService.GetGroupAsync(id.Value)) :
                    new GroupModel() { StartDate = DateTime.Today };

                ViewBag.Teachers = await teacherService.GetTeachersAsync();
                ViewBag.Courses = await courseService.GetCoursesAsync();

                return View(groupModel);
            }
            catch (Exception ex)
            {
                logger.LogError(ex.ToString());
                return StatusCode(500);
            }
        }
        [HttpGet]
        public async Task<IActionResult> AddGroupAsync(int? id)
        {
            try
            {
                var groupModel = id.HasValue ?
                    mapper.Map<GroupModel>(await groupService.GetGroupAsync(id.Value)) :
                    new GroupModel() { StartDate = DateTime.Today };

                ViewBag.Teachers = await teacherService.GetTeachersAsync();
                ViewBag.Courses = await courseService.GetCoursesAsync();

                return View("EditGroup", groupModel);
            }
            catch (Exception ex)
            {
                logger.LogError(ex.ToString());
                return StatusCode(500);
            }
        }
        [HttpPost]
        public async Task<IActionResult> EditGroupAsync(GroupModel groupModel, List<int> studentsId)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var group = mapper.Map<Group>(groupModel);

                    if (group.Id == 0)
                        await groupService.AddGroupAsync(group, studentsId);
                    else
                        await groupService.EditGroupAsync(group, studentsId);

                    return RedirectToAction("Index", "Groups");
                }

                ViewBag.Courses = await courseService.GetCoursesAsync();
                ViewBag.Teachers = await teacherService.GetTeachersAsync();
                return View(groupModel);
            }
            catch (Exception ex)
            {
                logger.LogError(ex.ToString());
                return StatusCode(500);
            }
        }

        [HttpGet]
        public async Task<IActionResult> DeleteGroupAsync(int id)
        {
            try
            {
                await groupService.DeleteGroupAsync(id);
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
