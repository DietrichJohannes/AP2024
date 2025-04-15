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
    public partial class RoleManagement : Form
    {
        private int _employeeId;

        public RoleManagement(int employeeId)
        {
            InitializeComponent();
            _employeeId = employeeId;
            ThemeManager.ApplyTheme(this);
            GetEmployeeName();
        }

        private void GetEmployeeName() 
        {
            try
            {
                using (var connection = new SQLiteConnection(ApplicationContext.GetConnectionString()))
                {
                    connection.Open();
                    string query = "SELECT first_name, last_name FROM Employees WHERE id = @id";
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", _employeeId);
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string vorname = reader["first_name"]?.ToString() ?? "Unbekannt";
                                string nachname = reader["last_name"]?.ToString() ?? "Unbekannt";
                                string fullName = $"{vorname} {nachname}";
                                employee_Name.Text = fullName;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Abrufen des Mitarbeiters: " + ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            RoleInfo roleInfo = new RoleInfo();
            roleInfo.ShowDialog();
        }
    }
}
