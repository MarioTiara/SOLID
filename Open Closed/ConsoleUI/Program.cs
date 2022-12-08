using OCPLibrary;

internal class Program
{
    private static void Main(string[] args)
    {
        List<PersonModel> applicants= new List<PersonModel>{
            new PersonModel{FirstName="Tim", LastName="Corey"},
            new PersonModel{FirstName="Sue",LastName="Storm" , TypeOfEmployee=EmployeType.Manager},
            new PersonModel {FirstName="nancy", LastName="Roman", TypeOfEmployee=EmployeType.Executive}
        };

        List<EmployeModel> employes = new List<EmployeModel>();
        Accounts accountsProcessor = new Accounts();

        foreach ( var person in applicants){
            employes.Add(accountsProcessor.Create(person));
        }

        foreach (var emp in employes){
            Console.WriteLine($"{emp.FirstName} {emp.LastName}: {emp.EmailAddress} IsManager:{emp.IsManager} IsExecutive:{emp.IsExecutive}");
        }
    }
}