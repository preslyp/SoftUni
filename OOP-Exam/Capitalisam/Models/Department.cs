﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Capitalisam.Models
{
    public class Department
    {
        public Department()
        {
            this.Employees = new List<IEmployee>();
        }
        public string Name { get; set; }

        //public Manager Manager { get; set; }

        public ICollection<IEmployee> Employees { get; set; }
    }
}
