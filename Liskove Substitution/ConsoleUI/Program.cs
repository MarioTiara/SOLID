using DemoLibrary;
namespace ConsoleUI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Manager accountingVP= new Manager();
            accountingVP.FirstName="mario";
            accountingVP.LastName="pratama";
            accountingVP.CalculatePerHourRate(4);

            Employee emp=  new Manager();

            emp.FirstName= "Badu";
            emp.LastName="putra";
            emp.AssignManager(accountingVP);
            emp.CalculatePerHourRate(2);

            Console.WriteLine($"{emp.FirstName}'s salary is ${emp.Salary}/hour.");
            Console.ReadLine();
        }
    }
}
