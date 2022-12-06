using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class AccountGenerator
    {
        public static string Create(Person user){
            return $"{user.FirstName.Substring(0,1)}{user.LastName}";
        }

        public static void PrintAccount(Person user){
            Console.WriteLine($"Your username is {Create(user)}");
        }
    }
}