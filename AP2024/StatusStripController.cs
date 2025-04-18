﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP2024
{
    public static class StatusStripController
    {

        private static ToolStripStatusLabel userStrip, sickDaysStrip, timeAdminStrip, lastUpdated, department, flextimeStrip;


        public static void SetStatusStrip(StatusStrip statusStrip)
        {
            userStrip = statusStrip.Items["user"] as ToolStripStatusLabel;
            sickDaysStrip = statusStrip.Items["sick_days"] as ToolStripStatusLabel;
            timeAdminStrip = statusStrip.Items["time_admin"] as ToolStripStatusLabel;
            lastUpdated = statusStrip.Items["last_updated"] as ToolStripStatusLabel;
            department = statusStrip.Items["department"] as ToolStripStatusLabel;
            flextimeStrip = statusStrip.Items["flextime"] as ToolStripStatusLabel;

            SetUser();
            SetTimeAdmin();
            SetLastUpdated();
        }

        public static void SetUser()
        {
            string connectionString = ApplicationContext.GetConnectionString(); // Hole den ConnectionString
            string currentUser = ApplicationContext.GetCurrentWindowsUser();    // Erhalte den aktuellen Windows-Benutzer

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open(); // Öffne die Verbindung zur Datenbank

                    string query = "SELECT first_name, last_name, sick_days, flextime FROM Employees WHERE windows_username = @windowsUser";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@windowsUser", currentUser);

                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string firstName = reader["first_name"].ToString();
                                string lastName = reader["last_name"].ToString();
                                string sickDays = reader["sick_days"].ToString();
                                string flextimeString = reader["flextime"].ToString();

                                float flextime = 0;
                                float.TryParse(flextimeString, out flextime);

                                userStrip.Text = "Benutzer:".PadRight(15) + $"{firstName} {lastName}";
                                sickDaysStrip.Text = "Krankheitstage:".PadRight(20) + $"{sickDays}";
                                flextimeStrip.Text = "Gleitzeit:".PadRight(15) + $"{flextime} Std.";

                                if (flextime < 0)
                                {
                                    flextimeStrip.BackColor = System.Drawing.Color.Red;
                                }
                                else
                                {
                                    flextimeStrip.BackColor = System.Drawing.Color.Green;
                                }
                            }
                            else
                            {
                                userStrip.Text = "Benutzer: Nicht gefunden!";
                                sickDaysStrip.Text = "Krankheitstage: Nicht gefunden!";
                                flextimeStrip.Text = "Gleitzeit: Nicht gefunden!";
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "AP2024");
                }
            }
        }




        public static void SetTimeAdmin()
        {
            string connectionString = ApplicationContext.GetConnectionString();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // SQL-Abfrage mit JOIN zwischen Settings und Employees
                    string query = @"
                SELECT 
                    e.first_name, 
                    e.last_name, 
                    s.department
                FROM Settings s
                LEFT JOIN Employees e ON s.time_admin = e.id";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string firstName = reader["first_name"]?.ToString() ?? "Unbekannt";
                                string lastName = reader["last_name"]?.ToString() ?? "";
                                string departmentName = reader["department"]?.ToString() ?? "Unbekannt";

                                timeAdminStrip.Text = "Zeit Admin:".PadRight(16) + $"{firstName} {lastName}".Trim();
                                department.Text = "Abteilung:".PadRight(15) + $"{departmentName}";
                            }
                            else
                            {
                                timeAdminStrip.Text = "Zeit Admin: Nicht gefunden!";
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "AP2024");
                }
            }
        }


        public static void SetLastUpdated()
        {
            lastUpdated.Text = "Zuletzt aktualisiert: " + ApplicationContext.GetCurrentDate() + " " + ApplicationContext.GetCurrentTime();
        }
    }
}
