using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TrainingCenterCRM.Core.Filters;
using TrainingCenterCRM.Core.Models;

namespace TrainingCenterCRM.DAL.EF.Interfaces
{
    public interface IFileRepository : IRepository<File>
    {
        Task<IEnumerable<File>> GetAllByPagination(PaginationFilter pagination);
    }
}
