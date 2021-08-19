using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingCenterCRM.Models
{
    public class StudentRequestModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Ready to start")]
        public DateTime ReadyToStartDate { get; set; }
        
        [Display(Name = "Comment")]
        public string Comments { get; set; }

        [Required]
        [Display(Name = "Course")]
        public int CourseId { get; set; }
        public CourseModel Course { get; set; }

        [Required]
        [Display(Name = "Student")]
        public int StudentId { get; set; }
        public StudentModel Student { get; set; }
    }
}
