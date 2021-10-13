using System.Collections.Generic;

namespace TrainingCenterCRM.Core.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string PathToIcon { get; set; }
        public double? Price { get; set; }


        public int TopicId { get; set; }
        public Topic Topic { get; set; }

        public List<Group> Groups { get; set; } = new List<Group>();
    }
}
