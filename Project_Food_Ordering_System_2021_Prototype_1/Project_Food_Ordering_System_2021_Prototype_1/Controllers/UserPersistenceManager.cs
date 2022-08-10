using System;
using System.Data.SqlClient;
using System.Data;
using Project_Food_Ordering_System_2021_Prototype_1.Database;
using Project_Food_Ordering_System_2021_Prototype_1.Models;
using System.Collections.Generic;

namespace Project_Food_Ordering_System_2021_Prototype_1.Controllers
{
    public class UserPersistenceManager
    {
        public SqlConnection connect;
        public SqlCommand command;
        public DataSet data;
        public SqlDataAdapter adapter;
        public SqlDataReader reader;

        public User findUser(string UniversityNumber)
        {
            connect = new SqlConnection(DatabaseOperations.conString);
            connect.Open();

            User user = null;

            string sqlStaff = $"SELECT * FROM StaffTable JOIN UserTable ON StaffTable.User_ID = UserTable.User_ID " +
            $"WHERE Staff_Number = @UniversityNumber";

            command = new SqlCommand(sqlStaff, connect);
            command.Parameters.AddWithValue("@UniversityNumber", UniversityNumber);    
           
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Staff staff = new Staff();
                staff.User_ID = new Guid(reader[0].ToString());
                staff.Staff_Number = reader[1].ToString();
                staff.Staff_Role = reader[2].ToString();
                staff.User_Name = reader[4].ToString();
                staff.User_Surname = reader[5].ToString();
                staff.User_Email = reader[6].ToString();
                staff.User_Password = reader[7].ToString();
                user = staff;
            }

            command.Dispose();
            reader.Close();

            if (user == null)
            {
                string sqlStudent = $"SELECT * FROM StudentTable JOIN UserTable ON StudentTable.User_ID = UserTable.User_ID " +
                $"WHERE Student_Number = @UniversityNumber";
                command = new SqlCommand(sqlStudent, connect);
                command.Parameters.AddWithValue("@UniversityNumber", UniversityNumber);


                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Student student = new Student();
                    student.User_ID = new Guid(reader[0].ToString());
                    student.Student_Number = reader[1].ToString();                   
                    student.User_Name = reader[3].ToString();
                    student.User_Surname = reader[4].ToString();
                    student.User_Email = reader[5].ToString();
                    student.User_Password = reader[6].ToString();
                    student.userCart = new CartManager();
                    user = student;
                }
                command.Dispose();
                
            }

            connect.Close();
            return user;
        }
        public List<User> getAllStudents()
        {
            connect = new SqlConnection(DatabaseOperations.conString);
            connect.Open();

            List<User> userList = new List<User>();
            
            string sqlStudent = $"SELECT * FROM StudentTable JOIN UserTable ON StudentTable.User_ID = UserTable.User_ID";
            command = new SqlCommand(sqlStudent, connect);

            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Student student = new Student();
                student.User_ID = new Guid(reader[0].ToString());
                student.Student_Number = reader[1].ToString();
                student.User_Name = reader[3].ToString();
                student.User_Surname = reader[4].ToString();
                student.User_Email = reader[5].ToString();
                student.User_Password = reader[6].ToString();
                student.userCart = new CartManager();
                userList.Add(student);
            }
            command.Dispose();

            connect.Close();
            return userList;
        }

        public List<User> getAllStaff()
        {
            connect = new SqlConnection(DatabaseOperations.conString);
            connect.Open();

            List<User> userList = new List<User>();

            string sqlStudent = $"SELECT * FROM StaffTable JOIN UserTable ON StaffTable.User_ID = UserTable.User_ID";
            command = new SqlCommand(sqlStudent, connect);

            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Staff staff = new Staff();
                staff.User_ID = new Guid(reader[3].ToString());
                staff.Staff_Number = reader[1].ToString();
                staff.User_Name = reader[4].ToString();
                staff.User_Surname = reader[5].ToString();
                staff.User_Email = reader[6].ToString();
                staff.User_Password = reader[7].ToString();
                staff.Staff_Role = reader[2].ToString();
                userList.Add(staff);
            }
            command.Dispose();

            connect.Close();
            return userList;
        }

        public void insertUser(User user)
        {
            connect = new SqlConnection(DatabaseOperations.conString);
            adapter = new SqlDataAdapter();
            connect.Open();

            Guid guid = Guid.NewGuid();

            string sqlUser = $"INSERT INTO UserTable VALUES ('{guid.ToString()}', '{user.User_Name}', '{user.User_Surname}', '{user.User_Email}', '{user.User_Password}')";
            command = new SqlCommand(sqlUser, connect);

            command.ExecuteNonQuery();

            string sql = "";
            if (user is Staff)
            {
                Staff staff = user as Staff;
                sql = $"INSERT INTO StaffTable VALUES ('{guid.ToString()}', '{staff.Staff_Number}','{staff.Staff_Role}')";
                command = new SqlCommand(sql, connect);
            }
            else if (user is Student)
            {
                Student student = user as Student;
                sql = $"INSERT INTO StudentTable VALUES ('{guid.ToString()}', '{student.Student_Number}')";
                command = new SqlCommand(sql, connect);
            }

            command.ExecuteNonQuery();

            command.Dispose();
            connect.Close();

        }

        public void removeUser(Guid user_id)
        {
            connect = new SqlConnection(DatabaseOperations.conString);
            connect.Open();

            string sqlUser = $"DELETE FROM UserTable WHERE User_ID = '{user_id}'";
            command = new SqlCommand(sqlUser, connect);

            command.ExecuteNonQuery();

            command.Dispose();
            connect.Close();
        }

        public void updateUser(User user)
        {
            connect = new SqlConnection(DatabaseOperations.conString);
            connect.Open();


            string sqlUser = $"UPDATE UserTable SET User_Name = '{user.User_Name}', User_Surname = '{user.User_Surname}', " +
                $"User_Email = '{user.User_Email}', Password = '{user.User_Password}' WHERE User_ID = '{user.User_ID}'";
            command = new SqlCommand(sqlUser, connect);

            command.ExecuteNonQuery();

            string sql = "";
            if (user is Staff)
            {
                Staff staff = user as Staff;
                sql = $"UPDATE StaffTable SET Staff_Role = '{staff.Staff_Role}' WHERE User_ID = '{staff.User_ID}')";

                command = new SqlCommand(sql, connect);
                command.ExecuteNonQuery();
            }

            command.Dispose();
            connect.Close();
        }
    }
}