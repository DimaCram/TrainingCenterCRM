using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
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
    public class TeachersController : Controller
    {
        private readonly ITeacherService teacherService;
        private readonly ILocalFileService localFileService;

        private readonly IMapper mapper;
        private readonly ILogger logger;
        public TeachersController(IMapper mapper,
                                  ITeacherService teacherService,
                                  ILogger<TeachersController> logger,
                                  ILocalFileService localFileService)
        {
            this.mapper = mapper;
            this.logger = logger;

            this.localFileService = localFileService;
            this.teacherService = teacherService;
        }

        public async Task<IActionResult> IndexAsync()
        {
            try
            {
                var teachers = await teacherService.GetTeachersAsync();

                return View(teachers);
            }
            catch (Exception ex)
            {
                logger.LogError(ex.ToString());
                return StatusCode(500);
            }
        }

        [HttpGet]
        public async Task<IActionResult> EditTeacherAsync(int? id)
        {
            try
            {
                var teacherModel = id.HasValue ?
                    mapper.Map<TeacherModel>(await teacherService.GetTeacherAsync(id.Value)) :
                    new TeacherModel();

                return View(teacherModel);
            }
            catch (Exception ex)
            {
                logger.LogError(ex.ToString());
                return StatusCode(500);
            }
        }

        [HttpPost]
        public async Task<IActionResult> EditTeacherAsync(TeacherModel teacherModel, IFormFile icon)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if(icon != null)
                    {
                        string pathToImg = @$"\assets\files\teachers\{icon.FileName}";

                        if (localFileService.FileExists(pathToImg))
                        {
                            ViewBag.Eror = $"The file {icon.FileName} exists, please change the name or select a different file";
                            return View(teacherModel);
                        }
                        await localFileService.AddFile(icon, pathToImg);
                        
                        teacherModel.PathToIcon = pathToImg;
                    }

                    var teacher = mapper.Map<Teacher>(teacherModel);

                    if (teacherModel.Id == 0)
                        await teacherService.AddTeacherAsync(teacher);
                    else
                        await teacherService.EditTeacherAsync(teacher);

                    return RedirectToAction("Index", "Teachers");
                }
                return View(teacherModel);
            }
            catch (Exception ex)
            {
                logger.LogError(ex.ToString());
                return StatusCode(500);
            }
        }

        [HttpGet]
        public async Task<IActionResult> DeleteTeacherAsync(int id)
        {
            try
            {
                await teacherService.DeleteTeacherAsync(id);
                return RedirectToAction("Index", "Teachers");
            }
            catch (Exception ex)
            {
                logger.LogError(ex.ToString());
                return StatusCode(500);
            }
        }
    }
}
