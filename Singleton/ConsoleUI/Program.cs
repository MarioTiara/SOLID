using System.Collections;
using ConsoleUI;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to my Application");

        //Ask for user Information
        Person user= new Person();

        Console.Write("What is your first name:");
        user.FirstName= Console.ReadLine();

        Console.Write("What is your last name:");
        user.LastName=Console.ReadLine();

        //check to be sure the first and last names are valid
        if (string.IsNullOrWhiteSpace(user.FirstName)){
            Console.WriteLine("You did not give us a valid first name!");
            Console.ReadLine();
            return;
        }

        if (string.IsNullOrWhiteSpace(user.LastName)){
            Console.WriteLine("You di not give us a valid las name!");
        }

        //create a username for the person
        Console.WriteLine($"Your username is {user.FirstName.Substring(0,1)}{user.LastName}");

        Console.ReadLine();


    }
}