using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OCPLibrary
{
    public class ManagerModel : IApplicantModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IAccounts AccountPorcessor { get; set; } = new ManagerAccount();
    }
}