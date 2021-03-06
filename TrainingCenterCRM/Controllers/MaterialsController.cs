using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TrainingCenterCRM.BLL.Interfaces;
using TrainingCenterCRM.Core.Models;
using TrainingCenterCRM.Models;

namespace TrainingCenterCRM.Controllers
{
    [Authorize(Roles = "manager")]
    public class MaterialsController : Controller
    {

        private readonly IMaterialService materialService;
        private readonly IGroupService groupService;
        private readonly ICourseService courseService;
        private readonly IFileService fileService;

        private readonly IMapper mapper;
        private readonly ILogger logger;
        public MaterialsController(IMapper mapper,
                                   ILogger<MaterialsController> logger,
                                   IMaterialService materialService,
                                   IGroupService groupService,
                                   ICourseService courseService,
                                   IFileService fileService)
        {
            this.materialService = materialService;
            this.groupService = groupService;
            this.mapper = mapper;
            this.logger = logger;
            this.courseService = courseService;
            this.fileService = fileService;
        }


        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var materials = await materialService.GetMaterialsAsync();
            return View(materials);
        }

        [HttpGet]
        public async Task<IActionResult> EditMaterialAsync(int? id)
        {

            var materialModel = id.HasValue ?
                mapper.Map<MaterialModel>(await materialService.GetMaterialAsync(id.Value)) :
                new MaterialModel();

            ViewBag.Groups = await groupService.GetGroupsAsync();
            return View(materialModel);
        }

        [HttpPost]
        public async Task<IActionResult> EditMaterial(MaterialModel model, List<int> fileIds)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var material = mapper.Map<Material>(model);

                    if (material.Id == 0)
                        await materialService.AddMaterialAsync(material, fileIds);
                    else
                        await materialService.EditMaterialAsync(material, fileIds);

                    return RedirectToAction("Index");
                }
                return View(model);
            }
            catch (Exception ex)
            {
                logger.LogError(ex.ToString());
                return StatusCode(500);
            }
        }
        public async Task<IActionResult> DeleteMaterial(int id)
        {
            await materialService.DeleteMaterialAsync(id);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public async Task<ActionResult> AddFileAsync()
        {
            ViewBag.Courses = await courseService.GetCoursesAsync();
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> AddFile(FileModel model)
        {
            if (ModelState.IsValid)
            {
                await fileService.AddFilesAsync(model.Files, model.CourseId.Value);
            }

            ViewBag.Courses = await courseService.GetCoursesAsync();
            return View(model);
        }

        public async Task<JsonResult> GetFilesByGroup(int groupId, int materialId)
        {
            try
            {
                var filesForGroup = mapper.Map<List<FileModel>>(await fileService.GetFilesByGroupAsync(groupId));
                
                if (materialId != 0)
                {
                    var material = await materialService.GetMaterialAsync(materialId);
                    /*var selectedFiles = mapper.Map<List<FileModel>>(material.Files);

                    foreach(var selectedFile in selectedFiles)
                    {
                        var file = filesForGroup.FirstOrDefault(f => f.Id == selectedFile.Id);
                        if (file == null)
                            filesForGroup.Add(selectedFile);
                        else
                            filesForGroup.FirstOrDefault(grf => grf.Id == file.Id).HasMaterial = true;
                    }*/
                }

                return Json(filesForGroup);
            }
            catch(Exception ex)
            {
                logger.LogError(ex.ToString());
                return null;
            }
        }
    }
}
