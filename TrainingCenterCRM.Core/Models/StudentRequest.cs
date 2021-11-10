using System;
using TrainingCenterCRM.Core.Enums;

namespace TrainingCenterCRM.Core.Models
{
    public class StudentRequest
    {
        public int Id { get; set; }
        public DateTime ReadyToStartDate { get; set; }
        public string Comments { get; set; }
        public RequestStatus RequestStatus { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
