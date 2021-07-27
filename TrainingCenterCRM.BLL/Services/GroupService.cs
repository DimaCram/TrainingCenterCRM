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
        private readonly IStudentService studentService;

        public GroupService(IUnitOfWork db, IStudentService studentService)
        {
            this.db = db;

            this.studentService = studentService;
        }
        public void AddGroup(GroupDTO groupDTO)
        {
            if (groupDTO == null)
                throw new ArgumentException();

            var group = new Group()
            {
                Id = groupDTO.Id,
                Name = groupDTO.Name,
                StartDate = groupDTO.StartDate
            };

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

            var group = new Group()
            {
                Id = groupDTO.Id,
                Name = groupDTO.Name,
                StartDate = groupDTO.StartDate
            };

            db.Groups.Update(group);
            db.Save();
        }

        public GroupDTO GetGroup(int id)
        {
            var group = db.Groups.Get(id);
            return new GroupDTO()
            {
                Id = group.Id,
                Name = group.Name,
                StartDate = group.StartDate,
                Students = studentService.GetStudents().FindAll(x => x.GroupId == id)
            };
        }

        public IEnumerable<Group> GetGroups()
        {
            return db.Groups.GetAll();
        }
    }
}
