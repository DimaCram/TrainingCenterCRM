using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingCenterCRM.Api.Dto
{
    public class StudentDto : UserDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public bool HasGroup { get; set; }
        public int? GroupId { get; set; }
    }
}
