using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingCenterCRM.Models
{
    public class FileModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FileType { get; set; }
        public byte[] Data { get; set; }
        public DateTime? CreateDate { get; set; }

        [Required(ErrorMessage = "Select minimum one file")]
        public List<IFormFile> Files { get; set; }

        [Required]
        [Display(Name = "Course")]
        public int? CourseId { get; set; }
        public CourseModel Course { get; set; }

        public List<MaterialModel> Materials { get; set; }
    }
}
