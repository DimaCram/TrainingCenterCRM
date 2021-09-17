using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingCenterCRM.Api.Dto;
using TrainingCenterCRM.BLL.Interfaces;

namespace TrainingCenterCRM.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IMapper _mapper;

        private readonly IStudentService _studentService;

        public StudentsController(IMapper mapper, IStudentService studentService)
        {
            _mapper = mapper;
            _studentService = studentService;
        }

        [HttpGet]
        public async Task<IEnumerable<StudentDto>> GetAsync()
        {
            return _mapper.Map<IEnumerable<StudentDto>>(await _studentService.GetStudentsAsync());
        }
    }
}
