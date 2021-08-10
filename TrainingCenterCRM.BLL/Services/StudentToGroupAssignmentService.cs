using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TrainingCenterCRM.BLL.DTO;
using TrainingCenterCRM.BLL.Interfaces;
using TrainingCenterCRM.DAL.Enttities;
using TrainingCenterCRM.DAL.Interfaces;

namespace TrainingCenterCRM.BLL.Services
{
    public class StudentToGroupAssignmentService : IStudentToGroupAssignmentService
    {
        private readonly IUnitOfWork db;
        private readonly IMapper mapper;

        public StudentToGroupAssignmentService(IUnitOfWork db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }
        public void AddAssignment(StudentToGroupAssignmentDTO dto)
        {
            if (dto == null)
                throw new ArgumentException();

            var assignment = mapper.Map<StudentToGroupAssignment>(dto);

            db.StudentToGroupAssignments.Create(assignment);
            db.Save();
        }

        public void DeleteAssignment(int id)
        {
            db.StudentToGroupAssignments.Delete(id);
            db.Save();
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public void EditAssignment(StudentToGroupAssignmentDTO dto)
        {
            if (dto == null)
                throw new ArgumentException();

            var assignment = mapper.Map<StudentToGroupAssignment>(dto);

            db.StudentToGroupAssignments.Update(assignment);
            db.Save();
        }

        public StudentToGroupAssignmentDTO GetAssignment(int id)
        {
            var assignment = db.StudentToGroupAssignments.Get(id);

            return mapper.Map<StudentToGroupAssignmentDTO>(assignment);
        }

        public List<StudentToGroupAssignment> GetAssignments()
        {
            return db.StudentToGroupAssignments.GetAll();
        }
    }
}
