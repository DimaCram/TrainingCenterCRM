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

        [Authorize(Roles = "manager")]
        [HttpGet]
        public async Task<IEnumerable<StudentDto>> GetStudentsAsync()
        {
            return _mapper.Map<IEnumerable<StudentDto>>(await _studentService.GetStudentsAsync());
        }

        [Authorize(Roles = "manager")]
        [HttpGet("pagination")]
        public async Task<IEnumerable<StudentDto>> GetStudentsByPaginationAsync([FromQuery] PaginationDto pagination)
        {
            var paginationFilter = _mapper.Map<PaginationFilter>(pagination);
            var students = await _studentService.GetStudentsByPaginationAsync(paginationFilter);

            return _mapper.Map<IEnumerable<StudentDto>>(students);
        }

        [Authorize(Roles = "manager")]
        [HttpGet("{id}")]
        public async Task<StudentDto> GetStudentAsync(int id)
        {
            return _mapper.Map<StudentDto>(await _studentService.GetStudentAsync(id));
        }

        [Authorize(Roles = "manager")]
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

        [Authorize(Roles = "manager")]
        [HttpDelete("{id}")]
        public async Task DeleteStudentAsync(int id)
        {
            await _studentService.DeleteStudentAsync(id);
        }

        [Authorize(Roles = "manager, teacher")]
        [HttpGet("groupStudents")]
        public IEnumerable<StudentDto> GetStudentsByGroup(int groupId)
        {
            return _mapper.Map<IEnumerable<StudentDto>>(_studentService.GetStudentsByGroup(groupId));
        }
    }
}
