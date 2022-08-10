using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_Food_Ordering_System_2021_Prototype_1
{
    public partial class AdminSelection : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSales_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Views/Admin/AdminSalesReport.aspx");
        }

        protected void btnStockReport_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Views/Admin/AdminStockReport.aspx");
        }
      
        protected void btnMaintainProducts_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Views/Admin/AdminMaintainProductsAndPrices.aspx");
        }

        protected void btnMaintainClient_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Views/Admin/AdminMaintainClientInformation.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Views/Admin/AdminMaintainStaff.aspx");
        }
    }
}