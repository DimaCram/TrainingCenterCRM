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
    public class StudentRequestsController : ControllerBase
    {
        private readonly IMapper _mapper;

        private readonly IStudentRequestService studentRequestService;
        private readonly IStudentService studentService;
        private readonly ICourseService courseService;
        private readonly IGroupService groupService;

        public StudentRequestsController(IMapper mapper,
                                         IStudentRequestService studentRequestService,
                                         IStudentService studentService,
                                         ICourseService courseService,
                                         IGroupService groupService)
        {
            _mapper = mapper;

            this.studentRequestService = studentRequestService;
            this.studentService = studentService;
            this.courseService = courseService;
            this.groupService = groupService;
        }

        [HttpGet]
        public async Task<IEnumerable<StudentRequestDto>> GetStudentsAsync()
        {
            var requests = await studentRequestService.GetRequestsAsync();
            return _mapper.Map<IEnumerable<StudentRequestDto>>(requests);
        }

        [HttpGet("{id}")]
        public async Task<StudentDto> GetStudentAsync(int id)
        {
            
            return _mapper.Map<StudentDto>(await studentService.GetStudentAsync(id));
        }

        [HttpPost]
        public async Task EditStudentAsync(StudentDto studentDto)
        {
            var request = _mapper.Map<StudentRequest>(studentDto);

            if (studentDto.Id == 0)
                await studentRequestService.AddRequestAsync(request);
            else
                await studentRequestService.EditRequestAsync(request);
        }

        [HttpDelete("{id}")]
        public async Task DeleteStudentAsync(int id)
        {
            await studentRequestService.DeleteRequestAsync(id);
        }

        [HttpGet("GetStudentsForGroupByCourse")]
        public async Task<List<StudentDto>> GetStudentsByCourseAsync(int courseId, int groupId)
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

            return students;
        }
    }
}
