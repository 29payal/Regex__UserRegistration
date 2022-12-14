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
                Console.WriteLine("_________Entered user email is valid_____________");
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
        public static void PaswordRule1()
        {
            //rule1= minimum 8 characters in the password
            Console.WriteLine("|| Enter the password for rule first ||");
            string rule1 = Console.ReadLine();
            string pattern = "^[A-Za-z0-9]{8,}$";
            if (Regex.IsMatch(rule1, pattern))
                Console.WriteLine("_________Password is valid_______");
            else
            {
                Console.WriteLine("________Password is invalid___________");
            }
        }
        public static void PaswordRule2()
        {
            //rule2= One upper case in the password
            Console.WriteLine("|| Enter the password for rule second ||");
            string rule2 = Console.ReadLine();
            string pattern = "^[A-Z]{1,}[A-Za-z0-9]{7,}$";
            if (Regex.IsMatch(rule2, pattern))
                Console.WriteLine("_________Password is valid_______");
            else
            {
                Console.WriteLine("________Password is invalid_______");
            }
        }
        public static void PaswordRule3()
        {
            //rule3= One numberic number in the password
            Console.WriteLine("|| Enter the password for rule third ||");
            string rule3 = Console.ReadLine();
            string pattern = "^[A-Za-z0-9]{1,}[A-Za-z0-9]{6,}$";
            if (Regex.IsMatch(rule3, pattern))
                Console.WriteLine("_________Password is valid_______");
            else
            {
                Console.WriteLine("________Password is invalid_______");
            }
        }
        public static void PaswordRule4()
        {
            //rule4= One speical character in the password
            Console.WriteLine("|| Enter the password for rule fourth  ||");
            string rule4 = Console.ReadLine();
            string pattern = "^[A-Za-z0-9!@#$%^&*]{1,}[A-Za-z0-9!@#$%^&*]{6,}$";
            if (Regex.IsMatch(rule4, pattern))
                Console.WriteLine("_________Password is valid_______");
            else
            {
                Console.WriteLine("________Password is invalid_______");
            }
        }
    }
}