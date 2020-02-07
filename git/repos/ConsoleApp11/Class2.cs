using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    interface ILoan
    {
        void getIntrest();
    }
    interface IGLoan:ILoan
    {
        void getGoldIntrest();
    }
    interface DMAT
    {
        void displayDemat();
    }
    abstract class Bank
    {
        protected string bname;
        protected string location;
        public Bank(string bname, string location)
        {
            this.bname = bname;
            this.location = location;
        }

    }
    class SBI : Bank,ILoan
    {
        string bmanager;
        public SBI(string bname, string loc, string bmgr) : base(bname, loc)
        {
            this.bmanager = bmgr;
        }
        public void displaydetails()
        {
            Console.WriteLine(this.bname + " " + this.location + " " + this.bmanager);
        }
        public void getIntrest()
        {
            Console.WriteLine("sbi intrest is 12%");
        }
    }
    class ICICI : Bank,ILoan,DMAT//one class can implement multiple interfaces
    {
        string bmanager;
        public ICICI(string bname, string loc, string bmgr) : base(bname, loc)
        {
            this.bmanager = bmgr;
        }
        public void displayDemat()
        {
            Console.WriteLine("icici started demat loan");
        }
        public void displaydetails()
        {
            Console.WriteLine(this.bname + " " + this.location + " " + this.bmanager);
        }
        public void getIntrest()
        {
            Console.WriteLine("icici intrest is 12%");

        }
    }
}
