namespace InventoryApp{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var inventory = new Inventory();

            inventory.store(new Clothe());
            inventory.store(new Shoe());
            inventory.store(new Hat());
        }
    }   
}
