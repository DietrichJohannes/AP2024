using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP2024
{
    public static class AutomaticEmployeeAddition
    {

        private static bool UserCanAddThemself = false;


        public static void InitAutomaticEmployeeAddition()
        {
            GetSettings();
            StartWindow();
        }

        private static void GetSettings()
        {
            string query = "SELECT * FROM Settings";
            using (SQLiteConnection connection = new SQLiteConnection(ApplicationContext.GetConnectionString()))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (reader["can_add_themselves"].ToString() == "1")
                            {
                                UserCanAddThemself = true;
                            }
                            else
                            {
                                UserCanAddThemself = false;
                            }
                        }
                    }
                }
            }
        }

        private static void StartWindow()
        {
            if (UserCanAddThemself)
            {
                UserAddThemselves userAddThemselves = new UserAddThemselves();
                userAddThemselves.ShowDialog();
            }
            else
            {
                NoAccess noAccess = new NoAccess();
                noAccess.ShowDialog();
            }
        }


    }
  }

