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
            //UC3 Adding Email
            public static void EmailID()       
            {
                Console.WriteLine("Enter your Email ID");
                string userInput = Console.ReadLine();
                string regexCondition = "^[a-z0-9]{1,}([._+-]{1}[a-z0-9]{1,}){0,1}[@]{1}[a-z0-9]{1,}[.]{1}[a-zA-Z]{2,3}([.]{1}[a-z]{2,3}){0,1}$";
                Iteration(userInput, regexCondition);
            }
            //UC4 Adding Mobile Number
            public static void MobileNumber()         
            {
                Console.WriteLine("Enter your Mobile Number");
                string userInput = Console.ReadLine();
                string regexCondition = "^[9]{1}[1]{1}[ ]{1}[1-9]{1}[0-9]{9}$";
                Iteration(userInput, regexCondition);
            }
            //UC5 Setting a Password With Min. 8 Char.
            public static void PassMin8Char()     
            {
                Console.WriteLine("Enter your Password");
                string userInput = Console.ReadLine();
                string regexCondition = "^[a-zA-Z0-9]{8,}$";
                Iteration(userInput, regexCondition);
            }
            //UC6 (min 8 char and atleast 1 upper case in it.
            public static void PassMin8CharAnd1UpperCase() 
            {
                Console.WriteLine("Enter your Password");
                string userInput = Console.ReadLine();
                string regexCondition = "^(?=.*[A-Z]).{1,}[a-zA-Z0-9]{7,}$";
                Iteration(userInput, regexCondition);
            }
        }
    }
}
