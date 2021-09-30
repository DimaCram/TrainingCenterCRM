using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingCenterCRM.Api.Dto
{
    public class MaterialDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string MaterialType { get; set; }
        public List<FileDto> Files { get; set; }
        public int GroupId { get; set; }
        public GroupDto Group { get; set; }
    }
}
