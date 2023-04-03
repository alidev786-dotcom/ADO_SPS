using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPS.Common;
using SPS.DAL;
using System.Collections;

namespace SPS.BLL
{
    public class UserBLL
    {
        public bool addUser(User u)
        {
            UserDAL userDAL = new UserDAL();
            return userDAL.insertUser(u);
        }
        public List<User> returnAllUsers()
        {
            UserDAL userDAL = new UserDAL();
            return userDAL.getAllUsers();
        }
    }
}
