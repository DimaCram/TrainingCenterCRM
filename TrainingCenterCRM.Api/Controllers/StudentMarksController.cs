using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingCenterCRM.Api.Dto;
using TrainingCenterCRM.BLL.Interfaces;
using TrainingCenterCRM.Core.Models;

namespace TrainingCenterCRM.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class StudentMarksController : ControllerBase
    {
        private readonly IMapper _mapper;

        private readonly IStudentMarkService _studentMarkService;

        public StudentMarksController(IMapper mapper, IStudentMarkService studentMarkService)
        {
            _mapper = mapper;
            _studentMarkService = studentMarkService;
        }

        [HttpGet]
        public async Task<IEnumerable<StudentMarkDto>> GetMarksAsync()
        {
            return _mapper.Map<IEnumerable<StudentMarkDto>>(await _studentMarkService.GetMarksAsync());
        }

        [HttpGet("{id}")]
        public async Task<StudentMarkDto> GetMarkAsync(int id)
        {
            return _mapper.Map<StudentMarkDto>(await _studentMarkService.GetMarkAsync(id));
        }

        [HttpPost]
        public async Task EditMarkAsync(StudentMarkDto studentMarkDto)
        {
            var studentMark = _mapper.Map<StudentMark>(studentMarkDto);

            if (studentMark.Id == 0)
                await _studentMarkService.AddMarkAsync(studentMark);
            else
                await _studentMarkService.EditMarkAsync(studentMark);
        }

        [HttpDelete("{id}")]
        public async Task DeleteMarkAsync(int id)
        {
            await _studentMarkService.DeleteMarkAsync(id);
        }

        [HttpGet("groupMarks")]
        public async Task<IEnumerable<StudentMarkDto>> GetMarksByGroup(int groupId)
        {
            var marks = await _studentMarkService.GetMarksByGroup(groupId);
            return _mapper.Map<IEnumerable<StudentMarkDto>>(marks);
        }

        [HttpGet("studentAverageByGroup")]
        public async Task<double> GetStudentAverageMarkByGroup(int groupId)
        {
            var userEmail = HttpContext.User.Identity.Name;
            var averageMark = await _studentMarkService.GetStudentAverageMarkByGroup(groupId, userEmail);
            return averageMark;
        }

        [HttpGet("studentByGroup")]
        public async Task<IEnumerable<StudentMarkDto>> GetStudentMarksByGroup(int groupId)
        {
            var userEmail = HttpContext.User.Identity.Name;
            var marks = await _studentMarkService.GetStudentMarksByGroup(groupId, userEmail);
            return _mapper.Map<IEnumerable<StudentMarkDto>>(marks);
        }

    }
}
