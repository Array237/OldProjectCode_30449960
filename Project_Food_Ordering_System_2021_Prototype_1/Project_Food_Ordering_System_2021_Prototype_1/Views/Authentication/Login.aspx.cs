using System;
using Project_Food_Ordering_System_2021_Prototype_1.Models;
using Project_Food_Ordering_System_2021_Prototype_1.Controllers;

namespace Project_Food_Ordering_System_2021_Prototype_1.Client
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        UserPersistenceManager userPersistenceManager = new UserPersistenceManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void LogIn(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
                      
            
        }

        protected void btnLogin_Click1(object sender, EventArgs e)
        {
            User logUser = userPersistenceManager.findUser(txtStudentNumber.Text);

            if (logUser != null)
            {
                if (string.Equals(txtPassword.Text, logUser.User_Password))
                {
                    Session["User"] = logUser;
                    Response.Redirect("/Views/Home/HomePage.aspx");
                }
                else
                {
                    lblError2.Text = "Password incorrect";
                    lblError2.ForeColor = System.Drawing.Color.Red;
                    lblError1.ForeColor = System.Drawing.Color.FromArgb(240, 248, 255);
                }
            }
            else
            {
                lblError1.Text = "User doesn't exist";
                lblError1.ForeColor = System.Drawing.Color.Red;
                lblError2.ForeColor = System.Drawing.Color.FromArgb(240, 248, 255);

            }
        }
    }
}