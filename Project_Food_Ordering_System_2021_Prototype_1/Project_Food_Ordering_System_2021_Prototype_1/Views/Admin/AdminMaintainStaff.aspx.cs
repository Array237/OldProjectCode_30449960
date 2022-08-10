using System;
using System.Collections.Generic;
using Project_Food_Ordering_System_2021_Prototype_1.Models;
using Project_Food_Ordering_System_2021_Prototype_1.Controllers;

namespace Project_Food_Ordering_System_2021_Prototype_1
{
    public partial class AdminMaintainStaff : System.Web.UI.Page
    {
        UserPersistenceManager userManager = new UserPersistenceManager();

        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = userManager.getAllStaff();
            GridView1.DataBind();
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Views/Admin/AdminSelection.aspx");
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            bool name = String.IsNullOrEmpty(txtStaffNumber.Text);
            bool surname = String.IsNullOrEmpty(txtName.Text);
            bool password = String.IsNullOrEmpty(txtPassword.Text);

            if (!name && !surname && !password)
            {
                Staff newStaff = new Staff(txtName.Text, txtSurname.Text, txtEmail.Text,
                    txtPassword.Text, txtStaffNumber.Text, DropDownList1.SelectedValue);

                User findUser = userManager.findUser(txtStaffNumber.Text);

                if (findUser == null)
                {
                    userManager.insertUser(newStaff);

                    GridView1.DataSource = userManager.getAllStaff();
                    GridView1.DataBind();
                }
                else
                {
                    lblExistingUser.Visible = true;
                }
            }
        }

        protected void btnRemove_Click(object sender, EventArgs e)
        {
            User removeUser = userManager.findUser(txtRemove.Text);

            if (removeUser != null)
            {
                userManager.removeUser(removeUser.User_ID);
                lblError.Visible = false;
                txtRemove.Text = "";
            }
            else
            {
                lblError.Visible = true;
            }

            GridView1.DataSource = userManager.getAllStaff();
            GridView1.DataBind();
        }
    }
}