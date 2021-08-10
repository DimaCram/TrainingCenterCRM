using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrainingCenterCRM.BLL.Models;
using TrainingCenterCRM.DAL.Context;
using TrainingCenterCRM.DAL.Interfaces;

namespace TrainingCenterCRM.DAL.Repositories
{
    public class StudentToGroupAssignmentRepository : IRepository<StudentToGroupAssignment>
    {

        private readonly TrainingCenterContext db;

        public StudentToGroupAssignmentRepository(TrainingCenterContext db)
        {
            this.db = db;
        }
        public void Create(StudentToGroupAssignment item)
        {
            db.StudentToGroupAssignments.Add(item);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var studentToGroupAssignment = db.StudentToGroupAssignments.Find(id);
            if (studentToGroupAssignment == null)
                throw new ArgumentException("Student to group assignment not found");

            db.StudentToGroupAssignments.Remove(studentToGroupAssignment);
            db.SaveChanges();
        }

        public IEnumerable<StudentToGroupAssignment> Find(Func<StudentToGroupAssignment, bool> predicate)
        {
            return db.StudentToGroupAssignments.Where(predicate).ToList();
        }

        public StudentToGroupAssignment Get(int id)
        {
            return db.StudentToGroupAssignments.Find(id);
        }

        public List<StudentToGroupAssignment> GetAll()
        {
            return db.StudentToGroupAssignments.ToList();
        }

        public void Update(StudentToGroupAssignment item)
        {
            db.Entry(item).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
