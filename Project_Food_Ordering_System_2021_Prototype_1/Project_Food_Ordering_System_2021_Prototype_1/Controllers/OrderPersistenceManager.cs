using System;
using System.Data.SqlClient;
using System.Data;
using Project_Food_Ordering_System_2021_Prototype_1.Database;
using Project_Food_Ordering_System_2021_Prototype_1.Models;
using System.Collections.Generic;

namespace Project_Food_Ordering_System_2021_Prototype_1.Controllers
{
    public class OrderPersistenceManager
    {
        public SqlConnection connect;
        public SqlCommand command;
        public DataSet data;
        public SqlDataAdapter adapter;
        public SqlDataReader reader;

        public List<Order> getAllByDateRange(DateTime startDate, DateTime enddate)
        {
            connect = new SqlConnection(DatabaseOperations.conString);
            connect.Open();

            List<Order> orders = new List<Order> { };

            string sqlOrder = $"SELECT * FROM OrderTable WHERE Order_Date BETWEEN '{startDate}' AND '{enddate}'";
            command = new SqlCommand(sqlOrder, connect);


            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Order order = new Order();
                order.Order_Id = (Guid)reader[0];
                order.Total_Amount = double.Parse(reader[1].ToString());
                //order.User_ID = (Guid)reader[2];
                order.Order_Date = (DateTime)reader[3];
                order.Order_Status = reader[4].ToString();
                order.Order_Number = reader[5].ToString();
                orders.Add(order);
            }

            command.Dispose();
            connect.Close();

            return orders;
        }

        public List<Order> FindOrderByStatusAndDateRange(DateTime startDate, DateTime enddate, string orderStatus)
        {
            connect = new SqlConnection(DatabaseOperations.conString);
            connect.Open();

            List<Order> orders = new List<Order> { };

            string sqlOrder = $"SELECT * FROM OrderTable WHERE Order_Date BETWEEN '{startDate}' AND '{enddate}' AND Order_Status = '{orderStatus}'";
            command = new SqlCommand(sqlOrder, connect);


            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Order order = new Order();
                order.Order_Id = new Guid(reader[0].ToString());
                order.Total_Amount = Double.Parse(reader[1].ToString());
                //order.User_ID = new Guid(reader[2].ToString());
                order.Order_Date = Convert.ToDateTime(reader[3].ToString());
                order.Order_Status = reader[4].ToString();
                order.Order_Number = reader[5].ToString();
                orders.Add(order);
            }

            command.Dispose();
            connect.Close();

