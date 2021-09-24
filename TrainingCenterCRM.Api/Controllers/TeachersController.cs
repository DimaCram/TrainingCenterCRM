﻿using AutoMapper;
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

        [HttpGet]
        public async Task<IEnumerable<TeacherDto>> GetTeachersAsync()
        {
            return _mapper.Map<IEnumerable<TeacherDto>>(await _teacherService.GetTeachersAsync());
        }

        [HttpGet("{id}")]
        public async Task<TeacherDto> GetTeacherAsync(int id)
        {
            return _mapper.Map<TeacherDto>(await _teacherService.GetTeacherAsync(id));
        }

        [HttpPost]
        public async Task EditStudentAsync([FromForm] TeacherDto teacherDto)
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
        public async Task DeleteStudentAsync(int id)
        {
            await _teacherService.DeleteTeacherAsync(id);
        }
    }
}
