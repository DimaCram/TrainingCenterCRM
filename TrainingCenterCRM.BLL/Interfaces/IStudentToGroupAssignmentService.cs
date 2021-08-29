using System;
using System.Collections.Generic;
using System.Text;
using TrainingCenterCRM.BLL.Models;

namespace TrainingCenterCRM.BLL.Interfaces
{
    public interface IStudentToGroupAssignmentService
    {
        void AddAssignment(StudentToGroupAssignment dto);
        void EditAssignment(StudentToGroupAssignment dto);
        void DeleteAssignment(int id);
        StudentToGroupAssignment GetAssignment(int id);
        StudentToGroupAssignment GetAssignmentByStudent(int studentId);
        List<StudentToGroupAssignment> GetAssignments();
        IEnumerable<StudentToGroupAssignment> GetAssignmentsByGroup(int groupId);

    }
}
