using System;
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
    public class StatusStripController
    {

        private static ToolStripStatusLabel userStrip, sickDaysStrip, timeAdminStrip, lastUpdated;


        public static void SetStatusStrip(StatusStrip statusStrip)
        {
            userStrip = statusStrip.Items["user"] as ToolStripStatusLabel;
            sickDaysStrip = statusStrip.Items["sick_days"] as ToolStripStatusLabel;
            timeAdminStrip = statusStrip.Items["time_admin"] as ToolStripStatusLabel;
            lastUpdated = statusStrip.Items["last_updated"] as ToolStripStatusLabel;

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

                        // SQL-Abfrage: Suche den Benutzer mit passendem Windows-Nutzer
                        string query = "SELECT first_name, last_name, sick_days FROM Employees WHERE windows_username = @windowsUser";

                        using (SQLiteCommand command = new SQLiteCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@windowsUser", currentUser); // Parameter setzen

                            using (SQLiteDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read()) // Prüfen, ob ein Datensatz gefunden wurde
                                {
                                    string firstName = reader["first_name"].ToString();
                                    string lastName = reader["last_name"].ToString();
                                    string sickDays = Convert.ToString(reader["sick_days"]);

                                    userStrip.Text = "Benutzer:".PadRight(15) + $"{firstName} {lastName}";
                                    sickDaysStrip.Text = "Krankheitstage:".PadRight(20) + $"{sickDays}";
                            }
                            else
                                {
                                    userStrip.Text = "Benutzer: Nicht gefunden!";
                                    sickDaysStrip.Text = "Krankheitstage: Nicht gefunden!";
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
            string connectionString = ApplicationContext.GetConnectionString(); // Hole den ConnectionString

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open(); // Öffne die Verbindung zur Datenbank

                    // SQL-Abfrage: Suche den Benutzer mit passendem Windows-Nutzer
                    string query = "SELECT windows_username FROM Administrators WHERE admin_roll = 3";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read()) // Prüfen, ob ein Datensatz gefunden wurde
                            {
                                string userName = reader["windows_username"].ToString();


                                timeAdminStrip.Text = "Zeit Admin:".PadRight(16) + $"{userName}";
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
