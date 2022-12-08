using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OCPLibrary
{
    public class Accounts
    {
        public EmployeModel Create(PersonModel person){
            EmployeModel output = new EmployeModel();
            output.FirstName=person.FirstName;
            output.LastName=person.LastName;
            output.EmailAddress=$"{person.FirstName.Substring(0,1)}{person.LastName}@gmail.com";
            // if (person.TypeOfEmployee==EmployeType.Manager){
            //     output.IsManager=true;
            // }

            switch (person.TypeOfEmployee){
                case EmployeType.Staff:
                    break;
                case EmployeType.Manager:
                    output.IsManager=true;
                    break;
                case EmployeType.Executive:
                    output.IsManager=true;
                    output.IsExecutive=true;
                    break;
                default:
                    break;
            }
            
            return output;
        }
    }
}