using System;
using System.Collections.Generic;
using System.Text;
using TrainingCenterCRM.Core.Filters;
using TrainingCenterCRM.Core.Models;

namespace TrainingCenterCRM.DAL.EF.Interfaces
{
    public interface ICourseRepository : IRepository<Course>
    {
        IEnumerable<Course> Filter(CourseFilter filter);
    }
}
