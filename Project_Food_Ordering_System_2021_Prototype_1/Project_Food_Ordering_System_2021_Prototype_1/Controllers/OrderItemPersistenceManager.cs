using System;
using System.Data.SqlClient;
using System.Data;
using Project_Food_Ordering_System_2021_Prototype_1.Database;
using Project_Food_Ordering_System_2021_Prototype_1.Models;
using System.Collections.Generic;

namespace Project_Food_Ordering_System_2021_Prototype_1.Controllers
{
    public class OrderItemPersistenceManager
    {
        public SqlConnection connect;
        public SqlCommand command;
        public DataSet data;
        public SqlDataAdapter adapter;
        public SqlDataReader reader;

        public List<OrderItems> findOrderDetail(Guid order_id, Guid item_id)
        {
            connect = new SqlConnection(DatabaseOperations.conString);
            connect.Open();

            List<OrderItems> itemList = new List<OrderItems>();

            string sqlOrderItem = $"SELECT ItemTable.Item_Name, OrderItemTable.Item_Quantity, OrderTable.Order_Number FROM OrderTable " +
                $"INNER JOIN OrderItemTable ON OrderItemTable.Order_ID = '{order_id}' " +
                $"INNER JOIN ItemTable ON ItemTable.Item_ID = '{item_id}'";

            command = new SqlCommand(sqlOrderItem, connect);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                itemList.Add(new OrderItems((Guid)reader[0], (Guid)reader[1], (int)reader[2]));
            }

            command.Dispose();
            connect.Close();

            return itemList;
        }

        public List<OrderItems> findOrderID(Guid order_id)
        {
            connect = new SqlConnection(DatabaseOperations.conString);
            connect.Open();

            OrderItems OrderItem = new OrderItems();
            List<OrderItems> itemList = new List<OrderItems>();

            string sqlOrderItem = $"SELECT * FROM OrderItemTable WHERE Order_ID = '{order_id}'";

            command = new SqlCommand(sqlOrderItem, connect);

            reader = command.ExecuteReader();
            while (reader.Read())
            {
                itemList.Add(new OrderItems((Guid)reader[1], (Guid)reader[0], (int)reader[2]));
            }

            command.Dispose();
            connect.Close();

            return itemList;
        }

    }

}
