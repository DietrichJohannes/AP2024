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
            NewEmployee newEmployee = new NewEmployee(0, 0);
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
            int mode = 1; // 0 = Edit Sickdays, 1 = Edit Vacationdays

            if (employeeListView.SelectedItems.Count == 0)
            {
                NotificationController.SelectItem();
                return;
            }

            var selectedItem = employeeListView.SelectedItems[0];
            if (selectedItem.Tag is int mitarbeiterId)
            {
                OpenEditForm(mitarbeiterId, mode);
            }
            else
            {
                MessageBox.Show("Mitarbeiter-ID konnte nicht gelesen werden.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (employeeListView.SelectedItems.Count == 0)
            {
                NotificationController.SelectItem();
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

            if (result)
            {
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

        private void button6_Click(object sender, EventArgs e)
        {
            int mode = 0; // 0 = Edit Sickdays, 1 = Edit Vacationdays

            if (employeeListView.SelectedItems.Count == 0)
            {
                NotificationController.SelectItem();
                return;
            }

            var selectedItem = employeeListView.SelectedItems[0];
            if (selectedItem.Tag is int mitarbeiterId)
            {
                OpenEditForm(mitarbeiterId, mode);
            }
            else
            {
                MessageBox.Show("Mitarbeiter-ID konnte nicht gelesen werden.");
            }
        }

        private void OpenEditForm(int EmployeeID, int mode)
        {
            EditVacationAndSickDays editForm = new EditVacationAndSickDays(EmployeeID, mode);
            editForm.OnEditFormExit += LoadEmployees;
            editForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int mode = 1; // 0 = Add, 1 = Edit

            if (employeeListView.SelectedItems.Count == 0)
            {
                NotificationController.SelectItem();
                return;
            }

            var selectedItem = employeeListView.SelectedItems[0];
            if (selectedItem.Tag is int mitarbeiterId)
            {
                NewEmployee newEmployee = new NewEmployee(mitarbeiterId, mode);
                newEmployee.OnEmployeeSaved += LoadEmployees; 
                newEmployee.ShowDialog();
            }
            else
            {
                MessageBox.Show("Mitarbeiter-ID konnte nicht gelesen werden.");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (employeeListView.SelectedItems.Count == 0)
            {
                NotificationController.SelectItem();
                return;
            }

            var selectedItem = employeeListView.SelectedItems[0];
            if (selectedItem.Tag is int mitarbeiterId)
            {
                var result = MessageBox.Show("Möchtest du diesen Mitarbeiter wirklich löschen?", "Löschen bestätigen", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result != DialogResult.Yes)
                    return;

                try
                {
                    using (var connection = new SQLiteConnection(ApplicationContext.GetConnectionString()))
                    {
                        connection.Open();

                        using (var command = connection.CreateCommand())
                        {
                            command.CommandText = "DELETE FROM Employees WHERE id = @id";
                            command.Parameters.AddWithValue("@id", mitarbeiterId);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                employeeListView.Items.Remove(selectedItem);
                                NotificationController.Deleted();
                            }
                            else
                            {
                                MessageBox.Show("Kein Mitarbeiter wurde gelöscht. Überprüfe die ID.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Fehler beim Löschen des Mitarbeiters: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Mitarbeiter-ID konnte nicht gelesen werden.");
            }
        }


    }
}
