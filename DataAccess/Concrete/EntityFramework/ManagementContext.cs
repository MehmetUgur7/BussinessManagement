using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class ManagementContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ManagementDb;Trusted_Connection=true");
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Standard> Standards { get; set; }
        public DbSet<StandardAttribute> StandardAttributes { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }

    }
}
