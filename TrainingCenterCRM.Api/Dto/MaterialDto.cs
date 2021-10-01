using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingCenterCRM.Api.Dto
{
    public class MaterialDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string MaterialType { get; set; }
        public List<FileDto> Files { get; set; }

        [Required]
        public int GroupId { get; set; }
        public GroupDto Group { get; set; }
    }
}
