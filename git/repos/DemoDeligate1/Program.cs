using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDeligate2
{
    public delegate double calAreaPointer(double x);

    class Program
    {
        static void Main(string[] args)
        {
            //anomyous method
            calAreaPointer cptr = new calAreaPointer(delegate (double r) { return 3.14 * r * r; });
            //simplfy by using lambda
            calAreaPointer cptr1 = (r => 3.14 * r * r);
            double area = cptr(12);
            double area1 = cptr1(12);
            Console.WriteLine(area);
            Console.WriteLine(area1);
            Console.ReadLine();
        }
    }
}
