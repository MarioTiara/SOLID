using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApp
{
    public class Hat :Good
    {
        private readonly double price =25;
        public double getPrice(){
            return price;
        }
    }
}