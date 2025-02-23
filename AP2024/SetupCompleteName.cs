using System;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace AP2024
{
    public partial class SetupCompleteName : Form
    {
        private ToolTip toolTip;

        public SetupCompleteName()
        {
            InitializeComponent();
            viewHint();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveSuperAdmin();
        }



        private void SaveSuperAdmin()
        {
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string windowsUser = ApplicationContext.GetCurrentWindowsUser();
            int viewID = 1;
            int leaveEntitlement = 30;
            int remainingLeave = 30;

            string connectionString = ApplicationContext.GetConnectionString();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
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
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Beim Speichern ist ein Fehler aufgetreten!", "AP2024");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fehler: " + ex.Message);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
             viewHint();
        }

        private void viewHint()
        {
            MessageBox.Show("Bitte geben Sie Ihren Vor- und Nachnamen ein und Klicken Sie OK.", "AP2024");
        }
    }
}
