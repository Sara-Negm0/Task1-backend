using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Company.ViewModel
{
    public class EmployeeEditViewModel
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MaxLength(11)]
        public string Mobile { get; set; }
        [Required]
        [MaxLength(14)]
        public string NationalID { get; set; }
        [Required]
        public string Gender { get; set; }
        public DateTime HiringDate { get; set; } = DateTime.Now;
        public int JobID { set; get; }
        public bool Status { get; set; } = true;

    }
}
