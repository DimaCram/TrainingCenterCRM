using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingCenterCRM.Api.Dto
{
    public class StudentMarkDto
    {
        public int Id { get; set; }
        public byte Mark { get; set; }
        public string Comment { get; set; }

        public int MaterialId { get; set; }
        public MaterialDto Material { get; set; }

        public int StudentId { get; set; }
        public StudentDto Student { get; set; }
    }
}
