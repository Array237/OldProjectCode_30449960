using System;

namespace Project_Food_Ordering_System_2021_Prototype_1.Models
{
    public class Staff : User
    {      
        public string Staff_Number { get; set; }
        public string Staff_Role { get; set; }

        public Staff(){}
        public Staff(Guid User_id, string userName, string userSurname, string userEmail, string userPassword, string Staff_Number, string Staff_Role)
        {
            this.User_ID = User_id;
            this.User_Name = userName;
            this.User_Surname = userSurname;
            this.User_Email = userEmail;
            this.User_Password = userPassword;
            this. Staff_Number = Staff_Number;
            this.Staff_Role = Staff_Role;
        }

        public Staff(string userName, string userSurname, string userEmail, string userPassword, string Staff_Number, string Staff_Role)
        {
            this.User_Name = userName;
            this.User_Surname = userSurname;
            this.User_Email = userEmail;
            this.User_Password = userPassword;
            this.Staff_Number = Staff_Number;
            this.Staff_Role = Staff_Role;
        }
    }
}