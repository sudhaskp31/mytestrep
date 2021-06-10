using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using System.Data;
using Microsoft.EntityFrameworkCore;

namespace LearningEFProject.Models
{
    public class SampleContext:DbContext

    {
        readonly string connectionString = @"Data source=LAPTOP-E9STVIGE\SQLEXPRESS;Integrated security=true;Initial Catalog=dbJune10";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<SkillsTable> skills { get; set; }
       
         protected override void OnModelCreating(ModelBuilder modelBuilder)
             {
             modelBuilder.Entity<Employee>().HasData(
                 new Employee()
                 {
                     Id = 101,
                     Name = "ABC",
                     Date_Of_Birth = new DateTime(1990, 06, 12)
                 }
                 );

             modelBuilder.Entity<SkillsTable>().HasData(
                new SkillsTable()
                {
                    SkillName="Java",
                    SkillDescription = "OOPS"
                }
                ); 

        }
        
    }
}
