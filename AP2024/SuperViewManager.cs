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
    public partial class SuperViewManager : Form
    {
        public SuperViewManager()
        {
            InitializeComponent();
            LoadSuperViews();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NewSuperView newSuperView = new NewSuperView();
            newSuperView.ShowDialog();
        }

        private void LoadSuperViews()
        {
            // Clear the ListView before loading new data
            superviewList.Items.Clear();

            try
            {
                using (var connection = new SQLiteConnection(ApplicationContext.GetConnectionString()))
                {
                    connection.Open();

                    string query = "SELECT super_view_name FROM SuperViews";

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = query;

                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Sicherstellen, dass tarifurlaub, resturlaub, windows_benutzername und view nicht null sind
                                string SuperViewName = reader["super_view_name"]?.ToString() ?? "0";



                                // SubItems hinzufügen und null-geschützte Werte einfügen
                                var item = new ListViewItem(SuperViewName);


                                // Füge das Item in die ListView ein
                                superviewList.Items.Add(item);
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
