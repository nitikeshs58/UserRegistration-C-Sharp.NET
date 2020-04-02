using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
        static string VALIDNAMEPATTERN = "^[A-Z][a-z]{2,}$";
        Regex regName = new Regex(VALIDNAMEPATTERN);
        public void firstNameCheck(string pattern1)
        {
            if (regName.IsMatch(pattern1))
            {
                Console.WriteLine("Valid Pattern");
            }
            else
            {
                Console.WriteLine("Invalid Pattern");
            }
        }

        public void lastNameCheck(string pattern2)
        {
            if (regName.IsMatch(pattern2))
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
            p1.firstNameCheck(firstName);

            Console.WriteLine("Enter last name: ");
            string lastName = Console.ReadLine();
            p1.lastNameCheck(lastName);
        }
    }
}
