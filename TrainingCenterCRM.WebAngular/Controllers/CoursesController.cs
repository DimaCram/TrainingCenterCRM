using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingCenterCRM.BLL.Interfaces;
using TrainingCenterCRM.WebAngular.Dto;

namespace TrainingCenterCRM.WebAngular.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly ICourseService courseService;

        private readonly IMapper mapper;

        public CoursesController(ICourseService courseService, IMapper mapper)
        {
            this.courseService = courseService;
            this.mapper = mapper;
        }

        [HttpGet]   
        public async Task<List<CourseDto>> GetCoursesAsync()
        {
            return mapper.Map<List<CourseDto>>(await courseService.GetCoursesAsync());
        }
    }
}
