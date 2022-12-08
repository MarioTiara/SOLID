using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OCPLibrary
{
    public class ExecutiveModel : IApplicantModel
    {
        public string FirstName { get; set ; }
        public string LastName { get; set; }
        public IAccounts AccountPorcessor { get ; set ; }= new ExecutiveAccount();
    }
}