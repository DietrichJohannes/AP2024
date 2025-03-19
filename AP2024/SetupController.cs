using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.SQLite;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;

namespace AP2024
{
    public static class SetupController
    {

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

        public static void StartSetup()
        {
            SetupUserName();
            SetupDepartment();
            AddSuperView();
            AddView();
            AddEmployees();
        }

        // WindowMode Legende
        // 0    = Add Mode
        // 1    = Edit Mode
        // 2    = Setup Mode

        public static void SetupUserName()
        {
            SetupCompleteName setupCompleteName = new SetupCompleteName();
            setupCompleteName.ShowDialog();
        }

        public static void AddSuperView()
        {
            NewSuperView newSuperView = new NewSuperView(2);
            newSuperView.ShowDialog();
        }

        public static void AddView()
        {
            NewView newView = new NewView(2);
            newView.ShowDialog();
        }

        public static void AddEmployees()
        {

        }

        public static void SetupDepartment()
        {
            SetupDepartment setupDepartment = new SetupDepartment();
            setupDepartment.ShowDialog();
        }

    }
}
