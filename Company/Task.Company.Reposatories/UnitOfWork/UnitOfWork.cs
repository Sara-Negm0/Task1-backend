using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Company.Entities;

namespace Task.Company.Reposatory
{
    public class UnitOfWork
    {
        private EntitiesContext context { get; set; }
        public Generic<Employee> EmployeeRepo { get; set; }
        public Generic<Job> JobRepo { get; set; }

        public UnitOfWork(
            EntitiesContext _context,
            Generic<Employee> employeeRepo,
            Generic<Job> jobRepo
            )
        {
            context = _context;
            EmployeeRepo = employeeRepo;
            JobRepo = jobRepo;
        }

        public int Commit()
        {
            return context.SaveChanges();
        }
    }
}
