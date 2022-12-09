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
            //UC1
            public static void FirstName()  
            {
                Console.WriteLine("Enter your FirstName");
                string userInput = Console.ReadLine();
                string regexCondition = "^[A-Z]{1}[a-z]{3,}$";
                Iteration(userInput, regexCondition);
            }
           
        }
    }
}
