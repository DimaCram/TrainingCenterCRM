﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingCenterCRM.Models
{
    public class CourseModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public int TopicId { get; set; }
        public TopicModel Topic { get; set; }

        public List<GroupModel> Groups { get; set; } = new List<GroupModel>();
    }
}
