using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using TrainingCenterCRM.Api.Dto;
using TrainingCenterCRM.BLL.Interfaces;
using TrainingCenterCRM.Core.Enums;
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
        private readonly ILocalFileService _localFileService;

        public CoursesController(IMapper mapper, 
                                 ICourseService courseService,
                                 ILocalFileService localFileService)
        {
            _mapper = mapper;
            _courseService = courseService;
            _localFileService = localFileService;
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

            if (courseDto.File != null)
            {
                var pathToFile = _localFileService.GetFilePath(courseDto.File.FileName, FileDestiny.Course);
                await _localFileService.AddFile(courseDto.File, pathToFile);

                course.PathToIcon = pathToFile;
            }

            if (course.Id == 0)
            {
                await _courseService.AddCourseAsync(course);
            }
            else
                await _courseService.EditCourseAsync(course);
        }

        [HttpDelete("{id}")]
        public async Task DeleteCourseAsync(int id)
        {
            var course = await _courseService.GetCourseAsync(id);
            if(!string.IsNullOrEmpty(course.PathToIcon))
                _localFileService.DeleteFile(course.PathToIcon);

            await _courseService.DeleteCourseAsync(id);
        }
    }
}
