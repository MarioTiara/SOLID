using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApp
{
    public class Shoe:Good
    {
        private readonly double price=43.21;
        public double getPrice(){
            return price;
        }
    }
}