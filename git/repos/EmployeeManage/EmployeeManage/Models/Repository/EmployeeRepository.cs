using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManage.Model
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private List<Employee> employeeList;
        public EmployeeRepository()
        {
            employeeList = new List<Employee>() { new Employee(1, "renu", "abc@gmail.com", Dept.IT),

             new Employee(2,"durga","abcd@gmail.com",Dept.PAT),
             new Employee(3,"neeru","abcde@gmail.com",Dept.SeniorAssociate),};
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
            emp.Id = employeeList.Max(e => e.Id) + 1;
            employeeList.Add(emp);
            return true;
        }
    }
}