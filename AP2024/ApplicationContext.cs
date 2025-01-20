using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP2024
{
    public static class ApplicationContext
    {
        public static string GetConnectionString()
        {
            return "Data Source=data/AP2024.db";
        }

        public static string GetCurrentDate()
        {
            DateTime dateTime = DateTime.Now;
            return dateTime.ToString();
        }

        public static string GetCurrentWindowsUser()
        {
            string user = Environment.UserName.ToLower();
            return user;
        }
    }
}
