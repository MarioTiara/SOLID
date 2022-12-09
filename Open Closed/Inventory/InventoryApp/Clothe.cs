using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApp
{
    public class Clothe:Good
    {
        private readonly double price=30.24;
        public double getPrice(){
            return price;
        }
    }
}