using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingCenterCRM.Api.Dto;
using TrainingCenterCRM.BLL.Interfaces;
using TrainingCenterCRM.BLL.Models;

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

        [HttpGet]
        public async Task<IEnumerable<GroupDto>> GetAsync()
        {
            return _mapper.Map<IEnumerable<GroupDto>>(await _groupService.GetGroupsAsync());
        }

        [HttpGet("{id}")]
        public async Task<GroupDto> GetAsync(int id)
        {
            return _mapper.Map<GroupDto>(await _groupService.GetGroupAsync(id));
        }

        [HttpPost]
        public async Task EditCourseAsync(GroupDto groupDto)
        {
            var group = _mapper.Map<Group>(groupDto);

            if (group.Id == 0)
                await _groupService.AddGroupAsync(group, groupDto.Students.Select(g => g.Id));
            else
                await _groupService.EditGroupAsync(group, groupDto.Students.Select(g => g.Id));
        }

        [HttpDelete("{id}")]
        public async Task DeleteCourseAsync(int id)
        {
            await _groupService.DeleteGroupAsync(id);
        }
    }
}
