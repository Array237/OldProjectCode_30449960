using System;
using System.Data.SqlClient;
using System.Data;
using Project_Food_Ordering_System_2021_Prototype_1.Database;
using Project_Food_Ordering_System_2021_Prototype_1.Models;
using System.Collections.Generic;

namespace Project_Food_Ordering_System_2021_Prototype_1.Controllers
{
    public class PaymentPersistenceManager
    {
        public SqlConnection connect;
        public SqlCommand command;
        public DataSet data;
        public SqlDataAdapter adapter;
        public SqlDataReader reader;

        public void insertPayment(Payment payment)
        {
            Guid guid = Guid.NewGuid();

            connect = new SqlConnection(DatabaseOperations.conString);
            connect.Open();


            string sqlPayment = $"INSERT INTO PaymentTable (Payment_ID, Total_Amount, Vat_Amount, Order_ID, Payment_Date, Order_Number) VALUES" +
                $"('{guid}', {payment.Total_Amount}, {payment.Total_Amount * 0.15}, '{payment.Order_ID}', '{DateTime.Now.ToString("MM-dd-yyyy")}', {payment.Order_Number})";

            command = new SqlCommand(sqlPayment, connect);

            command.ExecuteNonQuery();

            command.Dispose();
            connect.Close();
        }

        public List<Payment> findPayment(DateTime startDate, DateTime enddate)
        {
            connect = new SqlConnection(DatabaseOperations.conString);
            connect.Open();

            List<Payment> payments = new List<Payment> { };

            string sqlPayment = $"SELECT * FROM PaymentTable WHERE Payment_Date BETWEEN '{enddate}' AND '{startDate}' ORDER BY Payment_Date ASC";
            command = new SqlCommand(sqlPayment, connect);

            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Payment payment = new Payment();
                payment.Payment_ID = new Guid(reader[0].ToString());
                payment.Total_Amount = Double.Parse(reader[1].ToString());
                payment.Vat_Amount = Double.Parse(reader[2].ToString());
                payment.Order_ID = new Guid(reader[3].ToString());
                payment.Payment_Reference = (reader[4].ToString());
                payment.Payment_Date = ((DateTime)reader[5]);
                payment.Order_Number = (reader[6].ToString());
                payments.Add(payment);
            }
            command.Dispose();
            reader.Close();
            return payments;
        }

    }
}
