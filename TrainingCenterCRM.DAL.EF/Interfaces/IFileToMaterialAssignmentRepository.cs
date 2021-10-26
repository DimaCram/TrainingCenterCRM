using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TrainingCenterCRM.Core.Models;

namespace TrainingCenterCRM.DAL.EF.Interfaces
{
    public interface IFileToMaterialAssignmentRepository : IRepository<FileToMaterialAssignment>
    {
        Task DeleteRange(IEnumerable<int> ids);
    }
}
