using System;
using Project_Food_Ordering_System_2021_Prototype_1.Models;
using Project_Food_Ordering_System_2021_Prototype_1.Controllers;


namespace Project_Food_Ordering_System_2021_Prototype_1
{
    public partial class ClientMaintainInformation : System.Web.UI.Page
    {
        UserPersistenceManager userPersistenceManager = new UserPersistenceManager();

        private User logUser;
        private Student student = null;
        private Staff staff = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            logUser = (User)Session["User"];

            if (!IsPostBack)
            {
                if (logUser is Student)
                {
                    student = logUser as Student;
                    txtUniversityNumber.Text = student.Student_Number;
                    txtName.Text = student.User_Name;
                    txtSurname.Text = student.User_Surname;
                    txtEmail.Text = student.User_Email;
                }
                else if (logUser is Staff)
                {
                    staff = logUser as Staff;
                    txtUniversityNumber.Text = staff.Staff_Number;
                    txtName.Text = staff.User_Name;
                    txtSurname.Text = staff.User_Surname;
                    txtEmail.Text = staff.User_Email;
                }
            }
        }

        protected void btnUpdateInformation(object sender, EventArgs e)
        {
            string message = "";
            lblErrorSuccess.Visible = false;
            bool name = String.IsNullOrEmpty(txtName.Text);
            bool surname = String.IsNullOrEmpty(txtSurname.Text);
            bool email = String.IsNullOrEmpty(txtEmail.Text);

            if (!name && !surname && !email)
            {
                logUser.User_Name = txtName.Text;
                logUser.User_Surname = txtSurname.Text;
                logUser.User_Email = txtEmail.Text;

                userPersistenceManager.updateUser(logUser);

                lblErrorSuccess.Text = "Account Updated";
                lblErrorSuccess.ForeColor = System.Drawing.Color.Green;
                lblErrorSuccess.Visible = true;

            }
            else
            {
                if (name)
                    message = message + "Name must be specified, ";
                if (surname)
                    message = message + "Surname must be specified, ";
                if (email)
                    message = message + "Email must be specified, ";

                lblErrorSuccess.Text = message.Substring(0, message.Length - 2);
                lblErrorSuccess.ForeColor = System.Drawing.Color.Red;
                lblErrorSuccess.Visible = true;
            }

        }

        

        protected void btnChangePassword(object sender, EventArgs e)
        {
            string message = "";
            lblErrorSuccess.Visible = false;
            bool newPassword = String.IsNullOrEmpty(txtNewPassword.Text);
            bool confrirmPassword = String.IsNullOrEmpty(txtConfirmPassword.Text);


            if (!newPassword && !confrirmPassword)
            {
                if (string.Equals(txtNewPassword.Text, txtConfirmPassword.Text))
                {
                    logUser.User_Password = txtNewPassword.Text;
                    userPersistenceManager.updateUser(logUser);

                    lblErrorSuccessPassword.Text = "Password Updated";
                    lblErrorSuccessPassword.ForeColor = System.Drawing.Color.Green;
                    lblErrorSuccessPassword.Visible = true;
                }
                else
                {                  
                    lblErrorSuccessPassword.Text = "New password and confirm password must be the same";
                    lblErrorSuccessPassword.ForeColor = System.Drawing.Color.Red;
                    lblErrorSuccessPassword.Visible = true;
                }
            }
            else
            {
                if (newPassword)
                    message = message + "New Password must be specified, ";
                if (confrirmPassword)
                    message = message + "Confirm Password must be specified, ";                

                lblErrorSuccessPassword.Text = message.Substring(0, message.Length - 2);
                lblErrorSuccessPassword.ForeColor = System.Drawing.Color.Red;
                lblErrorSuccessPassword.Visible = true;
                txtNewPassword.Text = "";
                txtConfirmPassword.Text = "";
            }
        }
    }
}