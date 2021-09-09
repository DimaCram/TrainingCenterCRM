﻿using Microsoft.AspNetCore.Identity;
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
            var teacher3 = new Teacher()
            {
                Id = 3,
                Name = "Julia",
                Surname = "Morgun",
                Age = 28,
                Bio = "Designer, designer. Work experience: over 10 years. Teaching experience: over 7 years."
            };
            var teacher4 = new Teacher()
            {
                Id = 4,
                Name = "Igor",
                Surname = "Pinyutin",
                Age = 44,
                Bio = "Java and Android Developer. Work experience: over 14 years. Teaching experience: over 8 years"
            };
            var teacher5 = new Teacher()
            {
                Id = 5,
                Name = "Dmitry",
                Surname = "Samsonov",
                Age = 29,
                Bio = "Java developer, Qulix Systems company. Work experience: more than 4 years. Teaching experience: over 1 year"
            };
            var teacher6 = new Teacher()
            {
                Id = 6,
                Name = "Gleb",
                Surname = "Belkevich",
                Age = 24,
                Bio = "WEB developer, .NET developer"
            };
            var teacher7 = new Teacher()
            {
                Id = 7,
                Name = "Artem ",
                Surname = "Mazgo ",
                Age = 25,
                Bio = "Areas of interest: development of mobile games, studying new technologies in the gaming industry " +
                      "(from virtual reality to multiplayer gaming technologies), AAA games."
            };
            var teacher8 = new Teacher()
            {
                Id = 8,
                Name = "Evgeny",
                Surname = "Voitekhovich",
                Age = 32,
                Bio = "Basics of web technologies, Website development using HTML, CSS and JavaScript Field of interest: HTML," +
                      " CSS, JavaScript, nodeJS, reactJS and in general everything related to web development."
            };
            var teacher9 = new Teacher()
            {
                Id = 9,
                Name = "Maria",
                Surname = "Sokol",
                Age = 26,
                Bio = "Course: Java Programming Field of Interest: Java, Spring, Python, Machine Learning, Data Science, Flutter, Angular."
            };
            var teacher10 = new Teacher()
            {
                Id = 10,
                Name = "Andrey",
                Surname = "Martsinkevich",
                Age = 26,
                Bio = "Area of ​​interest: C ++, Graphics, Game engines."
            };
            modelBuilder.Entity<Teacher>().HasData(teacher1, teacher2, teacher3, teacher4, teacher5, teacher6, teacher7, teacher8, teacher9, teacher10);

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
            var student5 = new Student
            {
                Id = 5,
                Name = "Anna",
                Surname = "Bykova",
                Age = 20
            };
            var student6 = new Student()
            {
                Id = 6,
                Name = "Vladimir",
                Surname = "Chernyaev",
                Age = 28
            };
            var student7 = new Student()
            {
                Id = 7,
                Name = "Ivan",
                Surname = "Kochergin",
                Age = 30
            };
            var student8 = new Student()
            {
                Id = 8,
                Name = "Eva",
                Surname = "Demina",
                Age = 19
            };
            var student9 = new Student
            {
                Id = 9,
                Name = "Alexey",
                Surname = "Bazhenov",
                Age = 19
            };
            var student10 = new Student()
            {
                Id = 10,
                Name = "Bogdan",
                Surname = "Kuznetsov",
                Age = 21
            };
            var student11 = new Student()
            {
                Id = 11,
                Name = "Nikolay",
                Surname = "Savin",
                Age = 26
            };
            var student12 = new Student()
            {
                Id = 12,
                Name = "Elizaveta",
                Surname = "Petrova",
                Age = 23
            };
            var student13 = new Student
            {
                Id = 13,
                Name = "Irina",
                Surname = "Fedorova",
                Age = 22
            };
            var student14 = new Student()
            {
                Id = 14,
                Name = "Mila",
                Surname = "Vinogradova",
                Age = 22
            };
            var student15 = new Student()
            {
                Id = 15,
                Name = "Ekaterina",
                Surname = "Ignatieva",
                Age = 30
            };
            var student16 = new Student()
            {
                Id = 16,
                Name = "Veronika",
                Surname = "Petrova",
                Age = 20
            };
            var student17 = new Student
            {
                Id = 17,
                Name = "Maxim",
                Surname = "Tkachev",
                Age = 22
            };
            var student18 = new Student()
            {
                Id = 18,
                Name = "Alisa",
                Surname = "Marselyevna",
                Age = 25
            };
            var student19 = new Student()
            {
                Id = 19,
                Name = "Vasilisa",
                Surname = "Knyazeva",
                Age = 28
            };
            var student20 = new Student()
            {
                Id = 20,
                Name = "Andrey",
                Surname = "Vereshchagin",
                Age = 18
            };

            modelBuilder.Entity<Student>().HasData(
                student1, student2, student3, student4, student5,
                student6, student7, student8, student9, student10,
                student11, student12, student13, student14, student15,
                student16, student17, student18, student19, student20
            );

            var topic1 = new Topic
            {
                Id = 1,
                Title = "C#",
                Description = "Microsoft's ASP.NET platform is used to create simple web sites," +
                    " and large-scale projects - highly reliable network portals, which are designed for an audience of thousands." +
                    " Due to security and flexibility, it is actively used by large companies: popular Microsoft sites," +
                    " Lego, Volvo, Toyota, L'Oreal are developed with ASP.NET."
            };
            var topic2 = new Topic
            {
                Id = 2,
                Title = "Java",
                Description = "The Java programming language is among the leaders in many ratings: TIOBE - based on" +
                " calculating the results of search queries, PYPL - according to the analysis of popularity in the Google search engine, IEEE - according to" +
                " a set of indicators, such as mention in projects, articles, vacancies and others. Such popularity" +
                " due to its almost limitless possibilities and areas of application. Java does not depend on a certain" +
                " platforms, it is called a secure, portable, high performance and dynamic language."
            };
            var topic3 = new Topic
            {
                Id = 3,
                Title = "Front-end development",
                Description = "As the choice of devices and browsers expands, the need for flexible, responsive user interfaces increases (after all," +
                " no one wants to use a site that is only half displayed). This is exactly what the Front-end developer is working on: from adaptation and" +
                " layout of design layouts to the implementation of complex logic of interaction with users during website development."
            };
            var topic4 = new Topic
            {
                Id = 4,
                Title = "С++",
                Description = "С++ widely used for software development, being one of the most popular programming languages. Its scope includes the creation" +
                " of operating systems, a variety of application programs, device drivers, applications for embedded systems, high-performance servers, and games." +
                " There are many implementations of the C ++ language, both free and commercial and for various platforms. C ++ has had a huge impact on other " +
                " programming languages, most notably Java and C #."
            };

            modelBuilder.Entity<Topic>().HasData(
                topic1, topic2, topic3, topic4
            );
            var course1 = new Course
            {
                Id = 1,
                Title = "C# Programming",
                Description = "Basic course",
                TopicId = topic1.Id
            };
            var course2 = new Course
            {
                Id = 2,
                Title = "Industrial programming with ASP.NET",
                Description = "Professional course",
                TopicId = topic1.Id
            };
            var course3 = new Course
            {
                Id = 3,
                Title = "Development of mobile games on the Unity engine",
                Description = "Professional course",
                TopicId = topic1.Id
            };
            var course4 = new Course
            {
                Id = 4,
                Title = "Java programming",
                Description = "Basic course",
                TopicId = topic1.Id
            };
            var course5 = new Course
            {
                Id = 5,
                Title = "Development of mobile applications for Android",
                Description = "Professional course",
                TopicId = topic1.Id
            };
            var course6 = new Course
            {
                Id = 6,
                Title = "Java Web Development",
                Description = "Professional course",
                TopicId = topic1.Id
            };
            var course7 = new Course
            {
                Id = 7,
                Title = "HTML, CSS and JavaScript",
                Description = "Basic course",
                TopicId = topic3.Id
            };
            var course8 = new Course
            {
                Id = 8,
                Title = "JavaScript Web Application Development",
                Description = "Professional course",
                TopicId = topic3.Id
            };
            var course9 = new Course
            {
                Id = 9,
                Title = "React and Angular for web development",
                Description = "Professional course",
                TopicId = topic3.Id
            };
            var course10 = new Course
            {
                Id = 10,
                Title = "C and C++ Programming",
                Description = "Basic course",
                TopicId = topic4.Id
            };
            var course11 = new Course
            {
                Id = 11,
                Title = "Professional game development in C++",
                Description = "Professional course",
                TopicId = topic4.Id
            };

            modelBuilder.Entity<Course>().HasData(
                course1, course2, course3,
                course4, course5, course6,
                course7, course8, course9,
                course10, course11
            );
            modelBuilder.Entity<StudentRequest>().HasData(
                new StudentRequest
                {
                    Id = 1,
                    CourseId = course1.Id,
                    ReadyToStartDate = new DateTime(2021, 8, 20),
                    StudentId = student1.Id,
                    Comments = "",
                    RequestStatus = RequestStatus.Open
                },
                new StudentRequest
                {
                    Id = 2,
                    CourseId = course2.Id,
                    ReadyToStartDate = new DateTime(2021, 7, 11),
                    StudentId = student2.Id,
                    Comments = "",
                    RequestStatus = RequestStatus.Open
                }, new StudentRequest
                {
                    Id = 3,
                    CourseId = course2.Id,
                    ReadyToStartDate = new DateTime(2021, 7, 15),
                    StudentId = student3.Id,
                    Comments = "",
                    RequestStatus = RequestStatus.Open
                }, new StudentRequest
                {
                    Id = 4,
                    CourseId = course2.Id,
                    ReadyToStartDate = new DateTime(2021, 7, 11),
                    StudentId = student4.Id,
                    Comments = "",
                    RequestStatus = RequestStatus.Open
                },
                new StudentRequest
                {
                    Id = 5,
                    CourseId = course3.Id,
                    ReadyToStartDate = new DateTime(2021, 9, 5),
                    StudentId = student5.Id,
                    Comments = "",
                    RequestStatus = RequestStatus.Open
                }, new StudentRequest
                {
                    Id = 6,
                    CourseId = course3.Id,
                    ReadyToStartDate = new DateTime(2021, 8, 15),
                    StudentId = student6.Id,
                    Comments = "",
                    RequestStatus = RequestStatus.Open
                }, new StudentRequest
                {
                    Id = 7,
                    CourseId = course4.Id,
                    ReadyToStartDate = new DateTime(2021, 9, 2),
                    StudentId = student7.Id,
                    Comments = "",
                    RequestStatus = RequestStatus.Open
                },
                new StudentRequest
                {
                    Id = 8,
                    CourseId = course4.Id,
                    ReadyToStartDate = new DateTime(2021, 8, 22),
                    StudentId = student7.Id,
                    Comments = "",
                    RequestStatus = RequestStatus.Open
                }, new StudentRequest
                {
                    Id = 9,
                    CourseId = course5.Id,
                    ReadyToStartDate = new DateTime(2021, 9, 3),
                    StudentId = student8.Id,
                    Comments = "",
                    RequestStatus = RequestStatus.Open
                }, new StudentRequest
                {
                    Id = 10,
                    CourseId = course5.Id,
                    ReadyToStartDate = new DateTime(2021, 7, 11),
                    StudentId = student9.Id,
                    Comments = "",
                    RequestStatus = RequestStatus.Open
                }
            );
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Name = "user" },
                new IdentityRole { Name = "admin" }
            );
        }
    }
}
