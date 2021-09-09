using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingCenterCRM.Models
{
    public class MaterialModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Material type")]
        public int? MaterialType { get; set; }

        public List<FileModel> Files { get; set; }

        [Required]
        [Display(Name = "Group")]
        public int GroupId { get; set; }
        public GroupModel Group { get; set; }
    }
}
