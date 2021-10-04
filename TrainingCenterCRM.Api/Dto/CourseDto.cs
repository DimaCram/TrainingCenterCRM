using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingCenterCRM.Api.Dto
{
    public class CourseDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string PathToIcon { get; set; }
        public int TopicId { get; set; }
        public IFormFile File { get; set; }
    }
}
