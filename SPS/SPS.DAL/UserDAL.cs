using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPS.Common;
using System.IO;
using System.Collections;

namespace SPS.DAL
{
    public class UserDAL
    {
        public bool insertUser(User u)
        {
            try
            {
                StreamWriter sw = new StreamWriter(@"C:\Users\madina\OneDrive\Desktop\SPS\user.txt",true);
                //string newUser = Convert.ToString(u.ID) + "," + u.Name + "," + u.email + "," + u.password + "," + Convert.ToString(u.isAdmin);
                Console.WriteLine(u.ID + u.Name);
                sw.WriteLine(u.ID + "," + u.Name + "," + u.email + "," + u.password + "," +u.isAdmin);
                sw.Close();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
        public List<User> getAllUsers()
        {
            List<User> users = new List<User>();
            string line = null;
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(@"C:\Users\madina\OneDrive\Desktop\SPS\user.txt");
                while((line=sr.ReadLine())!=null)
                {
                    User user = new User();
                    string[] data = line.Split(',');
                    user.ID = Convert.ToInt32(data[0]);
                    user.Name = data[1];
                    user.password = data[2];
                    user.email = data[3];
                    user.isAdmin = Convert.ToBoolean(data[4]);
                    users.Add(user);
                }
                sr.Close();
               // return users;
            }
            catch (Exception ex)
            {
                Console.WriteLine("users file couldn't be opened!");
            }
            return users;
        }
    }
}
