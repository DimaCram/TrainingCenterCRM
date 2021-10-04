using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingCenterCRM.Api.Dto;
using TrainingCenterCRM.BLL.Interfaces;
using TrainingCenterCRM.Core.Models;

namespace TrainingCenterCRM.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupsController : ControllerBase
    {
        private readonly IMapper _mapper;

        private readonly IGroupService _groupService;

        public GroupsController(IMapper mapper, IGroupService groupService)
        {
            _mapper = mapper;
            _groupService = groupService;
        }

        [Authorize(Roles = "manager, teacher")]
        [HttpGet]
        public async Task<IEnumerable<GroupDto>> GetAsync()
        {
            return _mapper.Map<IEnumerable<GroupDto>>(await _groupService.GetGroupsAsync());
        }

        [Authorize(Roles = "manager")]
        [HttpGet("{id}")]
        public async Task<GroupDto> GetAsync(int id)
        {
            return _mapper.Map<GroupDto>(await _groupService.GetGroupAsync(id));
        }

        [Authorize(Roles = "manager")]
        [HttpPost]
        public async Task EditCourseAsync(GroupDto groupDto)
        {
            var group = _mapper.Map<Group>(groupDto);

            if (group.Id == 0)
                await _groupService.AddGroupAsync(group, groupDto.Students.Select(g => g.Id));
            else
                await _groupService.EditGroupAsync(group, groupDto.Students.Select(g => g.Id));
        }

        [Authorize(Roles = "manager")]
        [HttpDelete("{id}")]
        public async Task DeleteCourseAsync(int id)
        {
            await _groupService.DeleteGroupAsync(id);
        }

        [Authorize(Roles = "manager")]
        [HttpGet("statuses")]
        public List<string> GetGroupStatuses()
        {
            return Enum.GetNames(typeof(GroupStatus)).ToList();
        }
        
        [Authorize(Roles = "teacher")]
        [HttpGet("teacherGroups")]
        public async Task<IEnumerable<GroupDto>> GetTeacherGroups()
        {
            var userEmail = HttpContext.User.Identity.Name;
            return _mapper.Map<IEnumerable<GroupDto>>(await _groupService.GetTeacherGroups(userEmail));
        }
    }
}
