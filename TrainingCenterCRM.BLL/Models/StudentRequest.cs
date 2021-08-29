using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingCenterCRM.BLL.Models
{
    public class StudentRequest
    {
        public int Id { get; set; }
        public DateTime ReadyToStartDate { get; set; }
        public string Comments { get; set; }
        public RequestStatus RequestStatus { get; set; }

        public int CourseId { get; set; }
        public Course  Course { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
