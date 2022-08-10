using System;
using System.Collections.Generic;
using Project_Food_Ordering_System_2021_Prototype_1.Controllers;

namespace Project_Food_Ordering_System_2021_Prototype_1.Models
{
    public class Order
    {
        public Guid Order_Id { get; set; }
        public double Total_Amount { get; set; }
        public Guid User_ID { get; set; }
        public DateTime Order_Date { get; set; }
        public string Order_Status { get; set; }
        public string Order_Number { get; set; }
        public CartManager orderCart { get; set; }

        public Order() { }
        public Order(Guid Order_ID, double Total_Amount, Guid User_ID, DateTime Order_Date, string Order_Status, string Order_Number)
        {
            this.Order_Id = Order_Id;
            this.Total_Amount = Total_Amount;
            this.User_ID = User_ID;
            this.Order_Date = Order_Date;
            this.Order_Status = Order_Status;
            this.Order_Number = Order_Number;
        }
        public Order(double Total_Amount, Guid User_ID, DateTime Order_Date,  CartManager orderCart)
        {
            this.Total_Amount = Total_Amount;
            this.User_ID = User_ID;
            this.Order_Date = Order_Date;
            this.orderCart = orderCart;
        }

    }
}