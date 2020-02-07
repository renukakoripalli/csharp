using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnConditionalStatements
{
    class Program
    {
        public static string EvenorOdd(int i)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
        /*public static int Max(int i,int j,int k)
        {
            if(i>j)
            {
                if (i > k)
                    return i;
                else
                    return k;
            }
            else
            {
                if (j > k)
                    return j;
                else
                    return k;
            }
        }*/
        static void Main(string[] args)
        {
            //Console.WriteLine("enter no");
            int i = int.Parse(Console.ReadLine());
            //string result = EvenorOdd(i);
            Console.WriteLine(EvenorOdd(4));
            //Console.WriteLine(Max(12, 23, 10));
            Console.ReadKey();
        }
    }
}