            return orders;
        }

        public Order findOrder(string OrderNumber)
        {
            connect = new SqlConnection(DatabaseOperations.conString);
            connect.Open();

            Order order = new Order();

            string sqlOrder = $"SELECT * FROM OrderTable WHERE Order_Number = {OrderNumber}";
            command = new SqlCommand(sqlOrder, connect);

            reader = command.ExecuteReader();
            while (reader.Read())
            {
                order.Order_Id = new Guid(reader[0].ToString());
                order.Total_Amount = Double.Parse(reader[1].ToString());
                order.User_ID = new Guid(reader[2].ToString());
                order.Order_Date = Convert.ToDateTime(reader[3].ToString());
                order.Order_Status = reader[4].ToString();
                order.Order_Number = reader[5].ToString();
            }

            command.Dispose();
            connect.Close();

            return order;
        }

        public Order findOrderGuid(Guid guid)
        {
            connect = new SqlConnection(DatabaseOperations.conString);
            connect.Open();

            Order order = new Order();

            string sqlOrder = $"SELECT * FROM OrderTable WHERE Order_ID = '{guid}'";
            command = new SqlCommand(sqlOrder, connect);

            reader = command.ExecuteReader();
            while (reader.Read())
            {
                order.Order_Id = new Guid(reader[0].ToString());
                order.Total_Amount = Double.Parse(reader[1].ToString());
                order.User_ID = new Guid(reader[2].ToString());
                order.Order_Date = Convert.ToDateTime(reader[3].ToString());
                order.Order_Status = reader[4].ToString();
                order.Order_Number = reader[5].ToString();
            }

            command.Dispose();
            connect.Close();

            return order;
        }

        public Guid insertOrder(Order order)
        {
            Guid guid = Guid.NewGuid();
            string sqlOrder = "";

            connect = new SqlConnection(DatabaseOperations.conString);
            connect.Open();

            sqlOrder = $"INSERT INTO OrderTable (Order_ID, Total_Amount, User_ID, Order_Date) VALUES ('{guid}', {order.Total_Amount}, " +
                    $"'{order.User_ID}', '{DateTime.Now.ToString("MM-dd-yyyy")}')";
            
            command = new SqlCommand(sqlOrder, connect);
            command.ExecuteNonQuery();

            for (int i = 0; i < order.orderCart.itemsList.Count; i++)
            {
                string sqlOrderItem = $"INSERT INTO OrderItemTable VALUES ('{order.orderCart.itemsList[i].item.Item_ID}', '{guid}', {order.orderCart.itemsList[i].quantity})";
                command = new SqlCommand(sqlOrderItem, connect);
                command.ExecuteNonQuery();
            }

            command.Dispose();

            for (int i = 0; i < order.orderCart.itemsList.Count; i++)
            {
                string sqlStockItem = $"UPDATE StockTable SET Quantity = Quantity - {order.orderCart.itemsList[i].quantity} WHERE Item_ID = '{order.orderCart.itemsList[i].item.Item_ID}'";
                command = new SqlCommand(sqlStockItem, connect);
                command.ExecuteNonQuery();
            }

            command.Dispose();

            command.Dispose();
            connect.Close();
            return guid;
        }

        public void removeOrder(Guid order_id)
        {
            connect = new SqlConnection(DatabaseOperations.conString);
            connect.Open();

            string sqlOrder = $"DELETE FROM OrderTable WHERE Order_ID =  @OrderId";
            command = new SqlCommand(sqlOrder, connect);
            command.Parameters.Add("@OrderId", SqlDbType.UniqueIdentifier);
            command.Parameters["@OrderId"].Value = order_id;
            adapter = new SqlDataAdapter();

            adapter.DeleteCommand = new SqlCommand(sqlOrder, connect);
            adapter.DeleteCommand.ExecuteNonQuery();

            command.Dispose();
            connect.Close();
        }

        public void updateOrder(Order order)
        {
            connect = new SqlConnection(DatabaseOperations.conString);
            connect.Open();


            string sqlOrder = $"UPDATE  OrderTable SET Total_Amount =  @TotalAmount, User_ID = @UserID," +
                $"  Order_Date = @OrderDate, Order_Status = @OrderStatus , Order_Number = @OrderNumber WHERE Order_ID = @OrderID";
            command = new SqlCommand(sqlOrder, connect);

            command.Parameters.Add("@OrderID", SqlDbType.UniqueIdentifier);
            command.Parameters["@OrderID"].Value = order;
            command.Parameters.Add("@TotalAmount", SqlDbType.Decimal);
            command.Parameters["@TotalAmount"].Value = order.Total_Amount;
            command.Parameters.Add("@UserID", SqlDbType.UniqueIdentifier);
            command.Parameters["@UserID"].Value = order.User_ID;
            command.Parameters.Add("@OrderID", SqlDbType.DateTime);
            command.Parameters["@OrderID"].Value = order.Order_Date;
            command.Parameters.AddWithValue("@OrderStatus", order.Order_Status);
            command.Parameters.AddWithValue("@OrderNumber", order.Order_Number);

            adapter = new SqlDataAdapter();

            adapter.UpdateCommand = new SqlCommand(sqlOrder, connect);
            adapter.UpdateCommand.ExecuteNonQuery();

            command.Dispose();
            connect.Close();
        }

        public void updateOrderStatus(Order order, string status)
        {
            string sql = $"UPDATE OrderTable SET Order_Status = '{status}' WHERE Order_ID = '{order.Order_Id}'";

            connect = new SqlConnection(DatabaseOperations.conString);
            connect.Open();

            command = new SqlCommand(sql, connect);
            adapter = new SqlDataAdapter();

            adapter.InsertCommand = new SqlCommand(sql, connect);
            adapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
            connect.Close();
        }

        public List<Order> findStudentOrders(Guid user_id)
        {
            connect = new SqlConnection(DatabaseOperations.conString);
            connect.Open();

            List<Order> orderList = new List<Order>();

            string sqlOrder = $"SELECT * FROM OrderTable WHERE User_ID = '{user_id}' ORDER BY Order_Date DESC";
            command = new SqlCommand(sqlOrder, connect);

            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Order order = new Order();
                order.Order_Id = new Guid(reader[0].ToString());
                order.Total_Amount = Double.Parse(reader[1].ToString());
                order.User_ID = new Guid(reader[2].ToString());
                order.Order_Date = (DateTime)reader[3];
                order.Order_Status = reader[4].ToString();
                order.Order_Number = reader[5].ToString();
                orderList.Add(order);
            }

            command.Dispose();
            connect.Close();

            return orderList;
        }
    }
}
