using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Company.Entities;

namespace Task.Company.Reposatory
{
    public class EntitiesContext : DbContext
    {
        public EntitiesContext() : base("name=Company")
        { }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add
                (new EmployeeConfiguration());
            modelBuilder.Configurations.Add
               (new JobConfiguration());

        }
    }
}
