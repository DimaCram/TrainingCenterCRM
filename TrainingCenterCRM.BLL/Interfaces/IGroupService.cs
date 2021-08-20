using System;
using System.Collections.Generic;
using System.Text;
using TrainingCenterCRM.BLL.Models;

namespace TrainingCenterCRM.BLL.Interfaces
{
    public interface IGroupService
    {
        void AddGroup(Group group, List<int> studentsId);
        void EditGroup(Group group, List<int> studentsId);
        void DeleteGroup(int id);
        Group GetGroup(int id);
        List<Group> GetGroups();
        IEnumerable<Student> GetStudentsWithGroup(int groupId, int courseId);
    }
}
