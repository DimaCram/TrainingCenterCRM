using System;
using System.Collections.Generic;
using System.Text;
using TrainingCenterCRM.BLL.DTO;
using TrainingCenterCRM.DAL.Enttities;

namespace TrainingCenterCRM.BLL.Interfaces
{
    public interface IStudentToGroupAssignmentService
    {
        void AddAssignment(StudentToGroupAssignmentDTO dto);
        void EditAssignment(StudentToGroupAssignmentDTO dto);
        void DeleteAssignment(int id);
        StudentToGroupAssignmentDTO GetAssignment(int id);
        List<StudentToGroupAssignment> GetAssignments();
        void Dispose();
    }
}
