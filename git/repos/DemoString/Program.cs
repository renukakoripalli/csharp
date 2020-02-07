using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringConcept
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "welcome";
            Console.WriteLine(str.Length + " " + str.Replace("e", "k") + str.ToLower() + str.ToUpper());
            Console.WriteLine(str.Contains("lc"));
            Console.WriteLine(string.Compare("hello", "HEllo"));
            string str1 = "WELCOME";
            Console.WriteLine(str.Equals(str1, StringComparison.InvariantCultureIgnoreCase));
            //  string[] data = input.Split('', '/');
            /*int[] num = new int[data.Length];
             for(int j = 0; j < data.Length; j++)
             {
                 num[j] = Convert.ToInt32(data[0]);
             }
             foreach*/

            /* Employee earray = new Employee[3]
             {
                 new Employee("ram","300",10000)
             }*/



            List<Employee> elist = new List<Employee>();
            elist.Add(new Employee("ram", "300", 10000));
            elist.Add(new Employee("renu", "400", 20000));
            foreach (Employee e in elist)
            {
                Console.WriteLine(e.ToString());
            }
            Console.ReadKey();
        }
        class Employee
        {
            string name;
            string empid;
            int salary;
            public Employee() { }
            public Employee(string name, string empid, int salary)
            {
                this.name = name;
                this.empid = empid;
                this.salary = salary;
            }
            public override string ToString()
            {
                return this.name + "\n" + this.empid + "\n" + this.salary;
            }


        }
    }
}