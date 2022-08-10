using System;
using System.Collections.Generic;
using Project_Food_Ordering_System_2021_Prototype_1.Models;

namespace Project_Food_Ordering_System_2021_Prototype_1.Controllers
{
    public class CartManager
    {
        ItemPersistenceManager itemManage = new ItemPersistenceManager();

        public List<CartItem> itemsList { get; set; }

        public CartManager()
        {
            itemsList = new List<CartItem>();
        }

        public void addItem(Item item)
        {
            bool looking = true;
            int i = 0;

            while (looking && i < itemsList.Count)
            {
                looking = itemsList[i].item.Item_ID != item.Item_ID;

                if (looking)
                {
                    i++;
                }
            }

            if (looking)
            {
                itemsList.Add(new CartItem(item));
            }
            else
            {
                itemsList[i].quantity++;
            }
        }

        public void clearCart()
        {
            itemsList.Clear();
        }

        //Might remove this method
        public void setItemQuantity(Item item, int quantity)
        {
            if (quantity == 0)
            {
                RemoveItem(item);
                return;
            }

            CartItem updateItem = new CartItem(item);

            foreach (CartItem i in itemsList)
            {
                if (i.Equals(updateItem.item.Item_ID))
                {
                    i.quantity = quantity;
                    return;
                }
            }

        }

        public void DecreaseItem(Item item)
        {
            CartItem decreaseItem = new CartItem(item);

            foreach (CartItem i in itemsList)
            {
                if (i.item == decreaseItem.item)
                {
                    i.quantity = i.quantity - 1;
                    if (i.quantity == 0)
                    {
                        RemoveItem(item);
                    }
                    return;
                }
            }

        }

        public void RemoveItem(Item item)
        {
            CartItem removedItem = new CartItem(item);
            itemsList.Remove(removedItem);

            //itemsList.Remove(removedItem);
        }

        public double getTotal()
        {
            double total = 0;
            for (int i = 0; i < itemsList.Count; i++)
            {
                total += (itemsList[i].Total_Price);
            }

            return total;
        }

        public string[] ProductList()
        {
            string[] ArrOut = new string[itemsList.Count];

            for (int i = 0; i < itemsList.Count; i++)
            {
                var sb = String.Format("{0,-20} x {1,15} = {2,15}", 
                    itemsList[i].item.Item_Name, itemsList[i].quantity, itemsList[i].Total_Price.ToString("C"));

                ArrOut[i] = sb;

            }

            return ArrOut;
        }
    }
}