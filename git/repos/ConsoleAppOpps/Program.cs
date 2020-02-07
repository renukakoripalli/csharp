using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOpps
{
    class Caluculator
    {
        int val1, val2;
        public int Val1 { get => Val1; set => Val1 = value; }
        public int Val2 { get => Val2; set => Val2 = value; }
        public Caluculator(int val1, int val2)
        {
            this.val1 = val1;
            this.val2 = val2;
        }
        public void Add(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }
        public void Swap(int num1,int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine(num1);
            Console.WriteLine(num2);

        }
    }
}
