using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingCenterCRM.Api.Dto;
using TrainingCenterCRM.BLL.Interfaces;
using TrainingCenterCRM.Core.Enums;
using TrainingCenterCRM.Core.Models;

namespace TrainingCenterCRM.Api.Controllers
{
    [Authorize(Roles = "manager")]
    [Route("api/[controller]")]
    [ApiController]
    public class StudentRequestsController : ControllerBase
    {
        private readonly IMapper _mapper;

        private readonly IStudentRequestService studentRequestService;
        private readonly IGroupService groupService;

        public StudentRequestsController(IMapper mapper,
                                         IStudentRequestService studentRequestService,
                                         IGroupService groupService)
        {
            _mapper = mapper;

            this.studentRequestService = studentRequestService;
            this.groupService = groupService;
        }

        [HttpGet]
        public async Task<IEnumerable<StudentRequestDto>> GetRequestsAsync()
        {
            var requests = await studentRequestService.GetRequestsAsync();
            return _mapper.Map<IEnumerable<StudentRequestDto>>(requests);
        }

        [HttpGet("{id}")]
        public async Task<StudentRequestDto> GetRequestAsync(int id)
        {
            return _mapper.Map<StudentRequestDto>(await studentRequestService.GetRequestAsync(id));
        }

        [HttpPost]
        public async Task EditRequestAsync(StudentRequestDto requestDto)
        {
            var request = _mapper.Map<StudentRequest>(requestDto);

            if (requestDto.Id == 0)
                await studentRequestService.AddRequestAsync(request);
            else
                await studentRequestService.EditRequestAsync(request);
        }

        [HttpDelete("{id}")]
        public async Task DeleteRequestAsync(int id)
        {
            await studentRequestService.DeleteRequestAsync(id);
        }

        [HttpGet("statuses")]
        public List<string> GetRequestStatuses()
        {
            return Enum.GetNames(typeof(RequestStatus)).ToList();
        }

        [HttpGet("studentsForGroupByCourse")]
        public async Task<IEnumerable<StudentDto>> GetStudentsForGroupByCourse(int courseId, int groupId)
        {
            var students = _mapper.Map<List<StudentDto>>(await studentRequestService.GetStudentsRequestedForCourseAsync(courseId));

            if (groupId != 0)
            {
                var studentsWithGroup = _mapper.Map<List<StudentDto>>(await groupService.GetStudentsWithGroupAsync(groupId, courseId));
                foreach (var studentWithGroup in studentsWithGroup)
                {
                    studentWithGroup.HasGroup = true;
                }

                students.AddRange(studentsWithGroup);
            }

            return students.OrderBy(s => s.Name);
        }
    }
}
