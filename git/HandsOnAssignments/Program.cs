using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnAssignments
{
    class Program
    {
        public static void Welcome()
        {
            Console.WriteLine("welcome to the world of c#");
        }


        public static void Greet(string name)
        {
            Console.WriteLine("Hi " + name);
            Console.WriteLine("welcome to the world of c#");
        }
        public static void MiddleNumber(int n1,int n2)
        {
            int i;
            for(i=n1;i<=n2;i++)
            {
                Console.WriteLine(i);
            }
            return ;
        }
        public static void EvenorOdd(int i)
        {
            if(i%2==0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
        public static void Temperature(int f)
        {
            int c;
            Console.WriteLine(c = (f - 32) * 5 / 9);
           
            
        }
        public static int Factorial(int k)
        {
            int fact = 1;
            for(int i=1;i<=k;i++)
            {
                fact = fact * i;
            }return fact;
        }
        public static int Fibanocci(int k)
        {
            int i, f1 = 0, f2 = 1, f3 = 0;
            Console.WriteLine(f1);
            Console.WriteLine(f2);
            for (i = 0; i <= k; i++)
            {
                f3 = f1 + f2;
                Console.WriteLine(f3);
                f1 = f2;
                f2 = f3;
            }return k;
        }
        public static void Multiplication(int n)
        {
            int j;
            for (j = 1; j <= 20; j++)
            {
                Console.Write("{0} X {1} = {2} \n", n, j, n * j);
            }
        }
        public static void Division()
        {
            int i;
                for(i=200;i<=300;i++)
            {
                if(i%7==0)
                {
                    Console.WriteLine(i);
                }
            }

            
        }
             static void Main(string[] args)
        {
            //Welcome();

            //Greet("renu");

            /* Console.Write("Enter a number: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            MiddleNumber(n1, n2);
            Console.ReadKey();*/
            /*console.WriteLine("enter no:");
            int i = int.Parse(Console.ReadLine());
             EvenorOdd(i);
            Console.ReadKey();*/
            /*onsole.WriteLine("enter temperature in f:");
             int temp = int.Parse(Console.ReadLine());
             Temperature(temp);
             Console.ReadKey();*/
            /* Console.WriteLine(Factorial(5));
             Console.ReadKey();*/
            /*Fibanocci(40);
            Console.ReadKey();*/
            /* Multiplication(5);
             Console.ReadKey();*/
            Division();
            Console.ReadKey();

        }
    }
}
