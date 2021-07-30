using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingCenterCRM.BLL.DTO
{
    public class TeacherDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Bio { get; set; }

        public GroupDTO Group { get; set; }
        public int GroupId { get; set; }
    }
}
