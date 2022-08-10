using System;
using Project_Food_Ordering_System_2021_Prototype_1.Models;

namespace Project_Food_Ordering_System_2021_Prototype_1.ViewModels

{
    public class CartItem : IEquatable<CartItem>
    {
        public Item item { get; set; }
        public int quantity { get; set; }
        public double Total_Price { get { return item.Item_Price * quantity; } }

        public bool Equals(CartItem item2)
        {
            return item2.item.Item_ID == this.item.Item_ID;
        }

        public CartItem(Item item)
        {
            this.item = item;
            quantity = 1;
        }

    }
}