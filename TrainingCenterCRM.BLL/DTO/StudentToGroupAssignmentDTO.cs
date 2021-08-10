using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingCenterCRM.BLL.DTO
{
    public class StudentToGroupAssignmentDTO
    {
        public int StudentId { get; set; }
        public StudentDTO Student { get; set; }
        public int GroupId { get; set; }
        public GroupDTO Group { get; set; }
        public DateTime AssignmentDate { get; set; }
        public ResultTypeDTO Result { get; set; }
    }
}
