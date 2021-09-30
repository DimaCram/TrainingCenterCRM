using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TrainingCenterCRM.BLL.Models;

namespace TrainingCenterCRM.DAL.EF.Context
{
    public class TrainingCenterContext : IdentityDbContext<User>
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentToGroupAssignment> StudentToGroupAssignments { get; set; }
        public DbSet<StudentRequest> StudentRequests { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<File> Files { get; set; }
        public DbSet<FileToMaterialAssignment> FileToMaterialAssignments { get; set; }
        public DbSet<Manager> Managers { get; set; }
        
        public TrainingCenterContext(DbContextOptions<TrainingCenterContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();

            modelBuilder.Entity<User>()
                        .HasOne(a => a.Student)
                        .WithOne(a => a.User)
                        .HasForeignKey<Student>(c => c.UserId)
                        .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User>()
                        .HasOne(a => a.Teacher)
                        .WithOne(a => a.User)
                        .HasForeignKey<Teacher>(c => c.UserId)
                        .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User>()
                        .HasOne(a => a.Manager)
                        .WithOne(a => a.User)
                        .HasForeignKey<Manager>(c => c.UserId)
                        .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
