using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeProject.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstMigration.Context
{
    public class EmployeeProjectDbContext : DbContext
    {
        public EmployeeProjectDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        //public DbSet<Rank> Ranks { get; set; }
        
        //public DbSet<Image> Images { get; set; }
        //public DbSet<Project> Projects { get; set; }

        //this method override the method that executed while creating the models 'onModelCreating'
        //we can assign default values
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
