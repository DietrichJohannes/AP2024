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

        public event Action OnEmployeeManagerExit;

        public EmployeeManager()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            LoadEmployees();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NewEmployee newEmployee = new NewEmployee();
            newEmployee.OnEmployeeSaved += LoadEmployees;
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

                    string query = "SELECT id, first_name, last_name, leave_entitlement, remaining_leave, windows_username, view, sick_days FROM Employees ORDER BY last_name ASC";


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
                                string krankheitstage = reader["sick_days"]?.ToString() ?? "0"; // Krankheitstage lesen

                                // SubItems hinzufügen und null-geschützte Werte einfügen
                                int mitarbeiterId = Convert.ToInt32(reader["id"]); // ID lesen

                                var item = new ListViewItem(fullName);
                                item.SubItems.Add(windowsBenutzername);
                                item.SubItems.Add(view);
                                item.SubItems.Add(krankheitstage);
                                item.SubItems.Add(resturlaub);
                                item.SubItems.Add(tarifurlaub);
                                item.Tag = mitarbeiterId; // ID im Tag speichern

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
            if (employeeListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bitte wählen Sie einen Mitarbeiter aus.");
                return;
            }

            var selectedItem = employeeListView.SelectedItems[0];
            if (selectedItem.Tag is int mitarbeiterId)
            {
                RoleManagement roleManagement = new RoleManagement(mitarbeiterId);
                roleManagement.ShowDialog();
            }
            else
            {
                MessageBox.Show("Mitarbeiter-ID konnte nicht gelesen werden.");
            }
        }

        private void EmployeeManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            OnEmployeeManagerExit?.Invoke();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bool result = MessageBox.Show("Möchten Sie wirklich alle Krankheitstage zurücksetzen?", "AP2024", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes;
            
            if (result) {
                LeaveHandler.ResetSickdays();
                LoadEmployees();
            }
            else
            {
                MessageBox.Show("Aktion abgebrochen.");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            bool result = MessageBox.Show("Möchten Sie wirklich ALLEN Mitarbeitern den Tarifurlaub zuweisen?", "AP2024", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes;

            if (result)
            {
                LeaveHandler.DistributeVacationdays();
                LoadEmployees();
            }
            else
            {
                MessageBox.Show("Aktion abgebrochen.");
            }
        }
    }
}
