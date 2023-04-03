using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPS.Common;
using SPS.DAL;

namespace SPS.BLL
{
    public class UserBLL
    {
        public int insertUser(User newUser)
        {
            UserDAL userDAL = new UserDAL();
            return userDAL.putUser(newUser);
        }
        public bool userPresent(string email, string password,bool isAdmin)
        {
            UserDAL userDAL=new UserDAL();
            return userDAL.userExists(email, password,isAdmin);
        }

        public List<User> returnAllUsers()
        {
            UserDAL userDAL = new UserDAL();
            return userDAL.getAllUsers();
        }
        public int updateUser(int id,User newUser)
        {
            UserDAL userDAL = new UserDAL();
            return userDAL.updateUser(id,newUser);
        }
        public int deleteUser(int id)
        {
            UserDAL userDAL = new UserDAL();
            return userDAL.deleteUser(id);
        }
        public int getID(string email,string password)
        {
            UserDAL userDAL = new UserDAL();
            return userDAL.returnID(email,password);    
        }
        public User returnUser(int id)
        {
            UserDAL userDAL = new UserDAL();
            return userDAL.getUser(id);
        }
    }
}
