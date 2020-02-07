using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPartial
{
    partial class classA
    {
        partial void setData();
        public void print()
        {
            Console.WriteLine("ClassA printing");
            setData();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            classA obj = new classA();
            obj.print();
        }
    }
}
