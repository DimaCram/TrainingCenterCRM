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
using TrainingCenterCRM.Core.Enums;
using TrainingCenterCRM.Core.Extensions;
using TrainingCenterCRM.Core.Models;
using TrainingCenterCRM.DAL.EF.Interfaces;
using Xunit;

namespace TrainingCenterCRM.Test.Services
{
    public class CourseServiceTest
    {
        [Test]
        public async Task Search_ReturnResult()
        {
            //Arrange
            var search = "C# Programming";
            Func<Course, bool> predicate = s => s.Title.Contains(search.NormalizeSearchString(), StringComparison.OrdinalIgnoreCase) ||
                                                s.Description.Contains(search.NormalizeSearchString(), StringComparison.OrdinalIgnoreCase);

            var mock = new Mock<ICourseRepository>();

            mock.Setup(cr => cr.Find(It.IsAny<Expression<Func<Course, bool>>>()).Result)
                .Returns(GetCourses().Where(predicate).ToList());
            
            ICourseService _courseService = new CourseService(mock.Object);
            var expected = 1;

            //Act
            var actual = await _courseService.Search(search);

            //Assert
            Assert.AreEqual(expected, actual.Count());
        }

        private IEnumerable<Course> GetCourses()
        {
            var courses = new List<Course>
            {
                new Course { Id = 1, Title = "C# Programming", Description = "Basic course"},
                new Course { Id = 2, Title = "Industrial programming with ASP.NET", Description = "Professional course"},
                new Course { Id = 3, Title = "Development of mobile games on the Unity engine", Description = "Professional course"},
                new Course { Id = 4, Title = "Development of mobile applications for Android", Description = "Professional course"},
                new Course { Id = 5, Title = "Java Web Development", Description = "Basic course"}
            };

            return courses;
        }
    }
}
