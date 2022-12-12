using DemoLibrary;

namespace ConsoleUI
{   
    internal class Program
    {
        private static void Main(string[] args)
        {
            IPerson owner = Factory.CreatePerson();
            owner.FirstName= "Tim";
            owner.LastName="Corey";
            owner.EmailAddress="mario@gmail.com";
            owner.PhoneNumber="628-2312";
        

            IChor chor = Factory.CreateChor();
            chor.ChoreName="Take out the trash";
            chor.Owner= owner;
            

            chor.Performance(3);
            chor.Performance(1.5);
            chor.CompleteChor();

            Console.ReadLine();
        }
    }

}
