using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class PersonDataCapture
    {
        public static Person Capture(){
            Person user= new Person();

            Console.Write("What is your first name:");
            user.FirstName= Console.ReadLine();

            Console.Write("What is your last name:");
            user.LastName=Console.ReadLine();
            
            return user;
        }
    }
}