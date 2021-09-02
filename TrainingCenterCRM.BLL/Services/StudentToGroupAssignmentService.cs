using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public async Task AddAssignmentAsync(StudentToGroupAssignment assignment)
        {
            if (assignment == null)
                throw new ArgumentException();

            await repository.CreateAsync(assignment);
        }

        public async Task DeleteAssignmentAsync(int id)
        {
            await repository.DeleteAsync(id);
        }

        public async Task EditAssignmentAsync(StudentToGroupAssignment assignment)
        {
            if (assignment == null)
                throw new ArgumentException();

            await repository.UpdateAsync(assignment);
        }

        public Task<StudentToGroupAssignment> GetAssignmentAsync(int id)
        {
            return repository.GetAsync(id);
        }

        public async Task<StudentToGroupAssignment> GetAssignmentByStudentAsync(int studentId)
        {
            var assignments = await repository.GetAllAsync();
            return assignments.FirstOrDefault(a => a.StudentId == studentId);
        }

        public Task<List<StudentToGroupAssignment>> GetAssignmentsAsync()
        {
            return repository.GetAllAsync();
        }

        public async Task<IEnumerable<StudentToGroupAssignment>> GetAssignmentsByGroupAsync(int groupId)
        {
            var assignments = await repository.GetAllAsync();
            return assignments.Where(stg => stg.GroupId == groupId);
        }
    }
}
