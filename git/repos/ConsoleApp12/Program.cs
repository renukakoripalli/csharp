using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("enter the elements in array");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the elements in array");
            int[] ar = new int[n];
            for (int i = 0; i < n; i++)
            {
                ar[i] = int.Parse(Console.ReadLine());
            }
            int first;
            first = ar[0];
            for (int i = 0; i < n; i++)
            {
                if (n == 1)
                {
                    // int max=ar[]
                    Console.WriteLine("it is largest" + ar[i]);
                    break;
                }
                else
                {
                    int middle, last;
                    middle = n / 2;
                    last = n - 1;
                    if ((first > middle) && (first > last))
                    {
                        Console.WriteLine("largest is:", +first);
                    }
                    else if (middle > last)
                    {
                        Console.WriteLine("largest is:", +middle);
                    }
                    else { Console.WriteLine("largest is:", +last); }

                }

            }
        }
    }
}

