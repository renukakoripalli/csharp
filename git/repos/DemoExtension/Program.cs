using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoExtension
{
   static class StringHelper
    {
        public static string FirstCaseChange(this string name)
        {
            char[] input = name.ToCharArray();
            input[0] = char.IsUpper(input[0]) ? char.ToLower(input[0]) : char.ToUpper(input[0]);
            return new string(input);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string name = "welcome";
            Console.WriteLine(name.FirstCaseChange());
            Console.ReadLine();


        }
    }
}
