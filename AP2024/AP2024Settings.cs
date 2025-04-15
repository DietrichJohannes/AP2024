using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP2024
{
    public partial class AP2024Settings : Form
    {

        int leaveEntitlement = 0;
        int remainingLeave = 0;
        string department;
        bool UserCanAddThemselves = false;
        bool UserCanEditThemselves = false;


        public AP2024Settings()
        {
            InitializeComponent();
            LoadSettings();
            ApplySettings();
        }


        private void button1_Click(object sender, EventArgs e)
        {   
            GetSettings();
            SaveSettings();
        }

        private void GetSettings()
        {
            department = departmentTB.Text;                                                        // Hole die Abteilung
            leaveEntitlement = Convert.ToInt32(leave_entitlementNUD.Value);                        // Hole die Urlaubstage
            remainingLeave = Convert.ToInt32(remaining_leaveNUD.Value);                            // Hole die Resturlaubstage
            UserCanAddThemselves = user_can_add_themselvesCB.Checked;                              // Hole die Checkbox für User kann sich selbst hinzufügen
            UserCanEditThemselves = user_can_edit_themselvesCB.Checked;                            // Hole die Checkbox für User kann sich selbst bearbeiten
        }

        private void LoadSettings()
        {
            string connectionString = ApplicationContext.GetConnectionString();                      // Hole den ConnectionString
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();                                                              // Öffne die Verbindung zur Datenbank
                    string query = "SELECT * FROM Settings";                                        // SQL-Abfrage um alle Einstellungen zu holen
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())                                                   // Lese alle Einstellungen aus der Datenbank
                            {
                                department = reader["department"].ToString();                                 // Hole die Abteilung
                                leaveEntitlement = Convert.ToInt32(reader["can_add_themselves_leave_entitlement"]);  // Hole die Urlaubstage
                                remainingLeave = Convert.ToInt32(reader["can_add_themselves_remaining_leave"]);      // Hole die Resturlaubstage
                                UserCanAddThemselves = Convert.ToInt32(reader["can_add_themselves"]) == 1;
                                UserCanEditThemselves = Convert.ToInt32(reader["can_edit_themselves"]) == 1;

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

        private void SaveSettings()
        {
            string connectionString = ApplicationContext.GetConnectionString();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Falls die Settings-Tabelle leer ist, füge einen neuen Datensatz ein
                    string checkQuery = "SELECT COUNT(*) FROM Settings";
                    using (SQLiteCommand checkCmd = new SQLiteCommand(checkQuery, connection))
                    {
                        long count = (long)checkCmd.ExecuteScalar();

                        if (count == 0)
                        {
                            string insertQuery = @"INSERT INTO Settings 
                        (department, can_add_themselves_leave_entitlement, can_add_themselves_remaining_leave, 
                         can_add_themselves, can_edit_themselves)
                        VALUES (@department, @leaveEntitlement, @remainingLeave, @canAdd, @canEdit)";
                            using (SQLiteCommand insertCmd = new SQLiteCommand(insertQuery, connection))
                            {
                                insertCmd.Parameters.AddWithValue("@department", department);
                                insertCmd.Parameters.AddWithValue("@leaveEntitlement", leaveEntitlement);
                                insertCmd.Parameters.AddWithValue("@remainingLeave", remainingLeave);
                                insertCmd.Parameters.AddWithValue("@canAdd", UserCanAddThemselves ? 1 : 0);
                                insertCmd.Parameters.AddWithValue("@canEdit", UserCanEditThemselves ? 1 : 0);
                                insertCmd.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            string updateQuery = @"UPDATE Settings SET 
                        department = @department, 
                        can_add_themselves_leave_entitlement = @leaveEntitlement,
                        can_add_themselves_remaining_leave = @remainingLeave,
                        can_add_themselves = @canAdd,
                        can_edit_themselves = @canEdit";

                            using (SQLiteCommand updateCmd = new SQLiteCommand(updateQuery, connection))
                            {
                                updateCmd.Parameters.AddWithValue("@department", department);
                                updateCmd.Parameters.AddWithValue("@leaveEntitlement", leaveEntitlement);
                                updateCmd.Parameters.AddWithValue("@remainingLeave", remainingLeave);
                                updateCmd.Parameters.AddWithValue("@canAdd", UserCanAddThemselves ? 1 : 0);
                                updateCmd.Parameters.AddWithValue("@canEdit", UserCanEditThemselves ? 1 : 0);
                                updateCmd.ExecuteNonQuery();
                            }
                        }
                    }

                    NotificationController.Saved();                                                        // Zeige die Benachrichtigung an
                    this.Close();                                                                          // Schließe das Formular
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Fehler beim Speichern der Einstellungen");
                }
            }
        }

        private void ApplySettings()
        {
            departmentTB.Text = department;                                                        // Setze die Abteilung
            leave_entitlementNUD.Value = leaveEntitlement;                                          // Setze die Urlaubstage
            remaining_leaveNUD.Value = remainingLeave;                                            // Setze die Resturlaubstage
            user_can_add_themselvesCB.Checked = UserCanAddThemselves;                              // Setze die Checkbox für User kann sich selbst hinzufügen
            user_can_edit_themselvesCB.Checked = UserCanEditThemselves;                            // Setze die Checkbox für User kann sich selbst bearbeiten
        }
    }
}
