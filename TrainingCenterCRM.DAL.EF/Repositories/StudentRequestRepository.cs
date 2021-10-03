﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingCenterCRM.Core.Models;
using TrainingCenterCRM.DAL.EF.Context;
using TrainingCenterCRM.DAL.EF.Interfaces;

namespace TrainingCenterCRM.DAL.EF.Repositories
{
    public class StudentRequestRepository : IRepository<StudentRequest>
    {
        private readonly TrainingCenterContext db;

        public StudentRequestRepository(TrainingCenterContext db)
        {
            this.db = db;
        }

        public async Task CreateAsync(StudentRequest item)
        {
            await db.StudentRequests.AddAsync(item);
            await db.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var request = await db.StudentRequests.FindAsync(id);
            if (request == null)
                throw new ArgumentException("Student request not found");
            db.StudentRequests.Remove(request);
            await db.SaveChangesAsync();
        }

        public IEnumerable<StudentRequest> Find(Func<StudentRequest, bool> predicate)
        {
            return db.StudentRequests.Where(predicate).ToList();
        }

        public Task<StudentRequest> GetAsync(int id)
        {
            return db.StudentRequests.FirstOrDefaultAsync(sr => sr.Id == id);
        }

        public Task<List<StudentRequest>> GetAllAsync()
        {
            return db.StudentRequests.Include(s => s.Student)
                                     .Include(c => c.Course)
                                     .ToListAsync();
        }

        public async Task UpdateAsync(StudentRequest item)
        {
            db.Entry(item).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }
    }
}
