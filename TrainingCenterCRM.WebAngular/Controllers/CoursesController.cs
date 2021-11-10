using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingCenterCRM.BLL.Interfaces;
using TrainingCenterCRM.Core.Enums;
using TrainingCenterCRM.Core.Filters;
using TrainingCenterCRM.WebAngular.Dto;

namespace TrainingCenterCRM.WebAngular.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly ICourseService _courseService;

        private readonly IMapper _mapper;

        public CoursesController(ICourseService courseService, IMapper mapper)
        {
            this._courseService = courseService;
            this._mapper = mapper;
        }

        [HttpGet]   
        public async Task<List<CourseDto>> GetCoursesAsync()
        {
            return _mapper.Map<List<CourseDto>>(await _courseService.GetCoursesAsync());
        }
        [HttpGet("filter")]
        public async Task<IEnumerable<CourseDto>> FilterAsync([FromQuery] CourseFilterDto filter)
        {
            var courses = await _courseService.Filter(_mapper.Map<CourseFilter>(filter));

            return _mapper.Map<IEnumerable<CourseDto>>(courses);
        }
        [HttpGet("search")]
        public async Task<IEnumerable<CourseDto>> SearchAsync(string search)
        {
            var courses = await _courseService.Search(search);

            return _mapper.Map<IEnumerable<CourseDto>>(courses);
        }

        [HttpGet("levels")]
        public List<string> GetCourseLevels()
        {
            return Enum.GetNames(typeof(CourseLevel)).ToList();
        }
    }
}
