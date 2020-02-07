using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter ur name");
            string name = (Console.ReadLine());
            Console.WriteLine("enter ur gradutation year");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("My name is " + name + " and I'll graduate in " + year);
            Console.ReadLine();
        }
    }
}
