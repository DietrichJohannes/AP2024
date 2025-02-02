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
        public event Action OnDataSaved;

        public NewEmployee()
        {
            InitializeComponent();
            LoadViews();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetSelectedViewID();
            SaveEmployee();
            OnDataSaved?.Invoke();
        }

        private void SaveEmployee()
        {
            string firstName = firstNameText.Text;
            string lastName = lastNameText.Text;
            string windowsUser = windowsUserText.Text;
            int viewID = SelectedViewID;
            int leaveEntitlement = (int)leaveEntitlementNUD.Value;
            int remainingLeave = (int)remainingLeaveNUD.Value;

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
                        command.Parameters.AddWithValue("@viewID", viewID);
                        command.Parameters.AddWithValue("@leaveEntitlement", leaveEntitlement);
                        command.Parameters.AddWithValue("@remainingLeave", remainingLeave);

                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            NotificationController.Saved();
                            if (moreEmployees.Checked)
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

                                // Füge den Namen zur ComboBox hinzu und speichere die ID
                                Views.Add(id, name);
                            }

                            // Setze DisplayMember und ValueMember
                            viewCB.DataSource = new BindingSource(Views, null);
                            viewCB.DisplayMember = "Value"; // Zeige den Namen an
                            viewCB.ValueMember = "Key";     // Speichere die ID
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "AP2024");
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
