using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public interface IPerson
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string PhoneNumber { get; set; }
        string EmailAddress { get; set; }
    }
}