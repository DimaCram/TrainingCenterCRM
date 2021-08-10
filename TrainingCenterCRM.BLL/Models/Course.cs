using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingCenterCRM.BLL.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public int TopicId { get; set; }
        public Topic Topic { get; set; }

        public List<Group> Groups { get; set; } = new List<Group>();
    }
}
