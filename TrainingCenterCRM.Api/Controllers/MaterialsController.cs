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
using TrainingCenterCRM.Core.Models;

namespace TrainingCenterCRM.Api.Controllers
{
    [Authorize(Roles = "teacher")]
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

        [HttpGet]
        public async Task<IEnumerable<MaterialDto>> GetAsync()
        {
            return _mapper.Map<IEnumerable<MaterialDto>>(await _materialService.GetMaterialsAsync());
        }

        [HttpGet("{id}")]
        public async Task<MaterialDto> GetAsync(int id)
        {
            return _mapper.Map<MaterialDto>(await _materialService.GetMaterialAsync(id));
        }

        [HttpPost]
        public async Task EditCourseAsync(MaterialDto materialDto)
        {
            var material = _mapper.Map<Material>(materialDto);

            if (material.Id == 0)
                await _materialService.AddMaterialAsync(material, materialDto.Files.Select(f => f.Id).ToList());
            else
                await _materialService.EditMaterialAsync(material, materialDto.Files.Select(f => f.Id).ToList());
        }

        [HttpDelete("{id}")]
        public async Task DeleteCourseAsync(int id)
        {
            await _materialService.DeleteMaterialAsync(id);
        }

        [HttpPost("addFile")]
        public async Task AddFile([FromForm] List<IFormFile> files, [FromForm] int courseId)
        {
            await _fileService.AddFilesAsync(files, courseId);
        }

        [HttpGet("types")]
        public List<string> GetMaterialTypes()
        {
            return Enum.GetNames(typeof(WorkingType)).ToList();
        }

        [HttpGet("filesForGroup")]
        public async Task<IEnumerable<FileDto>> GetFilesByGroup(int groupId, int materialId)
        {
            var filesForGroup = _mapper.Map<List<FileDto>>(await _fileService.GetFilesByGroupAsync(groupId));

            if (materialId != 0)
            {
                var materialFiles = _mapper.Map<List<FileDto>>(_materialAssignmentService.GetFilesByMaterial(materialId));

                foreach (var selectedFile in materialFiles)
                {
                    var file = filesForGroup.FirstOrDefault(f => f.Id == selectedFile.Id);
                    if (file == null)
                        filesForGroup.Add(selectedFile);
                    else
                        filesForGroup.FirstOrDefault(grf => grf.Id == file.Id).HasMaterial = true;
                }
            }
            return filesForGroup;
        }

        [HttpGet("groupMaterials")]
        public IEnumerable<MaterialDto> GetMaterialsByGroup(int groupId)
        {
            return _mapper.Map<IEnumerable<MaterialDto>>(_materialService.GetMaterialsByGroup(groupId));
        }
    }
}
