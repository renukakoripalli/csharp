using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string ename, empDesignation;
            int eid, n;
            List<Employee> elist = new List<Employee>();
           

            for (; ; )
            {
                Console.WriteLine("\n0.Enter 0 to Exit\n1.Insert\n2.Display \n3.Update \n4.Delete ");
                Console.WriteLine("Enter your choice");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("enter employee details to insert........... ");
                        Console.WriteLine("Enter Employee Id Number");
                        eid = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Employee Name");
                        ename = Console.ReadLine();
                        Console.WriteLine("Enter Employee Designation");
                        empDesignation = Console.ReadLine();
                        elist.Add(new Employee(eid, ename, empDesignation));
                       
                        Console.WriteLine("Employees Inserted");
                        break;
                    case 2:
                        
                        Console.WriteLine("Employee Details");
                        foreach (Employee e in elist)
                        {
                            Console.WriteLine(e.ToString());
                        }
                        break;
                    case 4:
                        Console.WriteLine("Enter Employee Id to Remove");
                        int id = int.Parse(Console.ReadLine());
                        List<Employee> tr = elist.FindAll(e1 => e1.Eid == id);
                        foreach (Employee e in tr)
                        {
                            elist.Remove(e);
                        }
                        Console.WriteLine("Employee Deleted Press 2 to view Employee Details");
                        break;
                    case 3:
                        Console.WriteLine("Enter What you want to update either1.Designation or 2.Name...");
                        int change = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Employee Id to Update...");
                        int id1 = int.Parse(Console.ReadLine());

                        if (change == 1)
                        {
                            List<Employee> tr1 = elist.FindAll(e2 => e2.Eid == id1);
                            Console.WriteLine("Enter Designation to Change..");
                            string str = Console.ReadLine();
                            foreach (Employee e3 in tr1)
                            {
                                e3.empDesignation = str;
                            }
                        }
                        else if (change == 2)
                        {
                            List<Employee> tr1 = elist.FindAll(e2 => e2.Eid == id1);
                            Console.WriteLine("Enter name to Change..");
                            string str = Console.ReadLine();
                            foreach (Employee e3 in tr1)
                            {
                                e3.ename = str;
                            }
                        }
                        break;
                    case 0:
                        System.Environment.Exit(0);
                        break;
                }
            }
            
        }
    }
}

class Employee
{
    int eid;
    string eName, EmpDesignation;
    public string ename { get => eName; set => eName = value; }

    public string empDesignation { get => EmpDesignation; set => EmpDesignation = value; }

    public int Eid { get => eid; set => eid = value; }

    public Employee()
    {

    }
    public Employee(int eid, string ename, string des)
    {
        this.Eid = eid;
        this.ename = ename;
        this.empDesignation = des;
    }
    public override string ToString()
    {
        return " Employee Id.." + this.Eid + "\tEmployee name " + this.ename + "\tEmployee Designation... " + this.empDesignation;
    }
}