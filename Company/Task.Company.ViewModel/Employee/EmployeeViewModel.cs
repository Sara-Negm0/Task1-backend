using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Company.ViewModel
{
    public class EmployeeViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string NationalID { get; set; }
        public string Gender { get; set; }
        public bool Status { get; set; }
        public DateTime HiringDate { get; set; } 
        public string JobName { set; get; }
        public int JobID { set; get; }

    }
}
