using System;
using System.Collections.Generic;
using Project_Food_Ordering_System_2021_Prototype_1.Controllers;

namespace Project_Food_Ordering_System_2021_Prototype_1
{
    public partial class AdminReportingStock : System.Web.UI.Page
    {
        StockPersistenceManager stockManager = new StockPersistenceManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = stockManager.getAllStockWithItemName();
            GridView1.DataBind();
            lblDate.Text = "Current Date: " + DateTime.Now.ToString("dd/MM/yyyy");
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Views/Admin/AdminSelection.aspx");
        }

        protected void btnGenerate_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = stockManager.getAllStockWithItemName();
            GridView1.DataBind();
        }
    }
}