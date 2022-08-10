using System;
using Project_Food_Ordering_System_2021_Prototype_1.Controllers;

namespace Project_Food_Ordering_System_2021_Prototype_1.Models
{
    public class Student : User
    {       
        public string Student_Number { get; set; }
        public CartManager userCart { get; set; }

        public Student(){}
        public Student(Guid User_id, string userName, string userSurname, string userEmail, string userPassword, string Student_Number)
        {
            this.User_ID = User_id;
            this.User_Name = userName;
            this.User_Surname = userSurname;
            this.User_Email = userEmail;
            this.User_Password = userPassword;
            this.Student_Number = Student_Number;
            userCart = new CartManager();
        }

        public Student(string userName, string userSurname, string userEmail, string userPassword, string Student_Number)
        {
            this.User_Name = userName;
            this.User_Surname = userSurname;
            this.User_Email = userEmail;
            this.User_Password = userPassword;
            this.Student_Number = Student_Number;
            userCart = new CartManager();
        }

    }
}