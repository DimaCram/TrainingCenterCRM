using System.Collections.Generic;
using System.Threading.Tasks;
using TrainingCenterCRM.Core.Models;

namespace TrainingCenterCRM.DAL.EF.Interfaces
{
    public interface IStudentMarkRepository: IRepository<StudentMark>
    {
        Task<IEnumerable<StudentMark>> GetMarksByGroup(int groupId);
        Task<IEnumerable<StudentMark>> GetMarksForStudentByGroup(int studentId, int groupId);
    }
}
