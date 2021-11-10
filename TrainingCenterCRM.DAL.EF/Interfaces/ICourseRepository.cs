using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TrainingCenterCRM.Core.Filters;
using TrainingCenterCRM.Core.Models;

namespace TrainingCenterCRM.DAL.EF.Interfaces
{
    public interface ICourseRepository : IRepository<Course>
    {
        IEnumerable<Course> Filter(CourseFilter filter);
        Task<IEnumerable<Course>> GetAllByPagination(PaginationFilter pagination);
    }
}
