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
using TrainingCenterCRM.Core.Enums;
using TrainingCenterCRM.Core.Filters;
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
        public async Task<IEnumerable<GroupDto>> GetGroupsAsync()
        {
            return _mapper.Map<IEnumerable<GroupDto>>(await _groupService.GetGroupsAsync());
        }

        [Authorize(Roles = "manager, teacher")]
        [HttpGet("pagination")]
        public async Task<IEnumerable<GroupDto>> GetGroupsByPaginationAsync([FromQuery] PaginationDto pagination)
        {
            var paginationFilter = _mapper.Map<PaginationFilter>(pagination);
            var groups = await _groupService.GetGroupsByPaginationAsync(paginationFilter);

            return _mapper.Map<IEnumerable<GroupDto>>(groups);
        }

        [Authorize(Roles = "manager, teacher")]
        [HttpGet("{id}")]
        public async Task<GroupDto> GetGroupAsync(int id)
        {
            return _mapper.Map<GroupDto>(await _groupService.GetGroupAsync(id));
        }

        [Authorize(Roles = "manager")]
        [HttpPost]
        public async Task EditGroupAsync(GroupDto groupDto)
        {
            var group = _mapper.Map<Group>(groupDto);

            if (group.Id == 0)
                await _groupService.AddGroupAsync(group, groupDto.Students.Select(g => g.Id));
            else
                await _groupService.EditGroupAsync(group, groupDto.Students.Select(g => g.Id));
        }

        [Authorize(Roles = "manager")]
        [HttpDelete("{id}")]
        public async Task DeleteGroupAsync(int id)
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
        [Authorize(Roles = "manager")]
        [HttpGet("inviteNotification")]
        public async Task SendInviteNotifications(int groupId)
        {
            await _groupService.SendInviteNotifications(groupId);
        }

        [Authorize(Roles = "teacher")]
        [HttpGet("checkAccessToGroup")]
        public async Task<bool> HasAccessToGroup(int groupId)
        {
            var userEmail = HttpContext.User.Identity.Name;
            return await _groupService.HasAccessToGroup(groupId, userEmail);
        }

        [Authorize(Roles = "student")]
        [HttpGet("studentGroups")]
        public async Task<IEnumerable<GroupDto>> GetStudentGroups()
        {
            var userEmail = HttpContext.User.Identity.Name;
            return _mapper.Map<IEnumerable<GroupDto>>(await _groupService.GetStudentGroups(userEmail));
        }

        [Authorize(Roles = "student")]
        [HttpGet("groupTeacher")]
        public async Task<TeacherDto> GetGroupTeacher(int groupId)
        {
            return _mapper.Map<TeacherDto>(await _groupService.GetGroupTeacher(groupId));
        }
    }
}
