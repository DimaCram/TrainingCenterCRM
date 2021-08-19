using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TrainingCenterCRM.BLL.Models;

namespace TrainingCenterCRM.DAL.EF.Context
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var teacher1 = new Teacher()
            {
                Id = 1,
                Name = "Elena ",
                Surname = "Rukavichnikova",
                Age = 25,
                Bio = "Sphere of interests: web and mobile application testing," +
                      "IoT, AR, API testing; creation and establishment of a test" +
                      "strategy and a policy of the QA department; review of testing" +
                      "processes within projects; team management (interviews, hiring," +
                      "tech. reviews, employee development)."
            };
            var teacher2 = new Teacher()
            {
                Id = 2,
                Name = "Dmitry",
                Surname = "Astreiko",
                Age = 26,
                Bio = "Area of ​​interest: Front-end development, modern frameworks (Angular, Vue)," +
                      "cloud technologies (Google Firebase, Amazon Web Services)."
            };
            modelBuilder.Entity<Teacher>().HasData(teacher1, teacher2);

            var group1 = new Group()
            {
                Id = 1,
                Name = "Functional software testing",
                StartDate = DateTime.Parse("12.08.2021"),
                TeacherId = teacher1.Id,
            };
            var group2 = new Group()
            {
                Id = 2,
                Name = "HTML, CSS, JavaScript",
                StartDate = DateTime.Parse("29.08.2021"),
                TeacherId = teacher2.Id,
            };
            modelBuilder.Entity<Group>().HasData(group1, group2);

            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    Id = 1,
                    Name = "Darya",
                    Surname = "Fedorova",
                    GroupId = group1.Id
                },
                new Student()
                {
                    Id = 2,
                    Name = "Andrey",
                    Surname = "Popov",
                    GroupId = group1.Id
                }
            );

        }
    }
}
