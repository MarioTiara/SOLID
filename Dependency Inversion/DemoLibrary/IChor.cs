using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public interface IChor
    {
        string ChoreName { get; set; }
        IPerson Owner { get; set; }
        double HoursWorked { get; }
        bool IsComplete { get; }

        void CompleteChor();
        void Performance(double hours);
    }
}