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

        private readonly IMapper mapper;
        
        public GroupsController(IMapper mapper, IGroupService groupService, ITeacherService teacherService)
        {
            this.mapper = mapper;

            this.groupService = groupService;
            this.teacherService = teacherService;
        }

        public IActionResult Index()
        {
            var groups = groupService.GetGroups();

            var groupsDto = mapper.Map<IEnumerable<Group>, List<Group>>(groups);

            return View(groupsDto);
        }

        [HttpGet]
        public IActionResult EditGroup(int? id)
        {
            var groupModel = id.HasValue ?
                mapper.Map<GroupModel>(groupService.GetGroup(id.Value)) :
                new GroupModel() { StartDate = DateTime.Today };

            ViewBag.Teachers = teacherService.GetTeachers();

            return View(groupModel);
        }

        [HttpPost]
        public IActionResult EditGroup(GroupModel groupModel)
        {
            if (ModelState.IsValid)
            {
                var group = mapper.Map<Group>(groupModel);
                
                if (group.Id == 0)
                    groupService.AddGroup(group);
                else
                    groupService.EditGroup(group);

                return RedirectToAction("Index", "Groups");
            }

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
