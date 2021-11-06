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
using TrainingCenterCRM.Core.Enums;
using TrainingCenterCRM.Core.Filters;
using TrainingCenterCRM.Core.Models;

namespace TrainingCenterCRM.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaterialsController : ControllerBase
    {
        private readonly IMapper _mapper;

        private readonly IMaterialService _materialService;
        private readonly IFileService _fileService;
        private readonly IFileToMaterialAssignmentService _materialAssignmentService;

        public MaterialsController(IMapper mapper,
                                   IMaterialService materialService,
                                   IFileService fileService,
                                   IFileToMaterialAssignmentService materialAssignmentService)
        {
            _mapper = mapper;
            _materialService = materialService;
            _fileService = fileService;
            _materialAssignmentService = materialAssignmentService;
        }

        [Authorize(Roles = "teacher, student")]
        [HttpGet]
        public async Task<IEnumerable<MaterialDto>> GetMaterialsAsync()
        {
            return _mapper.Map<IEnumerable<MaterialDto>>(await _materialService.GetMaterialsAsync());
        }

        [Authorize(Roles = "teacher, student")]
        [HttpGet("pagination")]
        public async Task<IEnumerable<MaterialDto>> GetMaterialsByPaginationAsync([FromQuery] PaginationDto pagination)
        {
            var paginationFilter = _mapper.Map<PaginationFilter>(pagination);
            var materials = await _materialService.GetMaterialsByPaginationAsync(paginationFilter);

            return _mapper.Map<IEnumerable<MaterialDto>>(materials);
        }

        [Authorize(Roles = "teacher, student")]
        [HttpGet("{id}")]
        public async Task<MaterialDto> GetMaterialAsync(int id)
        {
            return _mapper.Map<MaterialDto>(await _materialService.GetMaterialAsync(id));
        }

        [Authorize(Roles = "teacher")]
        [HttpPost]
        public async Task EditMaterialAsync(MaterialDto materialDto)
        {
            var material = _mapper.Map<Material>(materialDto);

            if (material.Id == 0)
                await _materialService.AddMaterialAsync(material, materialDto.Files.Select(f => f.Id).ToList());
            else
                await _materialService.EditMaterialAsync(material, materialDto.Files.Select(f => f.Id).ToList());
        }

        [Authorize(Roles = "teacher")]
        [HttpDelete("{id}")]
        public async Task DeleteMaterialAsync(int id)
        {
            await _materialService.DeleteMaterialAsync(id);
        }

        [Authorize(Roles = "teacher")]
        [HttpPost("addFile")]
        public async Task AddFile([FromForm] List<IFormFile> files, [FromForm] int courseId)
        {
            await _fileService.AddFilesAsync(files, courseId);
        }

        [Authorize(Roles = "teacher, student")]
        [HttpGet("types")]
        public List<string> GetMaterialTypes()
        {
            return Enum.GetNames(typeof(WorkingType)).ToList();
        }

        [Authorize(Roles = "teacher")]
        [HttpGet("filesForGroup")]
        public async Task<IEnumerable<FileDto>> GetFilesByCourse(int courseId, int materialId)
        {
            var filesForCourse = _mapper.Map<List<FileDto>>(await _fileService.GetFilesByCourseAsync(courseId));

            if (materialId != 0)
            {
                var materialFiles = _mapper.Map<List<FileDto>>(await _materialAssignmentService.GetFilesByMaterial(materialId));

                foreach (var selectedFile in materialFiles)
                {
                    var file = filesForCourse.FirstOrDefault(f => f.Id == selectedFile.Id);
                    if (file == null)
                        filesForCourse.Add(selectedFile);
                    else
                        filesForCourse.FirstOrDefault(grf => grf.Id == file.Id).HasMaterial = true;
                }
            }
            return filesForCourse;
        }

        [Authorize(Roles = "teacher, student")]
        [HttpGet("groupMaterials")]
        public async Task<IEnumerable<MaterialDto>> GetMaterialsByGroupAsync(int groupId)
        {
            var res = _mapper.Map<IEnumerable<MaterialDto>>(await _materialService.GetMaterialsByGroupAsync(groupId));
            return res;
        }

        [Authorize(Roles = "teacher, student")]
        [HttpGet("downloadFile")]
        public async Task<IActionResult> DownloadMaterialFile(int fileId)
        {
            var file = await _fileService.GetFileAsync(fileId);
            return File(file.Data, file.FileType, file.Name);
        }
    }
}
