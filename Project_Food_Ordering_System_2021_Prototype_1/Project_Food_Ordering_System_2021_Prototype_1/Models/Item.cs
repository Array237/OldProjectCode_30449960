using System;
using Project_Food_Ordering_System_2021_Prototype_1.Controllers;

namespace Project_Food_Ordering_System_2021_Prototype_1.Models
{
    public class Item 
    {
        public Guid Item_ID { get; set; }
        public double Item_Price { get; set; }
        public string Item_Name { get; set; }
        public string Category { get; set; }

        public Item() { }
        public Item(Guid Item_ID, double Item_Price, string Item_Name, string Category)
        {
            this.Item_ID = Item_ID;
            this.Item_Price = Item_Price;
            this.Item_Name = Item_Name;
            this.Category = Category;
        }

        public Item(double Item_Price, string Item_Name, string Category)
        {
            this.Item_ID = Item_ID;
            this.Item_Price = Item_Price;
            this.Item_Name = Item_Name;
            this.Category = Category;
        }
    }
}