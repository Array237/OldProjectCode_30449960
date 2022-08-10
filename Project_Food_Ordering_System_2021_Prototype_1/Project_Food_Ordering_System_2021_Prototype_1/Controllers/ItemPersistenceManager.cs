using System;
using System.Data.SqlClient;
using System.Data;
using Project_Food_Ordering_System_2021_Prototype_1.Database;
using Project_Food_Ordering_System_2021_Prototype_1.Models;
using System.Collections.Generic;

namespace Project_Food_Ordering_System_2021_Prototype_1.Controllers
{
    public class ItemPersistenceManager
    {
        public SqlConnection connect;
        public SqlCommand command;
        public DataSet data;
        public SqlDataAdapter adapter;
        public SqlDataReader reader;

        public Item findItem(string itemName)
        {
            connect = new SqlConnection(DatabaseOperations.conString);
            connect.Open();

            Item item = new Item();

            string sqlItem = $"SELECT * FROM ItemTable WHERE Item_Name = @ItemName";
                
            command = new SqlCommand(sqlItem, connect);
            command.Parameters.AddWithValue("@ItemName", itemName);

            reader = command.ExecuteReader();
            while (reader.Read())
            {

                item.Item_ID = new Guid(reader[0].ToString());
                item.Item_Price = Double.Parse(reader[1].ToString());
                item.Item_Name = reader[2].ToString();                             
            }
            command.Dispose();
            connect.Close();

            return item;
        }

        public Item findItemID(Guid item_id)
        {
            connect = new SqlConnection(DatabaseOperations.conString);
            connect.Open();

            Item item = new Item();

            string sqlItem = $"SELECT * FROM ItemTable WHERE Item_ID = '{item_id}'";

            command = new SqlCommand(sqlItem, connect);

            reader = command.ExecuteReader();
            while (reader.Read())
            {
                item.Item_ID = new Guid(reader[0].ToString());
                item.Item_Price = Double.Parse(reader[1].ToString());
                item.Item_Name = reader[2].ToString();
                item.Category = reader[3].ToString();
            }
            command.Dispose();
            connect.Close();

            return item;
        }

        public List<Item> findCategory(string category)
        {
            Item item;
            List<Item> itemList = new List<Item>(); 
            connect = new SqlConnection(DatabaseOperations.conString);
            connect.Open();

           
            string sqlItem = $"SELECT * FROM ItemTable WHERE Category = @category";

            command = new SqlCommand(sqlItem, connect);
            command.Parameters.AddWithValue("@category", category);

            reader = command.ExecuteReader();
            while (reader.Read())
            {
                item = new Item((Guid)reader[0], double.Parse(reader[1].ToString()), reader[2].ToString(), reader[3].ToString());
                itemList.Add(item);
            }
            command.Dispose();
            connect.Close();

            return itemList;
        }

        public List<Item> getAll()
        {
            Item item;
            List<Item> itemList = new List<Item>();
            connect = new SqlConnection(DatabaseOperations.conString);
            connect.Open();


            string sqlItem = $"SELECT * FROM ItemTable";

            command = new SqlCommand(sqlItem, connect);

            reader = command.ExecuteReader();
            while (reader.Read())
            {
                item = new Item((Guid)reader[0], double.Parse(reader[1].ToString()), reader[2].ToString(), reader[3].ToString());
                itemList.Add(item);              
            }
            command.Dispose();
            connect.Close();

            return itemList;
        }

        public List<Item> getAllBesides(string category)
        {
            Item item;
            List<Item> itemList = new List<Item>();
            connect = new SqlConnection(DatabaseOperations.conString);
            connect.Open();


            string sqlItem = $"SELECT * FROM ItemTable WHERE NOT (Category = '{category}')";

            command = new SqlCommand(sqlItem, connect);

            reader = command.ExecuteReader();
            while (reader.Read())
            {
                item = new Item((Guid)reader[0], double.Parse(reader[1].ToString()), reader[2].ToString(), reader[3].ToString());
                itemList.Add(item);
            }
            command.Dispose();
            connect.Close();

            return itemList;
        }

        public void insertItem(Item item)
        {
            Guid guid = Guid.NewGuid();

            connect = new SqlConnection(DatabaseOperations.conString);
            connect.Open();

            string sqlItem = $"INSERT INTO ItemTable VALUES ('{guid.ToString()}', {item.Item_Price}, '{item.Item_Name}', '{item.Category}')";
            command = new SqlCommand(sqlItem, connect);

            command.ExecuteNonQuery();

            command.Dispose();
            connect.Close();
        }

        public void removeItem(Guid item_id)
        {
            connect = new SqlConnection(DatabaseOperations.conString);
            connect.Open();

            string sqlItem = $"DELETE FROM ItemTable WHERE Item_ID = '{item_id}'";
            command = new SqlCommand(sqlItem, connect);

            command.ExecuteNonQuery();

            command.Dispose();
            connect.Close();
        }

        public void updateItem(Item item)
        {
            connect = new SqlConnection(DatabaseOperations.conString);
            connect.Open();

            string sqlUser = $"UPDATE  ItemTable SET Item_Name = '{item.Item_Name}', Item_Price = {item.Item_Price}, Category = '{item.Category}' WHERE Item_ID = '{item.Item_ID}'";
            command = new SqlCommand(sqlUser, connect);           

            command.ExecuteNonQuery();
        
            command.Dispose();
            connect.Close();
        }
    }
}
