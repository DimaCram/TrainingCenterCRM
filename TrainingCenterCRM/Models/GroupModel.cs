using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingCenterCRM.Models
{
    public class GroupModel
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(maximumLength: 100, MinimumLength = 3, ErrorMessage = "Length must be 3-100")]
        public string Name { get; set; }
        
        [Required]
        [Display(Name = "Start date")]
        public DateTime StartDate { get; set; }
        
        public List<StudentModel> Students { get; set; } = new List<StudentModel>();

        [Display(Name = "Teacher")]
        public int TeacherId { get; set; }


        [Required]
        public int CourseId { get; set; }
        public CourseModel Course { get; set; }
    }
}
