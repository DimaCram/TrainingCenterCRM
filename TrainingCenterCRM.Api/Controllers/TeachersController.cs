using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using TrainingCenterCRM.Api.Dto;
using TrainingCenterCRM.BLL.Interfaces;
using TrainingCenterCRM.Core.Filters;
using TrainingCenterCRM.Core.Models;

namespace TrainingCenterCRM.Api.Controllers
{
    [Authorize(Roles = "manager")]
    [Route("api/[controller]")]
    [ApiController]
    public class TeachersController : ControllerBase
    {
        private readonly ITeacherService _teacherService;
        private readonly IUserService _userService;

        private readonly IMapper _mapper;
        public TeachersController(IMapper mapper,
                                  ITeacherService teacherService,
                                  IUserService userService)
        {
            _mapper = mapper;

            _teacherService = teacherService;
            _userService = userService;
        }
        [AllowAnonymous]
        [HttpGet]
        public async Task<IEnumerable<TeacherDto>> GetTeachersAsync()
        {
            return _mapper.Map<IEnumerable<TeacherDto>>(await _teacherService.GetTeachersAsync());
        }

        [AllowAnonymous]
        [HttpGet("pagination")]
        public async Task<IEnumerable<TeacherDto>> GetCoursesByPaginationAsync([FromQuery] PaginationDto pagination)
        {
            var paginationFilter = _mapper.Map<PaginationFilter>(pagination);
            var teachers = await _teacherService.GetTeachersByPaginationAsync(paginationFilter);

            return _mapper.Map<IEnumerable<TeacherDto>>(teachers);
        }

        [AllowAnonymous]
        [HttpGet("{id}")]
        public async Task<TeacherDto> GetTeacherAsync(int id)
        {
            return _mapper.Map<TeacherDto>(await _teacherService.GetTeacherAsync(id));
        }

        [HttpPost]
        public async Task EditTeacherAsync([FromForm] TeacherDto teacherDto)
        {
            var teacher = _mapper.Map<Teacher>(teacherDto);

            if (teacher.Id == 0)
            {
                await _userService.AddUser(teacherDto.Email, teacherDto.Password, "student");

                teacher.UserId = await _userService.GetUserIdByEmail(teacherDto.Email);
                await _teacherService.AddTeacherAsync(teacher, teacherDto.File);
            }
            else
                await _teacherService.EditTeacherAsync(teacher, teacherDto.File);
        }

        [HttpDelete("{id}")]
        public async Task DeleteTeacherAsync(int id)
        {
            await _teacherService.DeleteTeacherAsync(id);
        }
    }
}
