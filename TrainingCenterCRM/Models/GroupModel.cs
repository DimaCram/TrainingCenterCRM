﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingCenterCRM.Models
{
    public class GroupModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }

        public List<StudentModel> Students { get; set; } = new List<StudentModel>();
        
        [Display(Name = "Teacher")]
        public int TeacherId { get; set; }
    }
}
