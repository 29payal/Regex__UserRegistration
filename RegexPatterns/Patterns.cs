using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPatterns
{
    public class Patterns
    {
        public static void UserFirstName()
        {
            Console.WriteLine("|| Enter the First Name ||  ");
            string FirstName = Console.ReadLine();
            string pattern = "^[A-Z]{1}[A-Z a-z]{2,}$";

            if (Regex.IsMatch(FirstName, pattern))
                Console.WriteLine("_____User FirstName is Valid_______");
            else
            {
                Console.WriteLine("_______FirstName is invalid__________");
            }
        }
        public static void UserLastName()
        {
            Console.WriteLine("|| Enter the last Name || ");
            string FirstName = Console.ReadLine();
            string pattern = "^[A-Z]{1}[A-Z a-z]{2,}$";

            if (Regex.IsMatch(FirstName, pattern))
                Console.WriteLine("_______User LastName is Valid___________");
            else
            {
                Console.WriteLine("________LastName is invalid___________");
            }
        }
        public static void UserEmail()
        {
            Console.WriteLine("||  Enter email ||");
            string mail = Console.ReadLine();
            string pattern = "^([A - Za - z0 - 9] +[.#+_])*[A-Za-z0-9]+[@][A-Za-z]+[.][A-Za-z]{2,3}([.][A-Za-z]{2})?$";
            if (Regex.IsMatch(mail, pattern))
                Console.WriteLine( "_________Entered user email is valid_____________");
            else
            {
                Console.WriteLine("____________Entered user email invalid__________");
            }
        }
        public static void UserMobileNumber()
        {
                Console.WriteLine("||  Enter Mobile Number  ||");
                string mobileNumber = Console.ReadLine();
            string pattern = "^[1-9]{2}[ ]{1}[1-9]{1}[0-9]{9}$";
            if (Regex.IsMatch(mobileNumber, pattern))
                    Console.WriteLine("________Mobile Number is Valid_______");
                else
                {
                    Console.WriteLine("_________User Mobile number is invalid_________");
                }
            }
    }
}