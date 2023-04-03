using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPS.Common;
using System.Data.SqlClient;
using System.Collections;

namespace SPS.DAL
{
    public class UserDAL
    {
        public int putUser(User newUser)
        {
            //step-1 make connection
            string connString = @"server=DESKTOP-P5NFO5D; database=MY_SPS_FINAL; Integrated Security=SSPI;";
            SqlConnection myConn = new SqlConnection(connString);
            //step-2 open connection
            myConn.Open();
            //step-3 write query
            string myQuery = "insert into [User] (name,password,email,is_admin) values('" + newUser.name + "','" + newUser.password + "','" + newUser.email + "','" + newUser.isAdmin + "') ;";
            //step-4 execute query
            SqlCommand cmd = new SqlCommand(myQuery, myConn);
            var result = cmd.ExecuteNonQuery();
            //step-5 close all resources
            myConn.Close();
            cmd.Dispose();
            myConn.Dispose();
            return result;
        }
        public bool userExists(string a_email, string a_password,bool isAdmin)
        {
            string connString = @"server=DESKTOP-P5NFO5D;database=MY_SPS_FINAL;Integrated Security=SSPI;";
            SqlConnection myConn = new SqlConnection(connString);
            myConn.Open();
            string myQuery = "select password,email,is_admin from [User];";
            SqlCommand cmd = new SqlCommand(myQuery, myConn);
            SqlDataReader sdr = cmd.ExecuteReader();
            bool found = false;
            while(sdr.Read())
            {
                if (Convert.ToString(sdr["password"]) ==a_password && Convert.ToString(sdr["email"]) ==a_email && Convert.ToBoolean(sdr["is_admin"])==isAdmin)
                {
                    found = true;
                }
            }
            return found;
        }
        public List<User> getAllUsers()
        {
            List<User> users = new List<User>();
            string connString = @"server=DESKTOP-P5NFO5D;database=MY_SPS_FINAL;Integrated Security=SSPI;";
            SqlConnection myConn = new SqlConnection(connString);
            myConn.Open();
            string myQuery = "select * from [User];";
            SqlCommand cmd = new SqlCommand(myQuery, myConn);
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                User user = new User();
                user.id = Convert.ToInt32(reader["id"]);
                user.name = Convert.ToString(reader["name"]);
                user.email = Convert.ToString(reader["email"]);
                user.password = Convert.ToString(reader["password"]);
                user.isAdmin = Convert.ToBoolean(reader["is_admin"]);
                //adding user to user list
                users.Add(user);
            }
            return users; 
        }
        public int updateUser(int id,User updatedUser)
        {
            string connString = @"server=DESKTOP-P5NFO5D;database=MY_SPS_FINAL;Integrated Security=SSPI;";
            SqlConnection myConn = new SqlConnection(connString);
            myConn.Open();
            string myQuery = "update [User] set name='"+updatedUser.name+"',password='"+updatedUser.password+"',email='"+updatedUser.email+"',is_admin='"+updatedUser.isAdmin+"' where ID="+id+";";
            SqlCommand cmd = new SqlCommand(myQuery,myConn);
            var result = cmd.ExecuteNonQuery();
            myConn.Close();
            cmd.Dispose();
            myConn.Dispose();
            return result;
        }

        public int deleteUser(int id)
        {
            string connString = "server=DESKTOP-P5NFO5D;database=MY_SPS_FINAL;Integrated Security=SSPI;";
            SqlConnection myConn = new SqlConnection(connString);
            myConn.Open ();
            string myQuery = "delete from [User] where ID=" + id + ";";
            SqlCommand cmd = new SqlCommand(myQuery,myConn);
            var result = cmd.ExecuteNonQuery();
            return result;
        }

        public int returnID(string a_email,string a_password)
        {
            string connString = @"server=DESKTOP-P5NFO5D;database=MY_SPS_FINAL;Integrated Security=SSPI;";
            SqlConnection myConn = new SqlConnection(connString);
            myConn.Open();
            string myQuery = "select id,password,email from [User];";
            SqlCommand cmd = new SqlCommand(myQuery, myConn);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                if (Convert.ToString(sdr["password"]) == a_password && Convert.ToString(sdr["email"]) == a_email)
                {
                    return Convert.ToInt32(sdr["ID"]);
                }
            }
            return -1;
        }
        public User getUser(int id)
        {
            User user = new User();
            string connString = @"server=DESKTOP-P5NFO5D;database=MY_SPS_FINAL;Integrated Security=SSPI;";
            SqlConnection myConn = new SqlConnection(connString);
            myConn.Open();
            string myQuery = "select * from [User] where ID="+id+";";
            SqlCommand cmd = new SqlCommand(myQuery, myConn);
            SqlDataReader sdr = cmd.ExecuteReader();
            while(sdr.Read())
            {
                user.id = Convert.ToInt32(sdr["ID"]);
                user.name = Convert.ToString(sdr["name"]);
                user.email = Convert.ToString(sdr["email"]);
                user.password = Convert.ToString(sdr["password"]);
                user.isAdmin = Convert.ToBoolean(sdr["is_admin"]);
            }
            return user;
        }
    }
}
