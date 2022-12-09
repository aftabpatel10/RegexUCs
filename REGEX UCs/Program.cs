using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static REGEX_UCs.UserRegDetails;

namespace REGEX_UCs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User Registration using Regex.\n");
            while (true)
            {
                Console.WriteLine("\nPlease select any one from below :\n" +
                "Press 1: To Register your First Name.\n" +
                "Press 2: To Register your Last Name \n" +
                "Press 3: To Register your EmailID\n" +
                "Press 4: to enter your Mobile Number.\n" +
                "Press 5: To set your password (minimum 8 characters).");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        UserDetails.FirstName();
                        break;
                    case 2:
                        UserDetails.LastName();
                        break;
                    case 3:
                        UserDetails.EmailID(); 
                        break;
                     case 4:
                            UserDetails.MobileNumber();
                        break;
                    case 5:
                        UserDetails.PassMin8Char();
                        break;
                    default:
                        Console.WriteLine("Invalid option selected ,Please try again !");
                        break;
                }
            }
        }
    }
    
}
