using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnIteravtiveStatements
{
    class Program
    {
        public static int Menu(int choice)
            
        {
           
            switch(choice)
            {
                case 1:
                    Console.WriteLine("even/odd");
                        if(n%2==0)
                    {
                        Console.WriteLine("even");
                      
                    }
                        else
                    {
                        Console.WriteLine("odd");
                    }
                    break;
                
                default:
                    Console.WriteLine("enter correct option");
                    break;
            }
            
            return result;
         
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("enter no:");
 
            Console.WriteLine("enter choice:",choice);
            Console.ReadKey();
        }
    }
}
