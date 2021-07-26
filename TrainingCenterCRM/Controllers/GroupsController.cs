using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingCenterCRM.BLL.DTO;
using TrainingCenterCRM.BLL.Interfaces;
using TrainingCenterCRM.BLL.Services;
using TrainingCenterCRM.Models;

namespace TrainingCenterCRM.Controllers
{
    public class GroupsController : Controller
    {
        private readonly IGroupService groupService;
        public GroupsController()
        {
            groupService = new GroupService();
        }

        public IActionResult Index()
        {
            var groupsDto = groupService.GetGroups();
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<GroupDTO, GroupModel>()).CreateMapper();
            var groups = mapper.Map<IEnumerable<GroupDTO>, List<GroupModel>>(groupsDto);

            return View(groups);
        }

        [HttpGet]
        public IActionResult AddGroup()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddGroup(GroupModel group)
        {
            groupService.AddGroup(new GroupDTO()
            {
                Name = group.Name,
                StartDate = group.StartDate
            });

            return RedirectToAction("Index", "Groups");
        }

        [HttpGet]
        public IActionResult EditGroup(int id)
        {
            var groupDto = groupService.GetGroup(id);

            var group = new GroupModel()
            {
                Id = groupDto.Id,
                Name = groupDto.Name,
                StartDate = groupDto.StartDate
            };

            return View(group);
        }

        [HttpPost]
        public IActionResult EditGroup(GroupModel group)
        {
            groupService.EditGroup(new GroupDTO()
            {
                Id = group.Id,
                Name = group.Name,
                StartDate = group.StartDate
            });

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
