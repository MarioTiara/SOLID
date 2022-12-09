using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApp
{
    public class Inventory
    {
        private List<Clothe> clothes= new();
        private List<Hat> hats = new();
        private List<Shoe> shoes= new();

        public void store(Clothe clothe){
            clothes.Add(clothe);
        }

        public void store(Hat hat){
            hats.Add(hat);
        }

        public void store(Shoe shoe){
            shoes.Add(shoe);
        }
    }
}