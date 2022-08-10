using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using Project_Food_Ordering_System_2021_Prototype_1.Models;
using Project_Food_Ordering_System_2021_Prototype_1.ViewModels;
using Project_Food_Ordering_System_2021_Prototype_1.Database;

namespace Project_Food_Ordering_System_2021_Prototype_1.Controllers
{
    public class StockPersistenceManager
    {
        public SqlConnection connect;
        public SqlCommand command;
        public DataSet data;
        public SqlDataAdapter adapter;
        public SqlDataReader reader;

        public Stock findStock(Guid item_id)
        {
            connect = new SqlConnection(DatabaseOperations.conString);
            connect.Open();

            Stock stock = new Stock();

            string sqlStock = $"SELECT * FROM StockTable WHERE Item_ID = @item_id";

            command = new SqlCommand(sqlStock, connect);
            command.Parameters.AddWithValue("@item_id", item_id);

            reader = command.ExecuteReader();

            while (reader.Read())
            {
                stock.Stock_ID = new Guid(reader[0].ToString());
                stock.Item_ID = new Guid(reader[1].ToString());
                stock.Quantity = (int)reader[2];
            }

            command.Dispose();
            connect.Close();

            return stock;
        }

        public List<Stock> getAll()
        {
            Stock stock;
            List<Stock> stockList = new List<Stock>();
            connect = new SqlConnection(DatabaseOperations.conString);
            connect.Open();

            string sqlStock = $"SELECT * FROM StockTable";

            command = new SqlCommand(sqlStock, connect);

            reader = command.ExecuteReader();
            while (reader.Read())
            {
                stock = new Stock((Guid)reader[0], (Guid)reader[1], (int)reader[2]);
                stockList.Add(stock);
            }

            command.Dispose();
            connect.Close();

            return stockList;
        }

        public List<ItemStock> getAllStockWithItemName()
        {
            ItemStock itemStock;
            List<ItemStock> itemStockList = new List<ItemStock>();
            connect = new SqlConnection(DatabaseOperations.conString);
            connect.Open();

            string sqlStock = $"SELECT ItemTable.Item_Name, StockTable.Quantity FROM StockTable JOIN ItemTable ON ItemTable.Item_ID = StockTable.Item_ID " +
                $"WHERE NOT ItemTable.Category = 'Fast Food' ORDER BY StockTable.Quantity ASC";

            command = new SqlCommand(sqlStock, connect);

            reader = command.ExecuteReader();

            while (reader.Read())
            {
                itemStock = new ItemStock(reader[0].ToString() , (int)reader[1]);
                itemStockList.Add(itemStock);
            }

            command.Dispose();
            connect.Close();

            return itemStockList;
        }

        public void insertStock(Stock stock)
        {
            Guid guid = Guid.NewGuid();

            connect = new SqlConnection(DatabaseOperations.conString);
            connect.Open();

            string sqlStock = $"INSERT INTO StockTable VALUES ('{guid.ToString()}', '{stock.Item_ID.ToString()}', {stock.Quantity})";
            command = new SqlCommand(sqlStock, connect);

            command.ExecuteNonQuery();

            command.Dispose();
            connect.Close();
        }

        public void removeStock(Guid stock_id)
        {
            connect = new SqlConnection(DatabaseOperations.conString);
            connect.Open();

            string sqlStock = $"DELETE FROM ItemTable WHERE Stock_ID = @stock_id";

            command = new SqlCommand(sqlStock, connect);

            command.Parameters.Add("@stock_id", SqlDbType.UniqueIdentifier);
            command.Parameters["@ItemID"].Value = stock_id;
            adapter = new SqlDataAdapter();

            adapter.DeleteCommand = new SqlCommand(sqlStock, connect);
            adapter.DeleteCommand.ExecuteNonQuery();

            command.Dispose();
            connect.Close();
        }

        public void addStock(Guid item_id, int quantity)
        {
            connect = new SqlConnection(DatabaseOperations.conString);
            connect.Open();

            string sqlUser = $"UPDATE StockTable SET Quantity = Quantity + {quantity} WHERE Item_ID = '{item_id}'";
            command = new SqlCommand(sqlUser, connect);

            command.ExecuteNonQuery();

            command.Dispose();
            connect.Close();
        }

        public bool getQuantity(Guid item_id)
        {
            bool isStock;
            connect = new SqlConnection(DatabaseOperations.conString);
            connect.Open();

            string sqlUser = $"SELECT Quantity FROM StockTable WHERE Item_ID = '{item_id}'";
            command = new SqlCommand(sqlUser, connect);

            reader = command.ExecuteReader();

            isStock = (int)reader[0] > 0;

            command.Dispose();
            connect.Close();

            return isStock;
        }
    }
}
