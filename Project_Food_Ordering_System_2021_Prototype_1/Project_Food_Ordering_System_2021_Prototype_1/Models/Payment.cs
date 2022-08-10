using System;

namespace Project_Food_Ordering_System_2021_Prototype_1.Models
{
    public class Payment
    {
        public Guid Payment_ID{ get; set; }
        public double Total_Amount { get; set; }
        public double Vat_Amount { get; set; }
        public Guid Order_ID { get; set; }
        public string Payment_Reference { get; set; }
        public DateTime Payment_Date { get; set; }
        public string Order_Number { get; set; }

        public Payment(){}
        public Payment(Guid Payment_ID, double Total_Amount, double Vat_Amount, Guid Order_ID , string Payment_Reference, DateTime Payment_Date, string Order_Number)
        {
            this.Payment_ID = Payment_ID;
            this.Total_Amount = Total_Amount;
            this.Vat_Amount = Vat_Amount;
            this.Order_ID = Order_ID;
            this.Payment_Reference = Payment_Reference;
            this.Payment_Date = Payment_Date;
            this.Order_Number = Order_Number;
        }

        public Payment(double Total_Amount, Guid Order_ID, DateTime Payment_Date, string Order_Number)
        {
            this.Total_Amount = Total_Amount;
            this.Order_ID = Order_ID;
            this.Payment_Date = Payment_Date;
            this.Order_Number = Order_Number;
        }

    }
}