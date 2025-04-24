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
    public partial class NewEmployee : Form
    {
        int SelectedViewID = 0;
        int _mode;              // 0 = Neu, 1 = Bearbeiten
        int _employeeID = 0;
        public event Action OnEmployeeSaved;

        public NewEmployee(int employeeID, int mode)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            LoadViews();
            _mode = mode;
            _employeeID = employeeID;

            if (_mode == 1)
            {
                LoadEmployeeData();
                moreEmployees.Visible = false;
                moreEmployeesText.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetSelectedViewID();
            SaveEmployee();
            OnEmployeeSaved?.Invoke();
        }

        private void LoadViews()
        {
            string connectionString = ApplicationContext.GetConnectionString();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT id, view_name FROM Views";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            viewCB.Items.Clear();

                            Dictionary<int, string> Views = new Dictionary<int, string>();

                            while (reader.Read())
                            {
                                int id = Convert.ToInt32(reader["id"]);
                                string name = reader["view_name"].ToString();

                                Views.Add(id, name);
                            }

                            viewCB.DataSource = new BindingSource(Views, null);
                            viewCB.DisplayMember = "Value";
                            viewCB.ValueMember = "Key";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "AP2024");
                }
            }
        }

        private void LoadEmployeeData()
        {
            string connectionString = ApplicationContext.GetConnectionString();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Employees WHERE id = @id";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", _employeeID);

                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                firstNameText.Text = reader["first_name"].ToString();
                                lastNameText.Text = reader["last_name"].ToString();
                                windowsUserText.Text = reader["windows_username"].ToString();
                                leaveEntitlementNUD.Value = Convert.ToInt32(reader["leave_entitlement"]);
                                remainingLeaveNUD.Value = Convert.ToInt32(reader["remaining_leave"]);

                                int viewID = Convert.ToInt32(reader["view"]);
                                viewCB.SelectedValue = viewID;
                                SelectedViewID = viewID;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fehler beim Laden der Mitarbeiterdaten: " + ex.Message, "AP2024");
                }
            }
        }

        private void SaveEmployee()
        {
            string firstName = firstNameText.Text;
            string lastName = lastNameText.Text;
            string windowsUser = windowsUserText.Text;
            int viewID = SelectedViewID;
            int leaveEntitlement = (int)leaveEntitlementNUD.Value;
            int remainingLeave = (int)remainingLeaveNUD.Value;

            string connectionString = ApplicationContext.GetConnectionString();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query;

                    if (_mode == 1)
                    {
                        query = "UPDATE Employees SET first_name = @firstName, last_name = @lastName, windows_username = @windowsUser, view = @viewID, leave_entitlement = @leaveEntitlement, remaining_leave = @remainingLeave WHERE id = @id";
                    }
                    else
                    {
                        query = "INSERT INTO Employees (first_name, last_name, windows_username, view, leave_entitlement, remaining_leave) VALUES (@firstName, @lastName, @windowsUser, @viewID, @leaveEntitlement, @remainingLeave)";
                    }

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@firstName", firstName);
                        command.Parameters.AddWithValue("@lastName", lastName);
                        command.Parameters.AddWithValue("@windowsUser", windowsUser);
                        command.Parameters.AddWithValue("@viewID", viewID);
                        command.Parameters.AddWithValue("@leaveEntitlement", leaveEntitlement);
                        command.Parameters.AddWithValue("@remainingLeave", remainingLeave);

                        if (_mode == 1)
                            command.Parameters.AddWithValue("@id", _employeeID);

                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            NotificationController.Saved();
                            if (_mode == 0 && moreEmployees.Checked)
                            {
                                ClearInputFields();
                            }
                            else
                            {
                                this.Close();
                            }
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

        private void GetSelectedViewID()
        {
            if (viewCB != null)
            {
                SelectedViewID = (int)viewCB.SelectedValue;
            }
        }

        private void ClearInputFields()
        {
            firstNameText.Text = "";
            lastNameText.Text = "";
            windowsUserText.Text = "";
            leaveEntitlementNUD.Value = 30;
            remainingLeaveNUD.Value = 10;
        }
    }
}
