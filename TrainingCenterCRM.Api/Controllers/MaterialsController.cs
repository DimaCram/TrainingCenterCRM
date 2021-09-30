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
    public class MaterialsController : ControllerBase
    {
        private readonly IMapper _mapper;

        private readonly IMaterialService _materialService;
        private readonly IFileService _fileService;

        public MaterialsController(IMapper mapper,
                                   IMaterialService materialService,
                                   IFileService fileService)
        {
            _mapper = mapper;
            _materialService = materialService;
            _fileService = fileService;
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

        [HttpGet("groups")]
        public async Task DeleteCourseAsync(int groupId, int materialId)
        {
            var filesForGroup = _mapper.Map<List<FileDto>>(await _fileService.GetFilesByGroupAsync(groupId));

            if (materialId != 0)
            {
                var material = await _materialService.GetMaterialAsync(materialId);
                var selectedFiles = _mapper.Map<List<FileDto>>(material.Files);

                foreach (var selectedFile in selectedFiles)
                {
                    var file = filesForGroup.FirstOrDefault(f => f.Id == selectedFile.Id);
                    if (file == null)
                        filesForGroup.Add(selectedFile);
                    else
                        filesForGroup.FirstOrDefault(grf => grf.Id == file.Id).HasMaterial = true;
                }
            }
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
                var material = await _materialService.GetMaterialAsync(materialId);
                var selectedFiles = _mapper.Map<List<FileDto>>(material.Files);

                foreach (var selectedFile in selectedFiles)
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
    }
}
