using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingCenterCRM.Core.Models
{
    public class CourseReview
    {
        public int Id { get; set; }
        public double Rating { get; set; }
        public string Comment { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }

        public int? StudentId { get; set; }
        public Student Student { get; set; }
    }
}
