using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System_A_.Data_Access_Layer
{
    class UserDataAccess
    {
        DataAccess dataAccess;
        public UserDataAccess()
        {
            this.dataAccess = new DataAccess();
        }

        public bool LoginValidation(string username,string password)
        {
            string sql = "SELECT * FROM users WHERE username='"+username+"' AND password='"+password+"'";
            SqlDataReader reader = dataAccess.GetData(sql);
            if (reader.Read())
            {
                return true;
            }
            return false;
        }
    }
}
