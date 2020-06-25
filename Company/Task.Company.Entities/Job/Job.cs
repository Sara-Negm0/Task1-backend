﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Company.Entities
{
    public class Job :BaseModel
    {
        public string Name { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }


    }
}
