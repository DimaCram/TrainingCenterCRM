using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TrainingCenterCRM.BLL.Interfaces;
using TrainingCenterCRM.BLL.Services;
using TrainingCenterCRM.Core.Models;
using TrainingCenterCRM.DAL.EF.Interfaces;

namespace TrainingCenterCRM.Test.Services
{
    class StudentMarkServiceTest
    {
        private IStudentMarkService _studentMarkService; 

        private Mock<IStudentMarkRepository> _mockStudentMarkRepository;
        private Mock<IUserService> _mockUserService;

        [SetUp]
        public void SetUp()
        {
            _mockStudentMarkRepository = new Mock<IStudentMarkRepository>();
            _mockUserService = new Mock<IUserService>();
        }

        private IEnumerable<StudentMark> GetStudentMarks()
        {
            return new List<StudentMark>
            {
                new StudentMark{ Mark = 8, StudentId = 1},
                new StudentMark{ Mark = 10, StudentId = 2},
                new StudentMark{ Mark = 3, StudentId = 1},
                new StudentMark{ Mark = 6, StudentId = 1},
                new StudentMark{ Mark = 8, StudentId = 1}
            };
        }

        [Test]
        public async Task GetStudentAverageMarkByGroup_ReturnResult()
        {
            //Arrange
            var studentId = 1;
            var groupId = 2;

            var mock = new Mock<Func<StudentMark, bool>>();

            _mockStudentMarkRepository.Setup(m => m.Find(It.IsAny<Expression<Func<StudentMark, bool>>>()).Result)
                                     .Returns(GetStudentMarks().Where(m => m.StudentId == studentId).ToList());

            _mockUserService.Setup(m => m.GetUserWithStudentByEmail(It.IsAny<string>()).Result)
                           .Returns(new User() { Student = new Student { Id = studentId } });

            _studentMarkService = new StudentMarkService(_mockStudentMarkRepository.Object, _mockUserService.Object);
            var expected = 6.25;

            //Act
            var actual = await _studentMarkService.GetStudentAverageMarkByGroup(groupId, "");

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetStudentAverageMarkByGroup_ThrowsException()
        {
            //Arrange
            _mockUserService.Setup(m => m.GetUserWithStudentByEmail(It.IsAny<string>()).Result)
                           .Returns(new User());

            _studentMarkService = new StudentMarkService(_mockStudentMarkRepository.Object, _mockUserService.Object);

            //Assert
            Assert.ThrowsAsync<ArgumentException>(async () => await _studentMarkService.GetStudentAverageMarkByGroup(2, ""));
        }

        [Test]
        public async Task GetStudentMarksByGroup_ReturnResult()
        {
            //Arrange
            var studentId = 1;
            var groupId = 2;

            var mock = new Mock<Func<StudentMark, bool>>();

            _mockStudentMarkRepository.Setup(m => m.GetStudentMarksByGroup(groupId, studentId).Result)
                                     .Returns(GetStudentMarks().Where(m => m.StudentId == studentId).ToList());

            _mockUserService.Setup(m => m.GetUserWithStudentByEmail(It.IsAny<string>()).Result)
                           .Returns(new User() { Student = new Student { Id = studentId } });

            _studentMarkService = new StudentMarkService(_mockStudentMarkRepository.Object, _mockUserService.Object);
            
            var expected = GetStudentMarks().Where(m => m.StudentId == studentId);

            //Act
            var actual = await _studentMarkService.GetStudentMarksByGroup(groupId, "");

            //Assert
            Assert.AreEqual(expected.Count(), actual.Count());
        }

        [Test]
        public void GetStudentMarksByGroup_ThrowsException()
        {
            //Arrange
            _mockUserService.Setup(m => m.GetUserWithStudentByEmail(It.IsAny<string>()).Result)
                           .Returns(new User());

            _studentMarkService = new StudentMarkService(_mockStudentMarkRepository.Object, _mockUserService.Object);

            //Assert
            Assert.ThrowsAsync<ArgumentException>(async () => await _studentMarkService.GetStudentMarksByGroup(2, ""));
        }
    }
}
