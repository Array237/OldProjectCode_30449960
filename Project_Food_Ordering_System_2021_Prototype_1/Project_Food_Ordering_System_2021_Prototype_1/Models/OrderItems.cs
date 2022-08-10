using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_Food_Ordering_System_2021_Prototype_1.Models
{
    public class OrderItems
    {
        public Guid Order_ID { get; set; }
        public Guid Item_ID { get; set; }
        public int Quantity { get; set; }

        public OrderItems() { }

        public OrderItems(Guid Order_ID, Guid Item_ID, int Quantity)
        {
            this.Order_ID = Order_ID;
            this.Item_ID = Item_ID;
            this.Quantity = Quantity;
        }

    }
}