using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoStrimg
{
    class Class1
    {
        static void Main(string[] args)
        {
            try
            {
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine(num / 0);
            }
            catch(DividedByZeroException e)
            {
                Console.WriteLine(e.Message + " " + e.Source + " " + e.StackTrace);
            }
            Console.ReadLine();
        }
    }
}
