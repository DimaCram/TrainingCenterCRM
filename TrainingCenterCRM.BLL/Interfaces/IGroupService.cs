﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TrainingCenterCRM.BLL.Models;

namespace TrainingCenterCRM.BLL.Interfaces
{
    public interface IGroupService
    {
        Task AddGroupAsync(Group group, List<int> studentsId);
        Task EditGroupAsync(Group group, List<int> studentsId);
        Task DeleteGroupAsync(int id);
        Task<Group> GetGroupAsync(int id);
        Task<List<Group>> GetGroupsAsync();
        Task<IEnumerable<Student>> GetStudentsWithGroupAsync(int groupId, int courseId);
    }
}
