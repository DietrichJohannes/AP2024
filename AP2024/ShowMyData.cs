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
    public partial class ShowMyData : Form
    {
        bool UserCanEdit = false;
        bool EditModeActive = false;

        public ShowMyData()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            LoadPersonalData();
            GetEditSettings();
            SetSettings();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(EditModeActive)
            {
                UpdatePersonalData();
            }
            else
            {
                this.Close();
            }
        }

        private void GetEditSettings()
        {
            string query = "SELECT * FROM Settings";
            using (SQLiteConnection connection = new SQLiteConnection(ApplicationContext.GetConnectionString()))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (reader["can_edit_themselves"].ToString() == "1")
                            {
                                UserCanEdit = true;
                            }
                            else
                            {
                                UserCanEdit = false;
                            }
                        }
                    }
                }
            }
        }

        private void SetSettings()
        {
            if (UserCanEdit)
            {
                edit_button.Enabled = true;
            }
            else
            {
                edit_button.Enabled = false;
            }
        }

        private void LoadPersonalData()
        {
            string query = "SELECT * FROM Employees WHERE ID = @ID";
            using (SQLiteConnection connection = new SQLiteConnection(ApplicationContext.GetConnectionString()))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", ApplicationContext.USER_ID);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            first_name.Text = reader["first_name"].ToString();
                            last_name.Text = reader["last_name"].ToString();
                            windows_user.Text = reader["windows_username"].ToString();
                            remaining_leav.Text = reader["remaining_leave"].ToString();
                            leave_entitlement.Text = reader["leave_entitlement"].ToString();
                            sick_days.Text = reader["sick_days"].ToString();
                        }
                    }
                }
            }
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            EditModeActive = true;

            disclaimer1.Visible = true;
            disclaimer2.Visible = true;
            disclaimer3.Visible = true;
            disclaimer4.Visible = true;
            disclaimer5.Visible = true;


            first_name.ReadOnly = false;
            last_name.ReadOnly = false;

            button1.Text = "Änderungen speichern";
        }

        private void UpdatePersonalData()
        {
            string updateQuery = @"UPDATE Employees SET first_name = @FirstName, last_name = @LastName WHERE ID = @ID";

            using (SQLiteConnection connection = new SQLiteConnection(ApplicationContext.GetConnectionString()))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", first_name.Text);
                    command.Parameters.AddWithValue("@LastName", last_name.Text);
                    command.Parameters.AddWithValue("@ID", ApplicationContext.USER_ID);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        NotificationController.Saved();

                        EditModeActive = false;
                        button1.Text = "OK";

                        disclaimer1.Visible = false;
                        disclaimer2.Visible = false;
                        disclaimer3.Visible = false;
                        disclaimer4.Visible = false;
                        disclaimer5.Visible = false;


                        first_name.ReadOnly = true;
                        last_name.ReadOnly = true;

                    }
                    else
                    {
                        MessageBox.Show("Aktualisierung fehlgeschlagen.");
                    }
                }
            }

        }
    }
}
