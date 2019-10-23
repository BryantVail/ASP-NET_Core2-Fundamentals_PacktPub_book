using System;
using System.Collections.Generic;
using System.Text;
using ConsoleEF.Models;
using Microsoft.EntityFrameworkCore;


namespace ConsoleEF
{
    class EmployeeDbContext : DbContext
    {
        //domain objects
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"
                Data Source=localhost\SQLEXPRESS; 
                Initial Catalog=EFConsole; 
                Integrated Security=True;
                Connect Timeout=30;
                Encrypt=False;
                TrustServerCertificate=True;
                ApplicationIntent=ReadWrite;
                MultiSubnetFailover=False
            ");
        }
    }
}
