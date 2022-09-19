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
            Console.WriteLine("Enter the First Name : ");
            string FirstName = Console.ReadLine();
            string pattern = "^[A-Z]{1}[A-Z a-z]{2,}$";

            if (Regex.IsMatch(FirstName,pattern))
                Console.WriteLine("User Name is Valid");
            else
            {
                Console.WriteLine("Name is invalid");
            }
        }
    }
}
