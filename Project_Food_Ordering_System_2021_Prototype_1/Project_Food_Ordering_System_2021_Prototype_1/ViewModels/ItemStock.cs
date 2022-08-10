using System;

namespace Project_Food_Ordering_System_2021_Prototype_1.ViewModels
{
    public class ItemStock
    {
        public string Item_Name { get; set; }
        public int Quantity { get; set; }

        public ItemStock() { }
        public ItemStock(string Item_Name, int Quantity)
        {
            this.Item_Name = Item_Name;
            this.Quantity = Quantity;
        }
      
    }
}