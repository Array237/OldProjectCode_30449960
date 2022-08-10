using System;
using System.Data.SqlClient;
using System.Data;
using Project_Food_Ordering_System_2021_Prototype_1.Database;
using Project_Food_Ordering_System_2021_Prototype_1.Controllers;

namespace Project_Food_Ordering_System_2021_Prototype_1.Models
{
    public class OrderItem
    {
        private string User_ID{ get; set; }
        private string User_Name { get; set; }
        private string User_Surname { get; set; }
        private string User_Email { get; set; }
        private string User_Password { get; set; }
        private string User_Role { get; set; }

        public CartManager UserCart;

        public SqlConnection connect;
        public SqlCommand command;
        public DataSet data;
        public SqlDataAdapter adapter;
        public SqlDataReader reader;
        
        public OrderItem(){}
        public OrderItem(string User_id, string userName, string userSurname, string userEmail, string userPassword, string userRole)
        {
            this.User_ID = User_id;
            this.User_Name = userName;
            this.User_Surname = userSurname;
            this.User_Email = userEmail;
            this.User_Password = userPassword;
            this.User_Role = userRole;
            UserCart = new CartManager();
        }

        //Accessors
        public string getUserID()
        {
            return User_ID;
        }
        public string getUserName()
        {
            return User_Name;
        }
        public string getUserSurname()
        {
            return User_Surname;
        }
        public string getUserEmail()
        {
            return User_Email;
        }
        public string getPassword()
        {
            return User_Password;
        }
        public string getRole()
        {
            return User_Role;
        }       

        public bool register()
        {
            connect = new SqlConnection(DatabaseOperations.conString);
            connect.Open();

            string sql = $"INSERT INTO UserTable VALUES ({User_ID}, '{User_Name}', '{User_Surname}', '{User_Email}', '{User_Password}', 'User')";

            command = new SqlCommand(sql, connect);
            adapter = new SqlDataAdapter();

            adapter.InsertCommand = new SqlCommand(sql, connect);
            adapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
            connect.Close();
            return true;
        }

        public void placeOrder()
        {
            //connect = new SqlConnection(DatabaseOperations.conString);
            //connect.Open();

            //for (int i = 0; i < UserCart.itemsList.Count; i++)
            //{
            //    string sql = $"UPDATE StockTable SET Quantity_On_Hand = Quantity_On_Hand - {UserCart.itemsList[i].quantity}," +
            //        $"Quantity_Sold_30_Days = Quantity_Sold_30_Days + {UserCart.itemsList[i].quantity}" +
            //        $"WHERE Item_ID = {UserCart.itemsList[i].item.item_id}";
            //    command = new SqlCommand(sql, connect);

            //    command.ExecuteNonQuery();
            //}

            //command.Dispose();
            //connect.Close();
        }

    }
}