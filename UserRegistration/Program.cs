using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
        static string VALIDNAMEPATTERN = "^[A-Z][a-z]{2,}$";
        static string EMAILPATTERN="^([a-z0-9.-]+)@([a-z0-9-]+).([a-z]{2,8})(.[a-z]{2,8})?$";
        static string MOBILEPATTERN="^[0-9]{2} [6-9]{1}[0-9]{9}$";
        static string PASSWORD = "^.*(?=.*[a-z0-9])*(?=.*[A-Z])*(?=.*[!@#$%^&*])(.{8,})$";

        Regex regName = new Regex(VALIDNAMEPATTERN);
        Regex regEmail = new Regex(EMAILPATTERN);
        Regex regMobile = new Regex(MOBILEPATTERN);
        Regex regPassword = new Regex(PASSWORD);

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

        public void emailIDCheck(string pattern)
        {
            if (regEmail.IsMatch(pattern))
            {
                Console.WriteLine("Valid Pattern");
            }
            else
            {
                Console.WriteLine("Invalid Pattern");
            }
        }

        public void mobileCheck(string pattern)
        {
            if (regMobile.IsMatch(pattern))
            {
                Console.WriteLine("Valid Pattern");
            }
            else
            {
                Console.WriteLine("Invalid Pattern");
            }
        }

        public void passwordCheck(string pattern)
        {
            if (regPassword.IsMatch(pattern))
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

            Console.WriteLine("Enter mobile number: ");
            string mobileNumber = Console.ReadLine();
            p1.mobileCheck(mobileNumber);

            Console.WriteLine("Enter your password: ");
            string password = Console.ReadLine();
            p1.passwordCheck(password);

        }
    }
}
