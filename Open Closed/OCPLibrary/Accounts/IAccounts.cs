using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OCPLibrary
{
    public interface IAccounts
    {
        EmployeModel Create(IApplicantModel person);
    }
}