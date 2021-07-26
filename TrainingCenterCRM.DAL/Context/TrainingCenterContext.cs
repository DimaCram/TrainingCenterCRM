using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TrainingCenterCRM.DAL.Enttities;

namespace TrainingCenterCRM.DAL.Context
{
    public class TrainingCenterContext : DbContext 
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }

        public TrainingCenterContext()
        {
            Database.EnsureCreated();
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=TrainingCenterDB;Trusted_Connection=True;");
        }
    }
}
