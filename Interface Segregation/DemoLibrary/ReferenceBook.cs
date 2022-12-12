using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class ReferenceBook:ILibraryItem
    {
        public string LibraryId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public int CheckoutDurationInDays { get; set; }=0;
        public string Borrower  { get; set; }
        public DateTime BorrowDate { get; set; }

        public void CheckIn()
        {
            throw new NotImplementedException();
        }

        public void CheckOut (string borrower){

        }

        public DateTime GetDueDate()
        {
            throw new NotImplementedException();
        }
    }
}