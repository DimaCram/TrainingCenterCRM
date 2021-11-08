using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TrainingCenterCRM.Core.Models;
using TrainingCenterCRM.DAL.EF.Context;
using TrainingCenterCRM.DAL.EF.Interfaces;

namespace TrainingCenterCRM.DAL.EF.Repositories
{
    public class StudentMarkRepository : IStudentMarkRepository
    {
        private readonly TrainingCenterContext _context;
        public StudentMarkRepository(TrainingCenterContext context)
        {
            _context = context;
        }
        public async Task Create(StudentMark item)
        {
            await _context.StudentMarks.AddAsync(item);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var studentMark = await _context.StudentMarks.FindAsync(id);
            if (studentMark == null)
                throw new ArgumentException("Student mark not found");

            _context.StudentMarks.Remove(studentMark);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<StudentMark>> Find(Expression<Func<StudentMark, bool>> predicate)
        {
            return await _context.StudentMarks.Where(predicate).ToListAsync();
        }

        public Task<StudentMark> Get(int id)
        {
            return _context.StudentMarks.FirstOrDefaultAsync(c => c.Id == id);
        }

        public Task<List<StudentMark>> GetAll()
        {
            return _context.StudentMarks.ToListAsync();
        }

        public async Task<IEnumerable<StudentMark>> GetMarksByGroup(int groupId)
        {
            return await _context.StudentMarks.Include(m => m.Material)
                                              .Include(m => m.Student)
                                              .Where(m => m.Material.GroupId == groupId)
                                              .ToListAsync();
        }

        public async Task<IEnumerable<StudentMark>> GetMarksForStudentByGroup(int studentId, int groupId)
        {
            return await _context.StudentMarks.Where(m => m.Material.GroupId == groupId && m.StudentId == studentId).ToListAsync();
        }

        public async Task Update(StudentMark item)
        {
            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
