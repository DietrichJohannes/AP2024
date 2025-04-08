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
    public partial class AdminManager : Form
    {
        public AdminManager()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            LoadAdmins();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void LoadAdmins()
        {
            // Clear the ListView before loading new data
            adminListView.Items.Clear();

            try
            {
                using (var connection = new SQLiteConnection(ApplicationContext.GetConnectionString()))
                {
                    connection.Open();

                    string query = "SELECT windows_username, admin_roll FROM Administrators";

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = query;

                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                
                                string userName = reader["windows_username"]?.ToString() ?? "0";
                                string adminRoll = reader["admin_roll"]?.ToString() ?? "0";



                                // SubItems hinzufügen und null-geschützte Werte einfügen
                                var item = new ListViewItem(userName);
                                item.SubItems.Add(adminRoll);


                                // Füge das Item in die ListView ein
                                adminListView.Items.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler: {ex.Message}", "AP2024", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

