using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TrainingCenterCRM.BLL.Interfaces;
using TrainingCenterCRM.BLL.Models;
using TrainingCenterCRM.DAL.Interfaces;

namespace TrainingCenterCRM.BLL.Services
{
    public class GroupService : IGroupService
    {
        private readonly IRepository<Group> repository;
        public GroupService(IRepository<Group> repository)
        {
            this.repository = repository;
        }
        public void AddGroup(Group group)
        {
            if (group == null)
                throw new ArgumentException();

            repository.Create(group);
        }

        public void DeleteGroup(int id)
        {
            repository.Delete(id);
        }

        public void EditGroup(Group group)
        {
            if (group == null)
                throw new ArgumentException();

            repository.Update(group);
        }

        public Group GetGroup(int id)
        {
            return repository.Get(id);
        }

        public List<Group> GetGroups()
        {
            return repository.GetAll();
        }
    }
}
