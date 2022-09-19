using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Patterns.UserFirstName();
            Patterns.UserLastName(); 
            Patterns.UserEmail();
            Patterns.UserMobileNumber();
            Patterns.PaswordRule1();
            Patterns.PaswordRule2();
            Patterns.PaswordRule3();
            Console.ReadLine();
        }
    }
}
