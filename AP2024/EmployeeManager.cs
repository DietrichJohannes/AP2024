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
    public partial class EmployeeManager : Form
    {
        public EmployeeManager()
        {
            InitializeComponent();
            LoadEmployees();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NewEmployee newEmployee = new NewEmployee();
            newEmployee.OnDataSaved += LoadEmployees;
            newEmployee.Show();
        }

        private void LoadEmployees()
        {
            // Clear the ListView before loading new data
            employeeListView.Items.Clear();

            try
            {
                using (var connection = new SQLiteConnection(ApplicationContext.GetConnectionString()))
                {
                    connection.Open();

                    string query = "SELECT first_name, last_name, leave_entitlement, remaining_leave, windows_username, view FROM Employees";

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = query;

                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Prüfen, ob Vorname und Nachname null sind
                                string vorname = reader["first_name"]?.ToString() ?? "Unbekannt";
                                string nachname = reader["last_name"]?.ToString() ?? "Unbekannt";
                                string fullName = $"{vorname} {nachname}";



                                // Sicherstellen, dass tarifurlaub, resturlaub, windows_benutzername und view nicht null sind
                                string tarifurlaub = reader["leave_entitlement"]?.ToString() ?? "0";
                                string resturlaub = reader["remaining_leave"]?.ToString() ?? "0";
                                string windowsBenutzername = reader["windows_username"]?.ToString() ?? "Unbekannt";
                                string view = reader["view"]?.ToString() ?? "Keine Ansicht";

                                // SubItems hinzufügen und null-geschützte Werte einfügen
                                var item = new ListViewItem(fullName);
                                item.SubItems.Add(windowsBenutzername);
                                item.SubItems.Add(view);
                                item.SubItems.Add(resturlaub);
                                item.SubItems.Add(tarifurlaub);

                                // Füge das Item in die ListView ein
                                employeeListView.Items.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Laden der Mitarbeiterdaten: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            RoleManagement roleManagement = new RoleManagement();
            roleManagement.ShowDialog();
        }
    }
}
