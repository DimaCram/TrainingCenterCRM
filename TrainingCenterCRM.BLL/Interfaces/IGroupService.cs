using System.Collections.Generic;
using System.Threading.Tasks;
using TrainingCenterCRM.Core.Filters;
using TrainingCenterCRM.Core.Models;

namespace TrainingCenterCRM.BLL.Interfaces
{
    public interface IGroupService
    {
        Task AddGroupAsync(Group group, IEnumerable<int> studentsId);
        Task EditGroupAsync(Group group, IEnumerable<int> studentsId);
        Task DeleteGroupAsync(int id);
        Task<Group> GetGroupAsync(int id);
        Task<List<Group>> GetGroupsAsync();
        Task<IEnumerable<Group>> GetGroupsByPaginationAsync(PaginationFilter pagination);
        Task<IEnumerable<Student>> GetStudentsWithGroupAsync(int groupId, int courseId);
        Task<IEnumerable<Group>> GetTeacherGroups(string email);
        Task<IEnumerable<Group>> GetStudentGroups(string userEmail);
        Task SendInviteNotifications(int groupId);
        Task<bool> HasAccessToGroup(int groupId, string userEmail);
        Task<Teacher> GetGroupTeacher(int groupId);
    }
}
