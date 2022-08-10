using System;
using Project_Food_Ordering_System_2021_Prototype_1.Models;

namespace Project_Food_Ordering_System_2021_Prototype_1
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] != null)
            {
                User currentUser = (User)Session["User"];
                if (currentUser is Staff)
                {
                    placeOrderLink.Visible = false;
                    if (((Staff)currentUser).Staff_Role == "Admin")
                    {
                        adminLink.Visible = true;
                        loginLink.Visible = false;
                        registerLink.Visible = false;
                        logoutLink.Visible = true;
                        
                    }
                    else
                    {
                        staffLink.Visible = true;
                        loginLink.Visible = false;
                        registerLink.Visible = false;
                        logoutLink.Visible = true;
                    }
                }
                else
                {
                    loginLink.Visible = false;
                    registerLink.Visible = false;
                    maintainLink.Visible = true;
                    logoutLink.Visible = true;
                    basketLink.Visible = true;
                    orderLink.Visible = true;
                }
            }
        }
    }
}