using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrainingCenterCRM.BLL.Models;
using TrainingCenterCRM.DAL.EF.Context;
using TrainingCenterCRM.DAL.Interfaces;

namespace TrainingCenterCRM.DAL.EF.Repositories
{
    public class StudentRequestRepository : IRepository<StudentRequest>
    {
        private readonly TrainingCenterContext db;

        public StudentRequestRepository(TrainingCenterContext db)
        {
            this.db = db;
        }

        public void Create(StudentRequest item)
        {
            db.StudentRequests.Add(item);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var request = db.StudentRequests.Find(id);
            if (request == null)
                throw new ArgumentException("Student request not found");
            
            db.StudentRequests.Remove(request);
            db.SaveChanges();
        }

        public IEnumerable<StudentRequest> Find(Func<StudentRequest, bool> predicate)
        {
            return db.StudentRequests.Where(predicate).ToList();
        }

        public StudentRequest Get(int id)
        {
            return db.StudentRequests.Find(id);
        }

        public List<StudentRequest> GetAll()
        {
            return db.StudentRequests.Include(s => s.Student)
                                     .Include(c => c.Course)
                                     .ToList();
        }

        public void Update(StudentRequest item)
        {
            db.Entry(item).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
