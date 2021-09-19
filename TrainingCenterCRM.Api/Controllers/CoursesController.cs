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
    public class CoursesController : ControllerBase
    {
        private readonly IMapper _mapper;

        private readonly ICourseService _courseService;

        public CoursesController(IMapper mapper, ICourseService courseService)
        {
            _mapper = mapper;
            _courseService = courseService;
        }

        [HttpGet]
        public async Task<IEnumerable<CourseDto>> GetAsync()
        {
            return _mapper.Map<IEnumerable<CourseDto>>(await _courseService.GetCoursesAsync());
        }

        [HttpGet("{id}")]
        public async Task<CourseDto> GetAsync(int id)
        {
            return _mapper.Map<CourseDto>(await _courseService.GetCourseAsync(id));
        }

        [HttpPost]
        public async Task EditCourseAsync(CourseDto courseDto)
        {
            var course = _mapper.Map<Course>(courseDto);

            if (course.Id == 0)
                await _courseService.AddCourseAsync(course);
            else
                await _courseService.EditCourseAsync(course);
        }

        [HttpDelete("{id}")]
        public async Task DeleteCourseAsync(int id)
        {
            await _courseService.DeleteCourseAsync(id);
        }
    }
}