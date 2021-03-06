using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingCenterCRM.WebAngular.Dto
{
    public class TopicDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int CoursesCount { get; set; }
        public List<CourseDto> Courses { get; set; }
    }
}
