using System;

namespace ConsoleApp3
{



    class Staff
    {
        // our fields 
        private const int hourlyRate = 30;
        private string nameOfStaff;
        private int hWorked;

        // properties 
        public int HoursWorked
        {
            get
            {
                return hWorked;
            }
            set
            {
                if (value > 0) hWorked = value; else hWorked = 0;
            }
        }

        // methods

        public void PrintMessage()
        {

            Console.WriteLine("Calculating Pay ----");
        }
        // method that returns an int value 
        public int CalculatePay()
        {

            PrintMessage();

            int staffPay;
            staffPay = hWorked * hourlyRate;

            if (hWorked > 0)
                return staffPay;
            else
                return 0;

        }


        // overload method

        public int CalculatePay(int bonus, int allowance)
        {
            PrintMessage();

            if (hWorked > 0)
                return hWorked * hourlyRate + bonus + allowance;
            else
                return 0;
        }

        // constructor 
        public Staff(string name)
        {
            nameOfStaff = name;
            Console.WriteLine("\n" + nameOfStaff);

            Console.WriteLine("------------------");
        }

        public Staff(string name, string lastname)
        {
            nameOfStaff = name + " " + lastname;

            Console.WriteLine("\n" + nameOfStaff);

            Console.WriteLine("------------------");

        }

        // override 
        public override string ToString()
        {
            return "Name of Staff = " + nameOfStaff + ", hourly rate = " + hourlyRate + " hours worked = " + hWorked;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            int pay;
            // insiniate our object from class staff
            Staff staff1 = new Staff("Jared");
            staff1.HoursWorked = 500;
            pay = staff1.CalculatePay(1000, 499);
            Console.WriteLine(" Pay = {0}", pay);


            Staff staff2 = new Staff("Jordan", "Dude");
            staff2.HoursWorked = 40;
            pay = staff2.CalculatePay();
            Console.WriteLine("pay = {0}", pay);

        }
    }
}
