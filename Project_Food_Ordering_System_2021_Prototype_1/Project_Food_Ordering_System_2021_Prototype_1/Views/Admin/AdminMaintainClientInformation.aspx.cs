using System;
using System.Collections.Generic;
using Project_Food_Ordering_System_2021_Prototype_1.Controllers;
using Project_Food_Ordering_System_2021_Prototype_1.Models;

namespace Project_Food_Ordering_System_2021_Prototype_1
{
    public partial class AdminMaintainClientInformation : System.Web.UI.Page
    {
        UserPersistenceManager userManager = new UserPersistenceManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            //Database.DatabaseOperations.LoadToTable("SELECT UserTable.User_Name, UserTable.User_Surname, UserTable.User_Email, " +
            //    "StudentTable.Student_Number, StaffTable.Staff_Number FROM UserTable LEFT JOIN StudentTable ON " +
            //    "(UserTable.User_ID = StudentTable.User_ID) LEFT JOIN StaffTable ON(UserTable.User_ID = StaffTable.User_ID)", ref GridView1);

            GridView1.DataSource = userManager.getAllStudents();
            GridView1.DataBind();
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click1(object sender, EventArgs e)
        {
            
        }

        protected void btnRemove_Click(object sender, EventArgs e)
        {
              
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Views/Admin/AdminSelection.aspx");
        }

        protected void txtRemoveStudent_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnRemove_Click1(object sender, EventArgs e)
        {
            bool userStudent = String.IsNullOrEmpty(txtRemoveStudent.Text);

            if (!userStudent)
            {
                User removeUser = userManager.findUser(txtRemoveStudent.Text);

                if (removeUser != null)
                {
                    userManager.removeUser(removeUser.User_ID);
                    lblError.Visible = false;
                    txtRemoveStudent.Text = "";

                    GridView1.DataSource = userManager.getAllStudents();
                    GridView1.DataBind();
                }
                else
                {
                    lblError.Visible = true;
                }
            }
        }
    }
}