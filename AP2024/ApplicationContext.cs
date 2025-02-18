using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

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

        public static void InitFirstStart()
        {
            bool SuperAdminBox;

            DialogResult result = MessageBox.Show(
                "Es scheint der Erste Start von AP2024 zu sein.\nMöchten Sie das Setup starten um AP2024 einzurichten?",
                "AP2024 Setup starten",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            SuperAdminBox = result == DialogResult.Yes;

            if (SuperAdminBox)
            {
                AtFirstStartAddSuperAdmin();
                StartFirstStartSetup();
            }
        }



        public static void AtFirstStartAddSuperAdmin()
        {
            using (var connection = new SQLiteConnection(ApplicationContext.GetConnectionString()))
            {
                connection.Open();
                string query = "INSERT INTO Administrators (windows_username, admin_roll) VALUES (@windows_username, @admin_roll)";
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = query;
                    command.Parameters.AddWithValue("@windows_username", ApplicationContext.GetCurrentWindowsUser());
                    command.Parameters.AddWithValue("@admin_roll", 3);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void StartFirstStartSetup()
        {
            
        }
    }
}
