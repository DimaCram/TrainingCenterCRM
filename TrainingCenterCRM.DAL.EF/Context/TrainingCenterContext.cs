using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TrainingCenterCRM.BLL.Models;

namespace TrainingCenterCRM.DAL.Context
{
    public class TrainingCenterContext : IdentityDbContext 
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentToGroupAssignment> StudentToGroupAssignments { get; set; }


        public TrainingCenterContext()
        {
            Database.EnsureCreated();
        }

        public TrainingCenterContext(DbContextOptions<TrainingCenterContext> options) : base(options) {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Name = "user" },
                new IdentityRole { Name = "admin" }
            );
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Seed();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=TrainingCenterDB;Trusted_Connection=True;");
        }                                
    }
}
