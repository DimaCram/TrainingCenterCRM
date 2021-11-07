using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TrainingCenterCRM.Core.Filters;
using TrainingCenterCRM.Core.Models;

namespace TrainingCenterCRM.DAL.EF.Interfaces
{
    public interface IGroupRepository : IRepository<Group>
    {
        Task<IEnumerable<Group>> GetAllByPagination(PaginationFilter pagination);
        Task<Group> GetFullGroupInfo(int id);
        Task<Group> GetGroupWithTeacher(int groupId);
    }
}
