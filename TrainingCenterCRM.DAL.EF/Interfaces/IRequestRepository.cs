using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TrainingCenterCRM.Core.Models;

namespace TrainingCenterCRM.DAL.EF.Interfaces
{
    public interface IRequestRepository : IRepository<StudentRequest>
    {
        Task UpdateRange(IEnumerable<StudentRequest> requests);
    }
}
