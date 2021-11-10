﻿using System.Collections.Generic;

namespace TrainingCenterCRM.Core.Models
{
    public class Topic
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public List<Course> Courses { get; set; } = new List<Course>();
    }
}
