﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManage.Model
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int id);
        List<Employee> DisplayDetails();
        bool AddEmployee(Employee employee);

    }
}