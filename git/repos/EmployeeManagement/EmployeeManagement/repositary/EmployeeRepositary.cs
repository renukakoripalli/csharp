using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Model
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private List<Employee> employeeList;
        public EmployeeRepository()
        {
            employeeList = new List<Employee>() { new Employee(1,"sai","abc@gmail.com",Dept.IT),
             new Employee(2,"gany","abcd@gmail.com",Dept.Accounts),
             new Employee(3,"krish","abcde@gmail.com",Dept.Software),};
        }
        public Employee GetEmployee(int id)
        {
            Employee e = employeeList.FirstOrDefault(e => e.Id == id);
            //foreach(Employee x in employeeList)
            //{
            //    if (x.Id == id)
            //        return x;
            //}
            return e;
        }
        public List<Employee> DisplayDetails()
        {
            return employeeList;
        }
        public bool AddEmployee(Employee emp)
        {
            emp.Id = employeeList.Max(e => (e.Id) + 1);
            employeeList.Add(emp);
            return true;
        }
    }
}