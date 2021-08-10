using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingCenterCRM.Models
{
    public class TopicModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public List<CourseModel> Courses { get; set; } = new List<CourseModel>();
    }
}
