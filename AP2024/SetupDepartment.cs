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
    public partial class SetupDepartment : Form
    {
        public SetupDepartment()
        {
            InitializeComponent();
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
                    string query = "INSERT INTO Settings (department) VALUES (@department)";
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = query;
                        command.Parameters.AddWithValue("@department", department);
                        command.ExecuteNonQuery();
                    }
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datenbankfehler: " + ex.Message);
            }
        }

    }
}
