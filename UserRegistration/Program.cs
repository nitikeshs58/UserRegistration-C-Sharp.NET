using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
        static string VALIDNAMEPATTERN = "^[A-Z][a-z]{2,}$";
        static string EMAILPATTERN="^([a-z0-9.-]+)@([a-z0-9-]+).([a-z]{2,8})(.[a-z]{2,8})?$";

        Regex regName = new Regex(VALIDNAMEPATTERN);
        Regex regEmail = new Regex(EMAILPATTERN);

        public void NameCheck(string pattern)
        {
            if (regName.IsMatch(pattern))
            {
                Console.WriteLine("Valid Pattern");
            }
            else
            {
                Console.WriteLine("Invalid Pattern");
            }
        }

        public void emailIDCheck(string pattern3)
        {
            if (regEmail.IsMatch(pattern3))
            {
                Console.WriteLine("Valid Pattern");
            }
            else
            {
                Console.WriteLine("Invalid Pattern");
            }
        }

        // Main Method
        static void Main(string[] args)
        {
            Console.WriteLine("!!! Welcome to the User registration Problem.!!!");
            Program p1 = new Program();

            Console.WriteLine("Enter first name: ");
            string firstName=Console.ReadLine();
            p1.NameCheck(firstName);

            Console.WriteLine("Enter last name: ");
            string lastName = Console.ReadLine();
            p1.NameCheck(lastName);


            Console.WriteLine("Enter Email ID: ");
            string emailID = Console.ReadLine();
            p1.emailIDCheck(emailID);
        }
    }
}
