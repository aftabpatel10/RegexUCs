using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace REGEX_UCs
{
    public class UserRegDetails
    {
        public class UserDetails
        {
            public static void Iteration(string userInput, string regexCondition)
            {
                if (Regex.IsMatch(userInput, regexCondition))
                {
                    Console.WriteLine("Registered Successfully!\n");
                }
                else
                {
                    Console.WriteLine("Entered Details are not in required format.Please try again!\n");
                }
            }
            //UC1 Adding First Name
            public static void FirstName()  
            {
                Console.WriteLine("Enter your FirstName");
                string userInput = Console.ReadLine();
                string regexCondition = "^[A-Z]{1}[a-z]{3,}$";
                Iteration(userInput, regexCondition);
            }
            //UC2 Adding Last Nmae
            public static void LastName()      
            {
                Console.WriteLine("Enter your Last Name");
                string userInput = Console.ReadLine();
                string regexCondition = "^[A-Z]{1}[a-z]{3,}$";
                Iteration(userInput, regexCondition);
            }

        }
    }
}
