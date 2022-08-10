using System;
using Project_Food_Ordering_System_2021_Prototype_1.Models;
using Project_Food_Ordering_System_2021_Prototype_1.Controllers;

namespace Project_Food_Ordering_System_2021_Prototype_1.Client
{
    public partial class ClientRegister : System.Web.UI.Page
    {
        UserPersistenceManager userManager = new UserPersistenceManager(); 
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            int studentNum = 0;
            if (int.TryParse(txtUserStudentNumber.Text, out studentNum))
            {
                Student newStudent = new Student(txtUserName.Text,
                txtUserSurname.Text, txtUserEmail.Text, txtUserPassword.Text, txtUserStudentNumber.Text);

                User findUser = userManager.findUser(txtUserStudentNumber.Text);

                if (findUser == null)
                {
                    userManager.insertUser(newStudent);
                    Response.Redirect("/Views/Home/HomePage.aspx");
                }
                else
                {
                    lblExistingUser.Visible = true;
                }
            }
        }
    }
}