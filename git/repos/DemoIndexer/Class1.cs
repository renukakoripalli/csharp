using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoIndexer
{
    class Employee
    {
        int id;
        string name;
        string designation;
        public Employee(int id, string name, string designation)
        {
            this.id = id;
            this.name = name;
            this.designation = designation;
        }
        public override string ToString()
        {
            return name;

        }
    }
}