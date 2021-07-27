using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TrainingCenterCRM.BLL.DTO;
using TrainingCenterCRM.BLL.Interfaces;
using TrainingCenterCRM.DAL;
using TrainingCenterCRM.DAL.Enttities;
using TrainingCenterCRM.DAL.Interfaces;

namespace TrainingCenterCRM.BLL.Services
{
    public class GroupService : IGroupService
    {
        private readonly IUnitOfWork db;
        private readonly IMapper mapper;

        private readonly IStudentService studentService;
        public GroupService(IUnitOfWork db, IStudentService studentService, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;

            this.studentService = studentService;
        }
        public void AddGroup(GroupDTO groupDTO)
        {
            if (groupDTO == null)
                throw new ArgumentException();

            var group = mapper.Map<Group>(groupDTO);

            db.Groups.Create(group);
            db.Save();
        }

        public void DeleteGroup(int id)
        {
            db.Groups.Delete(id);
            db.Save();
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public void EditGroup(GroupDTO groupDTO)
        {
            if (groupDTO == null)
                throw new ArgumentException();

            var group = mapper.Map<Group>(groupDTO);

            db.Groups.Update(group);
            db.Save();
        }

        public GroupDTO GetGroup(int id)
        {
            var group = db.Groups.Get(id);

            return mapper.Map<GroupDTO>(group);
        }

        public List<Group> GetGroups()
        {
            return db.Groups.GetAll();
        }
    }
}
