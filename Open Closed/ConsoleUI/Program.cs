using OCPLibrary;

internal class Program
{
    private static void Main(string[] args)
    {
        List<IApplicantModel> applicants= new List<IApplicantModel>{
            new PersonModel{FirstName="Tim", LastName="Corey"},
            new ManagerModel{FirstName="Sue",LastName="Storm" },
            new ExecutiveModel {FirstName="nancy", LastName="Roman"}
        };

        List<EmployeModel> employes = new List<EmployeModel>();
      
        foreach ( var person in applicants){
            employes.Add(person.AccountPorcessor.Create(person));
        }

        foreach (var emp in employes){
            Console.WriteLine($"{emp.FirstName} {emp.LastName}: {emp.EmailAddress} IsManager:{emp.IsManager} IsExecutive:{emp.IsExecutive}");
        }
    }
}