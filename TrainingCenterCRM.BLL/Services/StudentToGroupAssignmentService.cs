using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TrainingCenterCRM.BLL.Interfaces;
using TrainingCenterCRM.BLL.Models;
using TrainingCenterCRM.DAL.Interfaces;

namespace TrainingCenterCRM.BLL.Services
{
    public class StudentToGroupAssignmentService : IStudentToGroupAssignmentService
    {
        private readonly IRepository<StudentToGroupAssignment> repository;

        public StudentToGroupAssignmentService(IRepository<StudentToGroupAssignment> repository)
        {
            this.repository = repository;
        }
        public void AddAssignment(StudentToGroupAssignment assignment)
        {
            if (assignment == null)
                throw new ArgumentException();

            repository.Create(assignment);
        }

        public void DeleteAssignment(int id)
        {
            repository.Delete(id);
        }

        public void EditAssignment(StudentToGroupAssignment assignment)
        {
            if (assignment == null)
                throw new ArgumentException();

            repository.Update(assignment);
        }

        public StudentToGroupAssignment GetAssignment(int id)
        {
            return repository.Get(id);
        }

        public List<StudentToGroupAssignment> GetAssignments()
        {
            return repository.GetAll();
        }
    }
}
