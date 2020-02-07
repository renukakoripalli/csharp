using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnEmployeeProject.Models;
namespace HandsOnEmployeeProject.Repositories
{
    public class EmployeeRepository
    {
        public static List<Employee> list = new List<Employee>()
        {
            new Employee(){ EmpName = "Renu",EId = "844568", Designation = "SeniorAssociate",Projectname = "Banking",Pwd="12345"}
        };
        public EmployeeRepository()
        {

        }
        public void Add(Employee item)
        {
            list.Add(item);
        }
        public Employee Validate(string eid, string pwd)
        {
            foreach (var item in list)
            {
                if (item.EId == eid && item.Pwd == pwd)
                {
                    return item;
                }
            }
            return null;
        }
    }
}


