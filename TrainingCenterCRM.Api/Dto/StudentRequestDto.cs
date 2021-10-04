using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingCenterCRM.Api.Dto
{
    public class StudentRequestDto
    {
        public int Id { get; set; }
        public DateTime ReadyToStartDate { get; set; }
        public string Comments { get; set; }
        public string Status { get; set; }
        public int CourseId { get; set; }
        public CourseDto Course { get; set; }
        public int StudentId { get; set; }
        public StudentDto Student { get; set; }
    }
}
