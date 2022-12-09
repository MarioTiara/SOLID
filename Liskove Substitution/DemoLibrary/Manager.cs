using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class Manager:Employee
    {
        public override void CalculatePerHourRate(int rank)
        {
            decimal baseAmount= 19.75M;
            Salary=baseAmount+(rank*4);
        }

        public void GeneratePerformanceRview(){
            Console.WriteLine("I'm reviewing a direct report's performance.");
        }
    }
}