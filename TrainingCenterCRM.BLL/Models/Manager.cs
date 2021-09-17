using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingCenterCRM.BLL.Models
{
    public class Manager
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public User User { get; set; }
        public string UserId { get; set; }
    }
}
