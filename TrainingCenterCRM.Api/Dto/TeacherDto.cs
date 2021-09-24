using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingCenterCRM.Api.Dto
{
    public class TeacherDto : UserDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int? Age { get; set; }
        public string Bio { get; set; }
        public string PathToIcon { get; set; }
        public IFormFile File { get; set; }
        public string UserId { get; set; }
    }
}
