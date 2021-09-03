using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TrainingCenterCRM.BLL.Interfaces;
using TrainingCenterCRM.BLL.Models;
using TrainingCenterCRM.Models;

namespace TrainingCenterCRM.Controllers
{
    public class MaterialsController : Controller
    {

        private readonly IMaterialService materialService;
        private readonly IGroupService groupService;

        private readonly IMapper mapper;
        private readonly ILogger logger;
        public MaterialsController(IMapper mapper,
                                   ILogger<MaterialsController> logger,
                                   IMaterialService materialService,
                                   IGroupService groupService)
        {
            this.materialService = materialService;
            this.groupService = groupService;
            this.mapper = mapper;
            this.logger = logger;
        }


        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var materials = await materialService.GetMaterialsAsync();
            return View(materials);
        }

        [HttpGet]
        public async Task<IActionResult> EditMaterialAsync()
        {
            ViewBag.Groups = await groupService.GetGroupsAsync();
            return View(new MaterialModel());
        }

        [HttpPost]
        public async Task<IActionResult> EditMaterial(MaterialModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var material = mapper.Map<Material>(model);

                    if (material.Id == 0)
                        await materialService.AddMaterialAsync(material);
                    else
                        await materialService.EditMaterialAsync(material);

                    return RedirectToAction("Materials");
                }
                return View(model);
            }
            catch (Exception ex)
            {
                logger.LogError(ex.ToString());
                return StatusCode(500);
            }
        }

        [HttpGet]
        public ActionResult AddFile()
        {
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> AddFile(List<IFormFile> files)
        {
            long size = files.Sum(f => f.Length);

            foreach (var formFile in files)
            {
                if (formFile.Length > 0)
                {
                    var filePath = Path.GetTempFileName();

                    using (var stream = System.IO.File.Create(filePath))
                    {
                        await formFile.CopyToAsync(stream);
                    }
                }
            }

            // Process uploaded files
            // Don't rely on or trust the FileName property without validation.

            return Ok(new { count = files.Count, size });
        }
    }
}
