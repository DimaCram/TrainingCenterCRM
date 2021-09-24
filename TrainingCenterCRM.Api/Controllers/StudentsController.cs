using AutoMapper;
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
    public class StudentsController : ControllerBase
    {
        private readonly IMapper _mapper;

        private readonly IStudentService _studentService;
        private readonly IUserService _userService;

        public StudentsController(IMapper mapper, IStudentService studentService, IUserService userService)
        {
            _mapper = mapper;
            _studentService = studentService;
            _userService = userService;
        }

        [HttpGet]
        public async Task<IEnumerable<StudentDto>> GetStudentsAsync()
        {
            return _mapper.Map<IEnumerable<StudentDto>>(await _studentService.GetStudentsAsync());
        }

        [HttpGet("{id}")]
        public async Task<StudentDto> GetStudentAsync(int id)
        {
            return _mapper.Map<StudentDto>(await _studentService.GetStudentAsync(id));
        }

        [HttpPost]
        public async Task EditStudentAsync(StudentDto studentDto)
        {
            var student = _mapper.Map<Student>(studentDto);

            if (student.Id == 0)
            {
                await _userService.AddUser(studentDto.Email, studentDto.Password, "student");
                
                student.UserId = await _userService.GetUserIdByEmail(studentDto.Email);
                await _studentService.AddStudentAsync(student);
            }
            else
                await _studentService.EditStudentAsync(student);
        }

        [HttpDelete("{id}")]
        public async Task DeleteStudentAsync(int id)
        {
            await _studentService.DeleteStudentAsync(id);
        }
    }
}
