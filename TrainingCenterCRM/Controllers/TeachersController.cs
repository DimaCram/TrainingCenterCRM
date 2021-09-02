﻿using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingCenterCRM.BLL.Interfaces;
using TrainingCenterCRM.BLL.Models;
using TrainingCenterCRM.Models;

namespace TrainingCenterCRM.Controllers
{
    [Authorize]
    public class TeachersController : Controller
    {
        private readonly ITeacherService teacherService;

        private readonly IMapper mapper;
        private readonly ILogger logger;
        public TeachersController(IMapper mapper,
                                  ITeacherService teacherService,
                                  ILogger<TeachersController> logger)
        {
            this.mapper = mapper;
            this.logger = logger;

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
        public async Task<IActionResult> EditTeacherAsync(TeacherModel teacherModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
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
