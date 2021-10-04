using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using TrainingCenterCRM.BLL.Interfaces;
using TrainingCenterCRM.BLL.Services;
using TrainingCenterCRM.Core.Models;
using TrainingCenterCRM.DAL.EF.Context;
using TrainingCenterCRM.DAL.EF.Interfaces;
using TrainingCenterCRM.DAL.EF.Repositories;
using TrainingCenterCRM.WebAngular.Mapper;

namespace TrainingCenterCRM.Api
{
    public class Startup
    {
        private readonly IWebHostEnvironment _env;
        public Startup(IConfiguration configuration, IWebHostEnvironment environment)
        {
            Configuration = configuration;
            _env = environment;
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
            services.AddScoped<IRepository<FileToMaterialAssignment>, FileToMaterialAssignmentRepository>();
            services.AddScoped<IUserRepository, UserRepository>();

            services.AddScoped<IStudentService, StudentService>();
            services.AddScoped<IGroupService, GroupService>();
            services.AddScoped<ITeacherService, TeacherService>();
            services.AddScoped<ICourseService, CourseService>();
            services.AddScoped<ITopicService, TopicService>();
            services.AddScoped<IStudentRequestService, StudentRequestService>();
            services.AddScoped<IStudentToGroupAssignmentService, StudentToGroupAssignmentService>();
            services.AddScoped<IMaterialService, MaterialService>();
            services.AddScoped<IFileService, FileService>();
            services.AddScoped<ILocalFileService>(s => new LocalFileService(_env.WebRootPath));
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IFileToMaterialAssignmentService, FileToMaterialAssignmentService>();

            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<TrainingCenterContext>();

            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 4;
            });

            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(opt => {
                opt.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,

                    ValidIssuer = Configuration["TokkenOption:Issuer"],
                    ValidAudience = Configuration["TokkenOption:Audience"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["TokkenOption:SecretKey"]))
                };
            });

            services.AddControllersWithViews();

            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/dist";
            });
            services.AddCors(c =>
            {
                c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin());
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            if (_env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseCors(options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            if (!_env.IsDevelopment())
            {
                app.UseSpaStaticFiles();
            }

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller}/{action=Index}/{id?}");
            });

            app.UseSpa(spa =>
            {
                // To learn more about options for serving an Angular SPA from ASP.NET Core,
                // see https://go.microsoft.com/fwlink/?linkid=864501

                spa.Options.SourcePath = "ClientApp";

                if (_env.IsDevelopment())
                {
                    spa.UseAngularCliServer(npmScript: "start");
                }
            });
        }
    }
}
