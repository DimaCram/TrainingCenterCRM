using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingCenterCRM.Core.Enums;

namespace TrainingCenterCRM.WebAngular.Dto
{
    public class CourseFilterDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string TopicName { get; set; }

        public double? PriceFrom { get; set; }
        public double? PriceTo { get; set; }
        public string Level { get; set; }
    }
}
