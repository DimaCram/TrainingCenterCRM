using Microsoft.AspNetCore.Identity;
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

            var student1 = new Student
            {
                Id = 1,
                Name = "Darya",
                Surname = "Fedorova",
                Age = 22
            };
            var student2 = new Student()
            {
                Id = 2,
                Name = "Andrey",
                Surname = "Popov",
                Age = 22
            };
            var student3 = new Student()
            {
                Id = 3,
                Name = "Dima",
                Surname = "Karasev",
                Age = 24
            };
            var student4 = new Student()
            {
                Id = 4,
                Name = "Denis",
                Surname = "Polonikov",
                Age = 28
            };

            modelBuilder.Entity<Student>().HasData(
                student1, student2, student3, student4
            );

            var topic1 = new Topic
            {
                Id = 1,
                Title = "ASP.NET",
                Description = "Платформа ASP.NET от компании Microsoft применяется для создания как простых web - сайтов," +
                    "так и масштабных проектов – высоконадежных сетевых порталов,которые рассчитаны на многотысячную аудиторию." +
                    "Благодаря безопасности и гибкости активно используется крупными компаниями: популярные сайты Microsoft," +
                    " Lego, Volvo, Toyota, L'Oreal разработаны именно на ASP.NET."
            };
            var topic2 = new Topic
            {
                Id = 2,
                Title = "Java",
                Description = "Язык программирования Java находится в числе лидеров во многих рейтингах: TIOBE – на основе " +
                "подсчёта результатов поисковых запросов, PYPL – по анализу популярности в поисковике Google, IEEE – по " +
                "комплексу показателей, таких как упоминание в проектах, статьях, вакансиях и других.Такая популярность " +
                "обусловлена практически безграничными его возможностями и областями применения.Java не зависит от определённой " +
                "платформы, его называют безопасным, портативным, высокопроизводительным и динамичным языком."
            };
            modelBuilder.Entity<Topic>().HasData(
                topic1, topic2
            );
            var course1 = new Course
            {
                Id = 1,
                Title = "Программирование на C#",
                Description = "Базовый курс",
                TopicId = topic1.Id
            };
            var course2 = new Course
            {
                Id = 2,
                Title = "Промышленное программирование на ASP.NET",
                Description = "Профессиональный курс",
                TopicId = topic1.Id
            };
            var course3 = new Course
            {
                Id = 3,
                Title = "Программирование на Java",
                Description = "Базовый курс",
                TopicId = topic1.Id
            };

            modelBuilder.Entity<Course>().HasData(
                course1, course2, course3  
            );

            modelBuilder.Entity<StudentRequest>().HasData(
                new StudentRequest
                {
                    Id = 1,
                    CourseId = course1.Id,
                    ReadyToStartDate = DateTime.Now,
                    StudentId = student1.Id,
                    Comments = "Хочу быть программистом!!!"
                },
                new StudentRequest
                {
                    Id = 2,
                    CourseId = course2.Id,
                    ReadyToStartDate = DateTime.Now,
                    StudentId = student2.Id,
                    Comments = ""
                }, new StudentRequest
                {
                    Id = 3,
                    CourseId = course2.Id,
                    ReadyToStartDate = DateTime.Now,
                    StudentId = student3.Id,
                    Comments = ""
                }, new StudentRequest
                {
                    Id = 4,
                    CourseId = course2.Id,
                    ReadyToStartDate = DateTime.Now,
                    StudentId = student4.Id,
                    Comments = ""
                }
            );
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Name = "user" },
                new IdentityRole { Name = "admin" }
            );
        }
    }
}
