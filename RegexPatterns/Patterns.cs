﻿using System;
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

            if (Regex.IsMatch(FirstName, pattern))
                Console.WriteLine("User FirstName is Valid");
            else
            {
                Console.WriteLine("FirstName is invalid");
            }
        }
        public static void UserLastName()
        {
            Console.WriteLine("Enter the last Name : ");
            string FirstName = Console.ReadLine();
            string pattern = "^[A-Z]{1}[A-Z a-z]{2,}$";

            if (Regex.IsMatch(FirstName, pattern))
                Console.WriteLine("User LastName is Valid");
            else
            {
                Console.WriteLine("LastName is invalid");
            }
        }
        public static void UserEmail()
        {
            Console.WriteLine("Enter email");
            string mail = Console.ReadLine();
            string pattern = "^([A - Za - z0 - 9] +[.#+_])*[A-Za-z0-9]+[@][A-Za-z]+[.][A-Za-z]{2,3}([.][A-Za-z]{2})?$";
            if (Regex.IsMatch(mail, pattern))
                Console.WriteLine("Entered user email is valid");
            else
            {
                Console.WriteLine("Entered user email invalid");
            }
        }
    }
}