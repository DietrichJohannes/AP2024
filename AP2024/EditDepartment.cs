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
    public partial class EditDepartment : Form
    {

        public event Action OnDepartmentEdit;
        public EditDepartment()
        {
            InitializeComponent();
            LoadDepartment();
        }

        private void LoadDepartment()
        {
            string connString = ApplicationContext.GetConnectionString();
            try
            {
                using (var connection = new SQLiteConnection(connString))
                {
                    connection.Open();
                    string query = "SELECT department FROM Settings WHERE id = 1";
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        var result = command.ExecuteScalar();
                        if (result != null)
                        {
                            departmentText.Text = result.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datenbankfehler: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string department = departmentText.Text;

            if (string.IsNullOrWhiteSpace(department))
            {
                MessageBox.Show("Bitte geben Sie eine Abteilung ein.");
                return;
            }

            string connString = ApplicationContext.GetConnectionString();
            if (string.IsNullOrWhiteSpace(connString))
            {
                MessageBox.Show("Fehler: Keine gültige Verbindung zur Datenbank.");
                return;
            }

            try
            {
                using (var connection = new SQLiteConnection(connString))
                {
                    connection.Open();

                    // Sicherstellen, dass es eine Zeile mit ID = 1 gibt
                    string checkQuery = "SELECT COUNT(*) FROM Settings WHERE id = 1";
                    using (var checkCommand = new SQLiteCommand(checkQuery, connection))
                    {
                        long count = (long)checkCommand.ExecuteScalar();

                        if (count == 0)
                        {
                            // Falls keine Zeile vorhanden: neue mit ID = 1 einfügen
                            string insertQuery = "INSERT INTO Settings (id, department) VALUES (1, @department)";
                            using (var insertCommand = new SQLiteCommand(insertQuery, connection))
                            {
                                insertCommand.Parameters.AddWithValue("@department", department);
                                insertCommand.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            // Falls Zeile vorhanden: aktualisieren
                            string updateQuery = "UPDATE Settings SET department = @department WHERE id = 1";
                            using (var updateCommand = new SQLiteCommand(updateQuery, connection))
                            {
                                updateCommand.Parameters.AddWithValue("@department", department);
                                updateCommand.ExecuteNonQuery();
                            }
                        }
                    }
                }

                NotificationController.Saved();
                OnDepartmentEdit?.Invoke();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datenbankfehler: " + ex.Message);
            }
        }
    }
}
