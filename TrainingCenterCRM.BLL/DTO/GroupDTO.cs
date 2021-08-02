using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingCenterCRM.BLL.DTO
{
    public class GroupDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }

        public List<StudentDTO> Students { get; set; } = new List<StudentDTO>();
        public TeacherDTO Teacher { get; set; }
        public int TeacherId { get; set; }
    }
}
