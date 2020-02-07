using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOpps
{
    class Class2
    {
        static void Main(string[] args)
        {
            Caluculator cal = new Caluculator();
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int result = cal.Add(x, y);

            cal.Add(x, y);
            cal.Swap(x, y);
            Console.WriteLine(x + " " + y);
            Console.ReadLine();
        }
    }
}
