using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingCenterCRM.BLL.Models
{
    public class User : IdentityUser
    {
        public Teacher Teacher { get; set; }
        public Student Student { get; set; }
        public Manager Manager { get; set; }
    }
}
