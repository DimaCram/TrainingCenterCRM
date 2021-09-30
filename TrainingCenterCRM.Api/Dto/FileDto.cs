using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingCenterCRM.Api.Dto
{
    public class FileDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FileType { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool HasMaterial { get; set; }

        public int? CourseId { get; set; }
        public CourseDto Course { get; set; }
    }
}
