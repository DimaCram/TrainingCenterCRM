using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingCenterCRM.BLL.DTO;
using TrainingCenterCRM.BLL.Interfaces;
using TrainingCenterCRM.DAL.Enttities;

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
        public IEnumerable<Teacher> GetTeachers()
        {
            return teacherService.GetTeachers();
        }

        [HttpGet("{id}")]
        public TeacherDTO GetTeacher(int id)
        {
            return teacherService.GetTeacher(id);
        }

        [HttpPost]
        public IActionResult AddTeacher(TeacherDTO teacher)
        {
            if(teacher.Id != 0)
                return BadRequest();

            teacherService.AddTeacher(teacher);

            return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult EditTeacher(int id, TeacherDTO teacher)
        {
            if (id != teacher.Id)
                return BadRequest();

            teacherService.EditTeacher(teacher);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public void DeleteTeacher(int id)
        {
            teacherService.DeleteTeacher(id);
        }
    }
}
