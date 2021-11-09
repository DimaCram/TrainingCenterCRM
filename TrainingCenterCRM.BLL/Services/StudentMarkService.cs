using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingCenterCRM.BLL.Interfaces;
using TrainingCenterCRM.Core.Models;
using TrainingCenterCRM.DAL.EF.Interfaces;

namespace TrainingCenterCRM.BLL.Services
{
    public class StudentMarkService : IStudentMarkService
    {
        private readonly IStudentMarkRepository _studentMarkRepository;
        private readonly IUserService _userService;
        public StudentMarkService(IStudentMarkRepository studentMarkRepository, IUserService userService)
        {
            _studentMarkRepository = studentMarkRepository;
            _userService = userService;
        }

        public async Task AddMarkAsync(StudentMark studentMark)
        {
            if (studentMark == null)
                throw new ArgumentException();

            await _studentMarkRepository.Create(studentMark);
        }

        public async Task DeleteMarkAsync(int id)
        {
            await _studentMarkRepository.Delete(id);
        }

        public async Task EditMarkAsync(StudentMark studentMark)
        {
            if (studentMark == null)
                throw new ArgumentException();

            await _studentMarkRepository.Update(studentMark);
        }

        public Task<StudentMark> GetMarkAsync(int id)
        {
            return _studentMarkRepository.Get(id);
        }

        public Task<List<StudentMark>> GetMarksAsync()
        {
            return _studentMarkRepository.GetAll();
        }

        public Task<IEnumerable<StudentMark>> GetMarksByGroup(int groupId)
        {
            return _studentMarkRepository.GetMarksByGroup(groupId);
        }

        public async Task<double> GetStudentAverageMarkByGroup(int groupId, string userEmail)
        {
            var user = await _userService.GetUserWithStudentByEmail(userEmail);

            if (user.Student == null)
                throw new ArgumentException("Student not found");

            var studentMarks = await _studentMarkRepository.Find(m => m.Material.GroupId == groupId && m.StudentId == user.Student.Id);

            return studentMarks.Count() == 0 ? 0 : studentMarks.Average(m => m.Mark);
        }

        public async Task<IEnumerable<StudentMark>> GetStudentMarksByGroup(int groupId, string userEmail)
        {
            var user = await _userService.GetUserWithStudentByEmail(userEmail);

            if (user.Student == null)
                throw new ArgumentException("Student not found");

            return await _studentMarkRepository.GetStudentMarksByGroup(groupId, user.Student.Id);
        }
    }
}
