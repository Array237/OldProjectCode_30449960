using System.Data.SqlClient;
using System.Data;
using Project_Food_Ordering_System_2021_Prototype_1.Models;
using System.Web.UI.WebControls;

namespace Project_Food_Ordering_System_2021_Prototype_1.Database
{
    public static class DatabaseOperations
    {
        public readonly static string conString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = |DataDirectory|FoodOrderingData.mdf;";
        public static SqlConnection connect;
        public static SqlCommand command;
        public static DataSet data;
        public static SqlDataAdapter adapter;
        public static SqlDataReader reader;
        public static bool LoadToTable(string SQL,ref GridView Table)
        {
            try
            {
                connect = new SqlConnection(conString);
                connect.Open();
                command = new SqlCommand(SQL, connect);
                adapter = new SqlDataAdapter(command);
                data = new DataSet();
                adapter.Fill(data);
                Table.DataSource = data;
                Table.DataBind();
                connect.Close();
                return true;
            }
            catch (System.Exception)
            {
                return false;
                throw;
            }
            
        }
    }

}