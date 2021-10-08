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
    public class CoursesController : ControllerBase
    {
        private readonly IMapper _mapper;

        private readonly ICourseService _courseService;

        public CoursesController(IMapper mapper, ICourseService courseService)
        {
            _mapper = mapper;
            _courseService = courseService;
        }
        
        [AllowAnonymous]
        [HttpGet]
        public async Task<IEnumerable<CourseDto>> GetCoursesAsync()
        {
            return _mapper.Map<IEnumerable<CourseDto>>(await _courseService.GetCoursesAsync());
        }

        [AllowAnonymous]
        [HttpGet("pagination")]
        public async Task<IEnumerable<CourseDto>> GetCoursesByPaginationAsync([FromQuery] PaginationDto pagination)
        {
            var paginationFilter = _mapper.Map<PaginationFilter>(pagination);
            var courses = await _courseService.GetCoursesByPaginationAsync(paginationFilter);

            return _mapper.Map<IEnumerable<CourseDto>>(courses);
        }

        [AllowAnonymous]
        [HttpGet("{id}")]
        public async Task<CourseDto> GetCourseAsync(int id)
        {
            return _mapper.Map<CourseDto>(await _courseService.GetCourseAsync(id));
        }

        [HttpPost]
        public async Task EditCourseAsync([FromForm] CourseDto courseDto)
        {
            var course = _mapper.Map<Course>(courseDto);

            if (course.Id == 0)
                await _courseService.AddCourseAsync(course, courseDto.File);
            else
                await _courseService.EditCourseAsync(course, courseDto.File);
        }

        [HttpDelete("{id}")]
        public async Task DeleteCourseAsync(int id)
        {
            await _courseService.DeleteCourseAsync(id);
        }
    }
}
