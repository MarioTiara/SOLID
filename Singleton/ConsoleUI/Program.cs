using System.Collections;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            StandardMessages.WelcomeMessage();
            //Ask for user Information
            var user =PersonDataCapture.Capture();
            //check to be sure the first and last names are valid
            bool isUserValid=PersonDataValidator.Validate(user);
            if (!isUserValid){
                StandardMessages.EndApplication();
                return;
            }
            //create a username for the person
            AccountGenerator.PrintAccount(user);
            StandardMessages.EndApplication();
        }

    }

}
