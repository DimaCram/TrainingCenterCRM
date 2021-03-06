using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using TrainingCenterCRM.BLL.Interfaces;
using TrainingCenterCRM.BLL.Services;
using TrainingCenterCRM.Core.Models;
using TrainingCenterCRM.DAL.EF.Context;
using TrainingCenterCRM.DAL.EF.Interfaces;
using TrainingCenterCRM.DAL.EF.Repositories;
using TrainingCenterCRM.Mappings;

namespace TrainingCenterCRM
{
    public class Startup
    {
        private readonly IWebHostEnvironment env;

        public Startup(IConfiguration configuration, IWebHostEnvironment environment)
        {
            Configuration = configuration;
            env = environment;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            services.AddDbContext<TrainingCenterContext>(options =>
                options.UseSqlServer(Configuration["ConnectionString"]));

            services.AddScoped<IRepository<Student>, StudentRepository>();
            services.AddScoped<IRepository<Group>, GroupRepository>();
            services.AddScoped<IRepository<Teacher>, TeacherRepository>();
            services.AddScoped<IRepository<Course>, CourseRepository>();
            services.AddScoped<IRepository<Topic>, TopicRepository>();
            services.AddScoped<IRepository<StudentRequest>, StudentRequestRepository>();
            services.AddScoped<IRepository<StudentToGroupAssignment>, StudentToGroupAssignmentRepository>();
            services.AddScoped<IRepository<Material>, MaterialRepository>();
            services.AddScoped<IRepository<File>, FileRepository>();

            services.AddScoped<IStudentService, StudentService>();
            services.AddScoped<IGroupService, GroupService>();
            services.AddScoped<ITeacherService, TeacherService>();
            services.AddScoped<ICourseService, CourseService>();
            services.AddScoped<ITopicService, TopicService>();
            services.AddScoped<IStudentRequestService, StudentRequestService>();
            services.AddScoped<IStudentToGroupAssignmentService, StudentToGroupAssignmentService>();
            services.AddScoped<IMaterialService, MaterialService>();
            services.AddScoped<IFileService, FileService>();
            services.AddScoped<ILocalFileService>(s => new LocalFileService(env.WebRootPath));

            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<TrainingCenterContext>();

            services.ConfigureApplicationCookie(
                options =>
                {
                    options.LoginPath = "/Accounts/LogIn";
                    options.AccessDeniedPath = "/error/401";
                });

            services.AddControllersWithViews().AddNewtonsoftJson(options =>
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            ).AddRazorRuntimeCompilation();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseStatusCodePagesWithReExecute("/Error/{0}");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            loggerFactory.AddFile($"Logs/log.txt");

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapAreaControllerRoute(
                    name: "teacherPortal",
                    areaName: "teacherPortal",
                    pattern: "teacherPortal/{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Students}/{action=Index}/{id?}");
            });
        }
    }
}
