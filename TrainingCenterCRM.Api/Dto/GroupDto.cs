using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingCenterCRM.Api.Dto
{
    public class GroupDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }

        public string Status { get; set; }

        public List<StudentDto> Students { get; set; }

        public TeacherDto Teacher { get; set; }
        public int TeacherId { get; set; }

        public int CourseId { get; set; }
        public CourseDto Course { get; set; }
    }
}
