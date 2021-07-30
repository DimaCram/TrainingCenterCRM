using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingCenterCRM.DAL.Enttities
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Bio { get; set; }

        public Group Group { get; set; }
        public int GroupId { get; set; }
    }
}
