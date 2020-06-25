using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Company.Entities
{
    public class Employee :BaseModel
    {
        public string Name { get; set; }
        public string Mobile { get; set; }
        public bool Status { get; set; } 
        public string Email { get; set; }
        public string NationalID { get; set; }
        public string Gender { get; set; }
        public DateTime HiringDate { get; set; }
        public virtual Job Job { get; set; }
        public int JobID { get; set; }

    }
}
