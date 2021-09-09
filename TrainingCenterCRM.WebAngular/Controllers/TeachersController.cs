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
    public class TeachersController : ControllerBase
    {
        private readonly ITeacherService teacherService;

        private readonly IMapper mapper;

        public TeachersController(ITeacherService teacherService, IMapper mapper)
        {
            this.teacherService = teacherService;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<List<TeacherDto>> GetCoursesAsync()
        {
            return mapper.Map<List<TeacherDto>>(await teacherService.GetTeachersAsync());
        }
    }
}
