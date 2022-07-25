using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.EntityFrameworkCore;
using TransportCompany.Model.DatabaseModels;
using TransportCompany.ViewModels.Employee;

namespace TransportCompany.Model
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<EmployeesManagersGroup> EmployeesManagersGroup { get;set;}
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Log>().HasData(new Log { Id = 1, Authorization = DateTime.Now, UserName = Environment.UserName });
            modelBuilder.Entity<EmployeesManagersGroup>((em => { em.HasNoKey(); em.ToView("EmployeesManagersGroup"); }));

        }
    }
}
