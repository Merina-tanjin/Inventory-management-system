using Inventory_Management_System_A_.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System_A_.Business_Logic_Layer
{
    class UserService
    {
        UserDataAccess userDataAccess;
        public UserService()
        {
            userDataAccess = new UserDataAccess();
        }

        public bool LoginValidation(string username, string password)
        {
            return userDataAccess.LoginValidation(username,password);
        }
    }
}
