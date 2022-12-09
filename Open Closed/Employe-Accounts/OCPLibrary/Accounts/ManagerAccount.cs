using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OCPLibrary
{
    public class ManagerAccount : IAccounts
    {
        public EmployeModel Create(IApplicantModel person)
        {
            EmployeModel output = new EmployeModel();
            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAddress = $"{person.FirstName.Substring(0, 1)}{person.LastName}@gmail.com";
            output.IsManager=true;
            return output;
        }
    }
}