using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingCenterCRM.BLL.Interfaces;
using TrainingCenterCRM.BLL.Models;
using TrainingCenterCRM.DAL.Interfaces;

namespace TrainingCenterCRM.BLL.Services
{
    public class MaterialService : IMaterialService
    {
        private readonly IRepository<Material> repository;
        private readonly IFileService fileService;

        public MaterialService(IRepository<Material> repository,
                               IFileService fileService)
        {
            this.repository = repository;
            this.fileService = fileService;
        }

        public async Task AddMaterialAsync(Material material, List<int> fileIds)
        {
            if (material == null)
                throw new ArgumentException();

            var allfiles = await fileService.GetFilesAsync();

            material.Files = allfiles.Where(f => fileIds.Contains(f.Id)).ToList();

            await repository.CreateAsync(material);
        }

        public async Task DeleteMaterialAsync(int id)
        {
            await repository.DeleteAsync(id);
        }

        public async Task EditMaterialAsync(Material material, List<int> fileIds)
        {
            if (material == null)
                throw new ArgumentException();

            /*
            var allfiles = await fileService.GetFilesAsync();

            var material2 = await repository.GetAsync(material.Id);
            material2.Files.RemoveAll(f => !fileIds.Contains(f.Id));
            material2.Files.AddRange(allfiles.Where(f => fileIds.Contains(f.Id) && !material2.Files.Any(mf => mf.Id == f.Id)));
            await repository.UpdateAsync(material2);*/

            //material.Files = a.Files;



            //material.Files = allfiles.Where(f => f.Materials.Any(m => m.Id == material.Id)).ToList();  //fileService.GetFilesByMaterialAsync(material.Id);
            /*            material.Files.RemoveAll(f => !fileIds.Contains(f.Id));

                        await repository.UpdateAsync(material);

                        material.Files = allfiles.Where(f => fileIds.Contains(f.Id)).ToList();

                        await repository.UpdateAsync(material);*/
        }

        public Task<Material> GetMaterialAsync(int id)
        {
            return repository.GetAsync(id);
        }

        public Task<List<Material>> GetMaterialsAsync()
        {
            return repository.GetAllAsync();
        }
    }
}
