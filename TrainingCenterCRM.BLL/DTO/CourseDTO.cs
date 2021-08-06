using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingCenterCRM.BLL.DTO
{
    public class CourseDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public int TopicId { get; set; }
        public TopicDTO Topic { get; set; }

        public List<GroupDTO> Groups { get; set; } = new List<GroupDTO>();
    }
}
