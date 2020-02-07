using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter no of tickets");
            int noOfTickets = int.Parse(Console.ReadLine());
            Passanger p = new Passanger(name, age);
            p.TicketBooking(noOfTickets);
            Console.ReadKey();
        }
    }
    class Passanger
    {
        string name;
        int age;
        public Passanger(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void TicketBooking(int noOfTickets)
        {
            try
            {
                if (noOfTickets > 2) throw new BookingException("cannot book more than 2 tickets");

                else
                    Console.WriteLine("Tickets booked successully");

            }
            catch (BookingException e)
            {
                Console.WriteLine(e.Message + " " + e.StackTrace);
            }
        }
    }
    class BookingException : Exception
    {
        public BookingException(string s) : base(s)
        {

        }
    }
}
