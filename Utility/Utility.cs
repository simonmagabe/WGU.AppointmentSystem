using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WGU.AppointmentSystem.Model;

namespace Utility
{
    public class Utility
    {
        public static Database database = new Database();
        public static string allUsersQueryString = "SELECT * FROM user";

        public static List<User> GetUsers()
        {
            List<User> users = new List<User>();

            database.SqlConnection.Open();
        }
    }
}
