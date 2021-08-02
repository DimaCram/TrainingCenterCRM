﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingCenterCRM.BLL.DTO;
using TrainingCenterCRM.BLL.Interfaces;
using TrainingCenterCRM.BLL.Services;
using TrainingCenterCRM.DAL.Enttities;
using TrainingCenterCRM.Models;

namespace TrainingCenterCRM.Controllers
{
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

            var groupsDto = mapper.Map<IEnumerable<Group>, List<GroupDTO>>(groups);

            return View(groupsDto);
        }

        [HttpGet]
        public IActionResult AddGroup()
        {

            var teachers = teacherService.GetTeachers();
            ViewData["Teachers"] = mapper.Map<List<TeacherDTO>>(teachers);

            return View();
        }

        [HttpPost]
        public IActionResult AddGroup(GroupModel group)
        {

            groupService.AddGroup(mapper.Map<GroupDTO>(group));

            return RedirectToAction("Index", "Groups");
        }

        [HttpGet]
        public IActionResult EditGroup(int id)
        {
            var groupDto = groupService.GetGroup(id);

            var teachers = teacherService.GetTeachers();
            ViewData["Teachers"] = mapper.Map<List<TeacherDTO>>(teachers);

            return View(mapper.Map<GroupModel>(groupDto));
        }

        [HttpPost]
        public IActionResult EditGroup(GroupModel group)
        {
            groupService.EditGroup(mapper.Map<GroupDTO>(group));

            return RedirectToAction("Index", "Groups");
        }

        [HttpGet]
        public IActionResult DeleteGroup(int id)
        {
            groupService.DeleteGroup(id);
            return RedirectToAction("Index", "Groups");
        }
    }
}
