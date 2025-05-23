﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace AP2024
{
    public static class ApplicationContext
    {

        public static int USER_ID;
        public static bool LIGHT_MODE = false;

        public static string GetConnectionString()
        {
            return "Data Source=data/AP2024.db";
        }

        public static void GetTheme()
        {
            using (SQLiteConnection connection = new SQLiteConnection(GetConnectionString()))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = "SELECT light_theme FROM Employees WHERE ID = @id";
                    command.Parameters.AddWithValue("@id", USER_ID); // USER_ID einbinden

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int themeValue = reader.GetInt32(0);
                            LIGHT_MODE = (themeValue == 1);
                        }
                    }
                }
            }
        }


        public static string GetCurrentDate()
        {
            DateTime dateTime = DateTime.Now;
            return dateTime.ToString("dd.mm.yyyy");
        }

        public static string GetCurrentTime()
        {
            DateTime dateTime = DateTime.Now;
            return dateTime.ToString("HH:mm:ss");
        }


        public static string GetCurrentWindowsUser()
        {
            string user = Environment.UserName.ToLower();
            return user;
        }

        public static void GetUserIDByWindowsUser()
        {
            string user = GetCurrentWindowsUser();
            using (SQLiteConnection connection = new SQLiteConnection(GetConnectionString()))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = "SELECT ID FROM Employees WHERE windows_username = @WindowsUser";
                    command.Parameters.AddWithValue("@WindowsUser", user);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            USER_ID = reader.GetInt32(0);
                        }
                        else
                        {
                            AutomaticEmployeeAddition.InitAutomaticEmployeeAddition();
                        }
                    }
                }
            }
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
                SetupController.AtFirstStartAddSuperAdmin();
                SetupController.StartSetup();
            }
        }
    }
}
