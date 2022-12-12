using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class Chor
    {
        public string ChoreName { get; set; }
        public Person Owner { get; set; }
        public double HoursWorked { get; private set; }
        public bool IsComplete {get;private set;}

        public void Performance (double hours){
            HoursWorked+=hours;
            Logger log=new Logger();
            log.Log($"Performed work on {ChoreName}");
        }

        public void CompleteChor(){
            IsComplete=true;

            Logger log = new Logger();
            log.Log($"Completed {ChoreName}");

            Emailer emailer = new Emailer();
            emailer.SendEmail(Owner, $"The Chore {ChoreName} is complete");
        }
    }
}