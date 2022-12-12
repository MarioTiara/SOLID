using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class DVD:ILibraryItem
    {
        public string Author { get; set; }="";
        public DateTime BorrowDate { get ; set ; }
        public string Borrower { get ; set; }
        public int CheckoutDurationInDays { get ; set; }=14;
        public string LibraryId { get ; set ; }
        public int Pages { get ; set ; }=-1;
        public string Title { get ; set ; }
        public List<string> Actors { get; set; }
        public int RuntimeInMinutes { get; set; }

        public void CheckIn()
        {
            Borrower="";
        }

        public void CheckOut(string borrower)
        {
            Borrower=borrower;
            BorrowDate=DateTime.Now;
        }

        public DateTime GetDueDate()
        {
            return BorrowDate.AddDays(CheckoutDurationInDays);
        }
    }
}