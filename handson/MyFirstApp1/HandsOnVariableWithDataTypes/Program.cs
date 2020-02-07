using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnVariableWithDataTypes
{
    class Program
    {
        string name;
        static double salary;

        public static char O1 { get; private set; }

        private static double o1;

        static void Main(string[] args)
        {
            int i=60;
            int[] a = new int[4] { 12, 23, 24, 45 };
            Console.WriteLine(i);
            O1 = 'a';
            o1 = 12.3;
            int k = 10;
            string name = "Rohan";
            Console.WriteLine("Name");
            Console.ReadKey();

        }
    }
}
