using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingCenterCRM.BLL.Models
{
    public class StudentToGroupAssignment
    {
        public int StudentToGroupAssignmentId { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }
        public DateTime AssignmentDate { get; set; }
        public ResultType Result { get; set; }
    }
}
