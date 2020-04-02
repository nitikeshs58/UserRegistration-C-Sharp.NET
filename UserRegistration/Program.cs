using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
        // Email Samples provided seperately
        static string EMAILPATTERN1 = "^([a-z0-9.-]+)$";
        static string EMAILPATTERN2 = "^([a-z0-9.-]+)@([a-z0-9-]+)$";
        static string EMAILPATTERN3 = "^([a-z0-9.-]+)@([a-z0-9-]+).([a-z]{2,8})$";
        static string EMAILPATTERN4 = "^([a-z0-9.-]+)@([a-z0-9-]+).([a-z]{2,8})(.[a-z]{2,8})?$";

        // Regex patteerns
        static string VALIDNAMEPATTERN = "^[A-Z][a-z]{2,}$";
        static string EMAILPATTERN="^([a-z0-9.-]+)@([a-z0-9-]+).([a-z]{2,8})(.[a-z]{2,8})?$";
        static string MOBILEPATTERN="^[0-9]{2} [6-9]{1}[0-9]{9}$";
        static string PASSWORD = "^.*(?=.*[a-z0-9])*(?=.*[A-Z])*([!@#$%^&*]{1})(.{8,})$";

        // created object of Regex
        Regex regName = new Regex(VALIDNAMEPATTERN);
        Regex regEmail = new Regex(EMAILPATTERN);
        Regex regMobile = new Regex(MOBILEPATTERN);
        Regex regPassword = new Regex(PASSWORD);

        // checked first and lastname pattern
        public void NameCheck(string pattern)
        {
            if (regName.IsMatch(pattern))
            {
                Console.WriteLine("Valid Pattern\n");
            }
            else
            {
                Console.WriteLine("Invalid Pattern\n");
            }
        }

        // Checked valid email pattern
        public void emailIDCheck(string pattern)
        {
            if (regEmail.IsMatch(pattern))
            {
                Console.WriteLine("Valid Name Pattern\n");
            }
            else
            {
                Console.WriteLine("Invalid Name Pattern\n");
            }
        }

        // Checked valid mobile pattern
        public void mobileCheck(string pattern)
        {
            if (regMobile.IsMatch(pattern))
            {
                Console.WriteLine("Valid Mobile Number Pattern\n");
            }
            else
            {
                Console.WriteLine("Invalid Mobile Number Pattern\n");
            }
        }

        // Checked valid passowrd pattern
        public void passwordCheck(string pattern)
        {
            if (regPassword.IsMatch(pattern))
            {
                Console.WriteLine("Valid Password Pattern\n");
            }
            else
            {
                Console.WriteLine("Invalid Password Pattern\n");
            }
        }

        // Main Method
        static void Main(string[] args)
        {
            Console.WriteLine("!!! Welcome to the User registration Problem.!!!");

            // Created Program class object p1
            Program p1 = new Program();

            Console.WriteLine("Enter first name: ");
            string firstName=Console.ReadLine();
            //method calling with class object
            p1.NameCheck(firstName);

            Console.WriteLine("Enter last name: ");
            string lastName = Console.ReadLine();
            //method calling with class object
            p1.NameCheck(lastName);

            Console.WriteLine("Enter Email ID: ");
            string emailID = Console.ReadLine();
            //method calling with class object
            p1.emailIDCheck(emailID);

            Console.WriteLine("Enter mobile number: ");
            string mobileNumber = Console.ReadLine();
            //method calling with class object
            p1.mobileCheck(mobileNumber);

            Console.WriteLine("Enter your password: ");
            string password = Console.ReadLine();
            //method calling with class object
            p1.passwordCheck(password);

        }
    }
}
