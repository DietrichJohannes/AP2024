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
using System.Windows.Forms.VisualStyles;

namespace AP2024
{
    public partial class UserAddThemselves : Form
    {
        int leaveEntitlement = 0;
        int remainingLeave = 0;

        int selectedViewID = 0;

        string windowsUser = string.Empty;

        bool CloseForm = false;

        public UserAddThemselves()
        {
            InitializeComponent();
            GetUserName();
            LoadViews();
            LoadDefaultSettings();
            ApplySettings();
        }

        private void GetUserName()
        {
            windowsUser = ApplicationContext.GetCurrentWindowsUser();
            windows_user.Text = windowsUser;
        }

        protected void LoadDefaultSettings()
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
                                leaveEntitlement = Convert.ToInt32(reader["can_add_themselves_leave_entitlement"]);  // Hole die Urlaubstage
                                remainingLeave = Convert.ToInt32(reader["can_add_themselves_remaining_leave"]);      // Hole die Resturlaubstage
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

        private void ApplySettings()
        {
            leave_entitlement.Text = leaveEntitlement.ToString();                                          // Setze die Urlaubstage
            remaining_leave.Text = remainingLeave.ToString();                                              // Setze die Resturlaubstage
        }

        private void LoadViews()
        {
            CBViews.DataSource = null;                                                               // Setze die DataSource auf null
            CBViews.Items.Clear();                                                                   // Lösche alle Items aus der ComboBox

            string connectionString = ApplicationContext.GetConnectionString();                      // Hole den ConnectionString

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();                                                              // Öffne die Verbindung zur Datenbank

                    string query = "SELECT id, view_name FROM Views";                               // SQL-Abfrage um alle Views zu holen

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            Dictionary<int, string> Views = new Dictionary<int, string>();          // Erstelle ein Dictionary um die Views zu speichern

                            while (reader.Read())                                                   // Lese alle Views aus der Datenbank
                            {
                                int id = Convert.ToInt32(reader["id"]);
                                string name = reader["view_name"].ToString();
                                Views.Add(id, name);
                            }

                            if (Views.Count > 0)
                            {
                                CBViews.DataSource = new BindingSource(Views, null);
                                CBViews.DisplayMember = "Value";
                                CBViews.ValueMember = "Key";
                                CBViews.SelectedIndex = 0;                                           // Wähle das erste Element aus
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

        private void UserAddThemselves_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!CloseForm)
            {
                // Nur wenn der Benutzer das Fenster manuell schließt:
                Environment.Exit(0);
            }
            // sonst: nichts tun -> einfach normal schließen
        }

        private void ExitForm()
        {
            if (CloseForm)
            {
                this.Close();                                                                          // Schließe das Formular
            }
            else
            {
                Environment.Exit(0);                                                                  // Beende die Anwendung
            }
        }

        private void SaveEmployee()
        {
            string firstName = firstNameText.Text;
            string lastName = lastNameText.Text;
            

            // Connection String für die Datenbank
            string connectionString = ApplicationContext.GetConnectionString();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    // Datenbankverbindung öffnen
                    connection.Open();

                    // Werte übergeben
                    string query = "INSERT INTO Employees (first_name, last_name, windows_username, view, leave_entitlement, remaining_leave) VALUES (@firstName, @lastName, @windowsUser, @viewID, @leaveEntitlement, @remainingLeave)";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@firstName", firstName);
                        command.Parameters.AddWithValue("@lastName", lastName);
                        command.Parameters.AddWithValue("@windowsUser", windowsUser);
                        command.Parameters.AddWithValue("@viewID", selectedViewID);
                        command.Parameters.AddWithValue("@leaveEntitlement", leaveEntitlement);
                        command.Parameters.AddWithValue("@remainingLeave", remainingLeave);

                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            NotificationController.Saved();
                            CloseForm = true;                     // erlaubt das Schließen ohne Exit
                            AP2024 mainform = new AP2024();
                            mainform.Show();                     // Zeige MainForm vor dem Schließen
                            this.Close();                        // Schließt nur das aktuelle Formular
                        }
                        else
                        {
                            MessageBox.Show("Mitarbeiter konnte nicht gespeichert werden.", "AP2024");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fehler: " + ex.Message);
                }
            }
        }

        private void GetSelectedID()
        {
            if (CBViews.SelectedItem != null)
            {
                KeyValuePair<int, string> selectedView = (KeyValuePair<int, string>)CBViews.SelectedItem;
                selectedViewID = selectedView.Key;                                                  // Hole die ID der ausgewählten View
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetSelectedID();
            SaveEmployee();
        }
    }
}
