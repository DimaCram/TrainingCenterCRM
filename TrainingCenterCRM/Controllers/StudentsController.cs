using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingCenterCRM.BLL.Interfaces;
using TrainingCenterCRM.BLL.Models;
using TrainingCenterCRM.BLL.Services;
using TrainingCenterCRM.Models;

namespace TrainingCenterCRM.Controllers
{
    [Authorize]
    public class StudentsController : Controller
    {
        private readonly IStudentService studentService;
        private readonly IGroupService groupService;

        private readonly IMapper mapper;
        private readonly ILogger logger;
        public StudentsController(IMapper mapper,
                                  IGroupService groupService,
                                  IStudentService studentService,
                                  ILogger<StudentsController> logger)
        {
            this.mapper = mapper;
            this.logger = logger;

            this.studentService = studentService;
            this.groupService = groupService;
        }

        public async Task<IActionResult> IndexAsync()
        {
            try
            {
                var students = await studentService.GetStudentsAsync();

                return View(students);
            }
            catch(Exception ex)
            {
                logger.LogError(ex.ToString());
                return StatusCode(500);
            }
        }

        [HttpGet]
        public async Task<IActionResult> EditStudentAsync(int? id)
        {
            try
            {
                var studentModel = id.HasValue ?
                    mapper.Map<StudentModel>(await studentService.GetStudentAsync(id.Value)) :
                    new StudentModel();

                ViewBag.Groups = await groupService.GetGroupsAsync();

                return View(studentModel);
            }
            catch(Exception ex)
            {
                logger.LogError(ex.ToString());
                return StatusCode(500);
            }
        }

        [HttpPost]
        public async Task<IActionResult> EditStudentAsync(StudentModel studentModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var student = mapper.Map<Student>(studentModel);

                    if (student.Id == 0)
                        await studentService.AddStudentAsync(student);
                    else
                        await studentService.EditStudentAsync(student);

                    return RedirectToAction("Index", "Students");
                }

                ViewBag.Groups = await groupService.GetGroupsAsync();
                return View(studentModel);
            }
            catch (Exception ex)
            {
                logger.LogError(ex.ToString());
                return StatusCode(500);
            }
        }

        [HttpGet]
        public async Task<IActionResult> DeleteStudentAsync(int id)
        {
            try
            {
                await studentService.DeleteStudentAsync(id);
                return RedirectToAction("Index", "Students");
            }
            catch (Exception ex)
            {
                logger.LogError(ex.ToString());
                return StatusCode(500);
            }
        }

        [HttpGet]
        public async Task<JsonResult> GetStudentAsync(int id)
        {
            try
            {
                var studentModel = mapper.Map<StudentModel>(await studentService.GetStudentWithGroupAsync(id));

                return Json(studentModel);
            }
            catch (Exception ex)
            {
                logger.LogError(ex.ToString());
                return null;
            }
        }
    }
}
