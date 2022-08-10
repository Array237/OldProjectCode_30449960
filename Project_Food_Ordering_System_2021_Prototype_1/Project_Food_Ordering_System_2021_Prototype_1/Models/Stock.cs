using System;

namespace Project_Food_Ordering_System_2021_Prototype_1.Models
{
    public class Stock
    {
        public Guid Stock_ID{ get; set; }
        public Guid Item_ID { get; set; }
        public int Quantity { get; set; }

        public Stock(){}
        public Stock(Guid Stock_ID, Guid Item_ID, int Quantity)
        {
            this.Stock_ID = Stock_ID;
            this.Item_ID = Item_ID;
            this.Quantity = Quantity;
        }
        public Stock(Guid Item_ID, int Quantity)
        {
            this.Item_ID = Item_ID;
            this.Quantity = Quantity;
        }
    }
}