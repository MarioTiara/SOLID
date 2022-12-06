using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class PersonDataValidator
    {
        public static bool Validate(Person person){

            if (string.IsNullOrWhiteSpace(person.FirstName)){
                StandardMessages.DisplayValidationError("first name");
                return false;
            }

            if (string.IsNullOrWhiteSpace(person.LastName)){
                StandardMessages.DisplayValidationError("last name");
                return false;
            }
            return true;
        }
    }
}