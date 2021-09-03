using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingCenterCRM.Models
{
    public class MaterialModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? MaterialType { get; set; }

        public List<FileModel> Files { get; set; }

        public int GroupId { get; set; }
        public GroupModel Group { get; set; }
    }
}
