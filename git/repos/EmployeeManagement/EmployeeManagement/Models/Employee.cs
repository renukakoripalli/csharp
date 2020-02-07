﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Dept Dept { get; set; }
        public Employee(int id, string name, string email, Dept dept)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.Dept = dept;
        }
        public Employee()
        {

        }

    }
}