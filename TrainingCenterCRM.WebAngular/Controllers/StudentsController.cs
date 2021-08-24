using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingCenterCRM.BLL.Interfaces;
using TrainingCenterCRM.BLL.Models;
using TrainingCenterCRM.WebAngular.Dto;

namespace TrainingCenterCRM.WebAngular.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService studentService;

        private readonly IMapper mapper;

        public StudentsController(IStudentService studentService, IMapper mapper)
        {
            this.studentService = studentService;

            this.mapper = mapper;
        }

        [HttpGet]
        public List<StudentDto> GetStudents()
        {
            return mapper.Map<List<StudentDto>>(studentService.GetStudents());
        }
    }
}
