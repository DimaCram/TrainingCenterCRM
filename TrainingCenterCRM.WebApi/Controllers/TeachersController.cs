using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingCenterCRM.BLL.Interfaces;
using TrainingCenterCRM.BLL.Models;

namespace TrainingCenterCRM.WebApi.Controllers
{
    [Route("api/teachers")]
    [ApiController]
    public class TeachersController : ControllerBase
    {
        private readonly ITeacherService teacherService;

        public TeachersController(ITeacherService teacherService)
        {
            this.teacherService = teacherService;
        }
        [HttpGet]
        public async Task<IEnumerable<Teacher>> GetTeachersAsync()
        {
            return await teacherService.GetTeachersAsync();
        }

        [HttpGet("{id}")]
        public async Task<Teacher> GetTeacherAsync(int id)
        {
            return await teacherService.GetTeacherAsync(id);
        }

        [HttpPost]
        public IActionResult AddTeacher(Teacher teacher)
        {
            if(teacher.Id != 0)
                return BadRequest();

            teacherService.AddTeacherAsync(teacher);

            return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult EditTeacher(int id, Teacher teacher)
        {
            if (id != teacher.Id)
                return BadRequest();

            teacherService.EditTeacherAsync(teacher);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public void DeleteTeacher(int id)
        {
            teacherService.DeleteTeacherAsync(id);
        }
    }
}
