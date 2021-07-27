using System;
using System.Collections.Generic;
using System.Text;
using TrainingCenterCRM.BLL.DTO;
using TrainingCenterCRM.DAL.Enttities;

namespace TrainingCenterCRM.BLL.Interfaces
{
    public interface IGroupService
    {
        void AddGroup(GroupDTO groupDTO);
        void EditGroup(GroupDTO groupDTO);
        void DeleteGroup(int id);
        GroupDTO GetGroup(int id);
        List<Group> GetGroups();
        void Dispose();
    }
}
