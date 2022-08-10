using System;
using System.Collections.Generic;
using Project_Food_Ordering_System_2021_Prototype_1.Controllers;
using Project_Food_Ordering_System_2021_Prototype_1.Models;

namespace Project_Food_Ordering_System_2021_Prototype_1.Views.Staff
{
    public partial class StaffRestock : System.Web.UI.Page
    {
        ItemPersistenceManager itemManager = new ItemPersistenceManager();
        StockPersistenceManager stockManager = new StockPersistenceManager();

        protected void Page_Load(object sender, EventArgs e)
        {
            Database.DatabaseOperations.LoadToTable("SELECT ItemTable.Item_Name, StockTable.Quantity FROM ItemTable " +
                    "LEFT JOIN StockTable ON(ItemTable.Item_ID = StockTable.Item_ID) " +
                    "WHERE NOT (ItemTable.Category = 'Fast Food')", ref GridView1);

            if (!IsPostBack)
            {
                List<Item> itemList = itemManager.getAllBesides("Fast Food");
                dropListNames.Items.Clear();

                foreach (Item i in itemList)
                {
                    dropListNames.Items.Add(i.Item_Name);
                }

                Session["itemList"] = itemList;
            }
        }

        protected void btnRestock_Click(object sender, EventArgs e)
        {

        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Views/Staff/StaffSelectionPage.aspx");
        }

        protected void btnRestock1_Click(object sender, EventArgs e)
        {
            List<Item> itemList = (List<Item>)Session["itemList"];
            Item item = itemList[dropListNames.SelectedIndex];
            int restock = 0;
            if (int.TryParse(txtAmount.Text, out restock))
            {
                stockManager.addStock(item.Item_ID, restock);
            }

            Database.DatabaseOperations.LoadToTable("SELECT ItemTable.Item_Name, StockTable.Quantity FROM ItemTable " +
                    "LEFT JOIN StockTable ON(ItemTable.Item_ID = StockTable.Item_ID) " +
                    "WHERE NOT (ItemTable.Category = 'Fast Food')", ref GridView1);

        }
    }
}