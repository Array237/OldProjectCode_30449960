using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_Food_Ordering_System_2021_Prototype_1
{
    public partial class StaffSelectionPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOrders_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnStock_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnOrder_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Views/Staff/StaffOrderProcessing.aspx");
        }

        protected void btnStocks_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Views/Staff/StaffRestock.aspx");
        }
    }
}