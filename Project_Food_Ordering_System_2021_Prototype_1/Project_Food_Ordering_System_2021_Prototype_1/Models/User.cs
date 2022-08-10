using System;
using Project_Food_Ordering_System_2021_Prototype_1.Controllers;

namespace Project_Food_Ordering_System_2021_Prototype_1.Models
{
    public abstract class User
    {
        public Guid User_ID { get; set; }
        public string User_Name { get; set; }
        public string User_Surname { get; set; }
        public string User_Email { get; set; }
        public string User_Password { get; set; }
       
    }
}