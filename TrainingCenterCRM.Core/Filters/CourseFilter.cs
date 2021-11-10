using System;
using System.Collections.Generic;
using System.Text;
using TrainingCenterCRM.Core.Enums;

namespace TrainingCenterCRM.Core.Filters
{
    public class CourseFilter
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string TopicName { get; set; }

        public double? PriceFrom { get; set; }
        public double? PriceTo { get; set; }
        public CourseLevel? Level { get; set; }
    }
}
