using DemoLibrary;

namespace ConsoleUI
{   
    internal class Program
    {
        private static void Main(string[] args)
        {
            Person owner = new Person{
              FirstName= "Tim",
              LastName="Corey",
              EmailAddress="mario@gmail.com",
              PhoneNumber="628-2312"  
            };

            Chor chor = new Chor{
                ChoreName="Take out the trash",
                Owner= owner
            };

            chor.Performance(3);
            chor.Performance(1.5);
            chor.CompleteChor();

            Console.ReadLine();
        }
    }

}
