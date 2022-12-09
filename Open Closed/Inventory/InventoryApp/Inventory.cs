using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApp
{
    public class Inventory
    {
        private List<Good> goods= new();

        public void store(Good good){
            goods.Add(good);
        }

        public List<Good> GetGoods(){
            return goods;
        }
    }
}