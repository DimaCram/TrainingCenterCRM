using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrainingCenterCRM.DAL.EF.Migrations
{
    public partial class AddMoreData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e5753878-35d1-4134-833c-657827b41d14");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ef40fd2e-d6f4-401a-98ea-93276c945d24");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4ae1ce9d-9ca6-4cb9-a169-75078aafcca6", "d7e66810-fdf2-408e-bc1a-3eee90bc99c3", "user", null },
                    { "697e2b8b-4207-4cc6-9aed-67c1fdff5a7d", "0937abea-deae-4b73-ba98-ad8c88f7f36d", "admin", null }
                });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Basic course", "C# Programming" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Professional course", "Industrial programming with ASP.NET" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Professional course", "Development of mobile games on the Unity engine" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Description", "Title", "TopicId" },
                values: new object[,]
                {
                    { 4, "Basic course", "Java programming", 1 },
                    { 5, "Professional course", "Development of mobile applications for Android", 1 },
                    { 6, "Professional course", "Java Web Development", 1 }
                });

            migrationBuilder.UpdateData(
                table: "StudentRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "Comments",
                value: "");

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "GroupId", "Name", "Surname" },
                values: new object[,]
                {
                    { 20, 18, null, "Andrey", "Vereshchagin" },
                    { 19, 28, null, "Vasilisa", "Knyazeva" },
                    { 17, 22, null, "Maxim", "Tkachev" },
                    { 16, 20, null, "Veronika", "Petrova" },
                    { 15, 30, null, "Ekaterina", "Ignatieva" },
                    { 18, 25, null, "Alisa", "Marselyevna" },
                    { 13, 22, null, "Irina", "Fedorova" },
                    { 12, 23, null, "Elizaveta", "Petrova" },
                    { 11, 26, null, "Nikolay", "Savin" },
                    { 5, 20, null, "Anna", "Bykova" },
                    { 10, 21, null, "Bogdan", "Kuznetsov" },
                    { 9, 19, null, "Alexey", "Bazhenov" },
                    { 6, 28, null, "Vladimir", "Chernyaev" },
                    { 7, 30, null, "Ivan", "Kochergin" },
                    { 8, 19, null, "Eva", "Demina" },
                    { 14, 22, null, "Mila", "Vinogradova" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Age", "Bio", "Name", "Surname" },
                values: new object[,]
                {
                    { 10, 26, "Area of ​​interest: C ++, Graphics, Game engines.", "Andrey", "Martsinkevich" },
                    { 9, 26, "Course: Java Programming Field of Interest: Java, Spring, Python, Machine Learning, Data Science, Flutter, Angular.", "Maria", "Sokol" },
                    { 7, 25, "Areas of interest: development of mobile games, studying new technologies in the gaming industry (from virtual reality to multiplayer gaming technologies), AAA games.", "Artem ", "Mazgo " },
                    { 6, 24, "WEB developer, .NET developer", "Gleb", "Belkevich" },
                    { 5, 29, "Java developer, Qulix Systems company. Work experience: more than 4 years. Teaching experience: over 1 year", "Dmitry", "Samsonov" },
                    { 4, 44, "Java and Android Developer. Work experience: over 14 years. Teaching experience: over 8 years", "Igor", "Pinyutin" },
                    { 3, 28, "Designer, designer. Work experience: over 10 years. Teaching experience: over 7 years.", "Julia", "Morgun" },
                    { 8, 32, "Basics of web technologies, Website development using HTML, CSS and JavaScript Field of interest: HTML, CSS, JavaScript, nodeJS, reactJS and in general everything related to web development.", "Evgeny", "Voitekhovich" }
                });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Microsoft's ASP.NET platform is used to create simple web sites, and large-scale projects - highly reliable network portals, which are designed for an audience of thousands. Due to security and flexibility, it is actively used by large companies: popular Microsoft sites, Lego, Volvo, Toyota, L'Oreal are developed with ASP.NET.", "C#" });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "The Java programming language is among the leaders in many ratings: TIOBE - based on calculating the results of search queries, PYPL - according to the analysis of popularity in the Google search engine, IEEE - according to a set of indicators, such as mention in projects, articles, vacancies and others. Such popularity due to its almost limitless possibilities and areas of application. Java does not depend on a certain platforms, it is called a secure, portable, high performance and dynamic language.");

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[,]
                {
                    { 3, "As the choice of devices and browsers expands, the need for flexible, responsive user interfaces increases (after all, no one wants to use a site that is only half displayed). This is exactly what the Front-end developer is working on: from adaptation and layout of design layouts to the implementation of complex logic of interaction with users during website development.", "Front-end development" },
                    { 4, "С++ widely used for software development, being one of the most popular programming languages. Its scope includes the creation of operating systems, a variety of application programs, device drivers, applications for embedded systems, high-performance servers, and games. There are many implementations of the C ++ language, both free and commercial and for various platforms. C ++ has had a huge impact on other  programming languages, most notably Java and C #.", "С++" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Description", "Title", "TopicId" },
                values: new object[,]
                {
                    { 7, "Basic course", "HTML, CSS and JavaScript", 3 },
                    { 8, "Professional course", "JavaScript Web Application Development", 3 },
                    { 9, "Professional course", "React and Angular for web development", 3 },
                    { 10, "Basic course", "C and C++ Programming", 4 },
                    { 11, "Professional course", "Professional game development in C++", 4 }
                });

            migrationBuilder.InsertData(
                table: "StudentRequests",
                columns: new[] { "Id", "Comments", "CourseId", "ReadyToStartDate", "RequestStatus", "StudentId" },
                values: new object[,]
                {
                    { 5, "", 3, new DateTime(2021, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 5 },
                    { 6, "", 3, new DateTime(2021, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 6 },
                    { 7, "", 4, new DateTime(2021, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 7 },
                    { 8, "", 4, new DateTime(2021, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 7 },
                    { 9, "", 5, new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 8 },
                    { 10, "", 5, new DateTime(2021, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 9 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ae1ce9d-9ca6-4cb9-a169-75078aafcca6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "697e2b8b-4207-4cc6-9aed-67c1fdff5a7d");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "StudentRequests",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "StudentRequests",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "StudentRequests",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "StudentRequests",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "StudentRequests",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "StudentRequests",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ef40fd2e-d6f4-401a-98ea-93276c945d24", "99044470-de2b-4d70-95c4-96e9aa6fdeb8", "user", null },
                    { "e5753878-35d1-4134-833c-657827b41d14", "ab2dd183-0eff-4322-91c8-96ab8116ea3b", "admin", null }
                });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Базовый курс", "Программирование на C#" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Профессиональный курс", "Промышленное программирование на ASP.NET" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Базовый курс", "Программирование на Java" });

            migrationBuilder.UpdateData(
                table: "StudentRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "Comments",
                value: "Хочу быть программистом!!!");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Платформа ASP.NET от компании Microsoft применяется для создания как простых web - сайтов,так и масштабных проектов – высоконадежных сетевых порталов,которые рассчитаны на многотысячную аудиторию.Благодаря безопасности и гибкости активно используется крупными компаниями: популярные сайты Microsoft, Lego, Volvo, Toyota, L'Oreal разработаны именно на ASP.NET.", "ASP.NET" });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Язык программирования Java находится в числе лидеров во многих рейтингах: TIOBE – на основе подсчёта результатов поисковых запросов, PYPL – по анализу популярности в поисковике Google, IEEE – по комплексу показателей, таких как упоминание в проектах, статьях, вакансиях и других.Такая популярность обусловлена практически безграничными его возможностями и областями применения.Java не зависит от определённой платформы, его называют безопасным, портативным, высокопроизводительным и динамичным языком.");
        }
    }
}
