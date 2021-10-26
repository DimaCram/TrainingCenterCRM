using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingCenterCRM.BLL.Interfaces;
using TrainingCenterCRM.Core.Models;
using TrainingCenterCRM.DAL.EF.Interfaces;

namespace TrainingCenterCRM.BLL.Services
{
    public class StudentToGroupAssignmentService : IStudentToGroupAssignmentService
    {
        private readonly IRepository<StudentToGroupAssignment> repository;

        public StudentToGroupAssignmentService(IRepository<StudentToGroupAssignment> repository)
        {
            this.repository = repository;
        }
        public async Task AddAssignmentAsync(StudentToGroupAssignment assignment)
        {
            if (assignment == null)
                throw new ArgumentException();

            await repository.Create(assignment);
        }

        public async Task DeleteAssignmentAsync(int id)
        {
            await repository.Delete(id);
        }

        public async Task EditAssignmentAsync(StudentToGroupAssignment assignment)
        {
            if (assignment == null)
                throw new ArgumentException();

            await repository.Update(assignment);
        }

        public Task<StudentToGroupAssignment> GetAssignmentAsync(int id)
        {
            return repository.Get(id);
        }

        public async Task<StudentToGroupAssignment> GetAssignmentByStudentAsync(int studentId)
        {
            var assignments = await repository.GetAll();
            return assignments.FirstOrDefault(a => a.StudentId == studentId);
        }

        public Task<List<StudentToGroupAssignment>> GetAssignmentsAsync()
        {
            return repository.GetAll();
        }

        public async Task<IEnumerable<StudentToGroupAssignment>> GetAssignmentsByGroupAsync(int groupId)
        {
            var assignments = await repository.GetAll();
            return assignments.Where(stg => stg.GroupId == groupId);
        }
    }
}
