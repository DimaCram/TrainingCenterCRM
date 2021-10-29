using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingCenterCRM.BLL.Services;
using TrainingCenterCRM.Core.Enums;
using TrainingCenterCRM.Core.Filters;
using TrainingCenterCRM.Core.Models;
using TrainingCenterCRM.DAL.EF.Context;
using TrainingCenterCRM.DAL.EF.Repositories;

namespace TrainingCenterCRM.Test.Repositories
{
    public class CourseRepositoryTest
    {
        public DbContextOptions<TrainingCenterContext> _dbOpt;

        [SetUp]
        public void SetUp()
        {
            _dbOpt = new DbContextOptionsBuilder<TrainingCenterContext>()
                .UseInMemoryDatabase(databaseName: "TestDb").Options;

            using var context = new TrainingCenterContext(_dbOpt);
            // Remove data
            context.RemoveRange(context.Courses);
            context.SaveChanges();
            // Seed data
            context.Courses.AddRange(GetCourses());
            context.SaveChanges();
        }

        [TestCase("C# Programming", null, null, null, null, null, ExpectedResult = 1)]
        [TestCase(null, null, CourseLevel.Beginner, 500, null, null, ExpectedResult = 1)]
        [TestCase(null, null, null, null, 700, "C#", ExpectedResult = 3)]
        public async Task<int> Filter_ReturnResult(string title, string description, CourseLevel? level, double? priceFrom, double? priceTo, string topicName)
        {
            // Arrange
            var courseFilter = new CourseFilter
            {
                Title = title,
                Description = description,
                Level = level,
                PriceFrom = priceFrom,
                PriceTo = priceTo,
                TopicName = topicName
            };
            await using var context = new TrainingCenterContext(_dbOpt);
            var courseRepository = new CourseRepository(context);

            // Act
            var res = courseRepository.Filter(courseFilter);
            
            // Assert
            return res.Count();
        }

        private IEnumerable<Course> GetCourses()
        {
            var topic1 = new Topic
            {
                Id = 1,
                Title = "C#",
                Description = "Microsoft's ASP.NET platform is used to create simple web sites," +
                    " and large-scale projects - highly reliable network portals, which are designed for an audience of thousands." +
                    " Due to security and flexibility, it is actively used by large companies: popular Microsoft sites," +
                    " Lego, Volvo, Toyota, L'Oreal are developed with ASP.NET."
            };

            var course1 = new Course
            {
                Id = 1,
                Title = "C# Programming",
                Description = "Basic course",
                Price = 499,
                Level = CourseLevel.Advanced,
                TopicId = topic1.Id
            };

            var course2 = new Course
            {
                Id = 2,
                Title = "Industrial programming with ASP.NET",
                Description = "Professional course",
                Level = CourseLevel.Beginner,
                Price = 755,
                TopicId = topic1.Id
            };

            var course3 = new Course
            {
                Id = 3,
                Title = "Development of mobile games on the Unity engine",
                Description = "Professional course",
                Level = CourseLevel.Expert,
                Price = 699,
                TopicId = topic1.Id
            };

            var course4 = new Course
            {
                Id = 4,
                Title = "Java programming",
                Description = "Basic course",
                Level = CourseLevel.Beginner,
                Price = 499,
                TopicId = topic1.Id
            };

            var course5 = new Course
            {
                Id = 5,
                Title = "Development of mobile applications for Android",
                Description = "Professional course",
                Level = CourseLevel.Advanced,
                Price = 710,
                TopicId = topic1.Id
            };

            return new List<Course>
            {
                course1, course2, course3, course4, course5
            };
        }
    }
}
