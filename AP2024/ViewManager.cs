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
    public partial class ViewManager : Form
    {

        public event Action OnViewManagerExit;
        public ViewManager()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            LoadViews();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SuperViewManager superViewManager = new SuperViewManager();
            superViewManager.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NewView newView = new NewView(0);
            NewView.OnViewSaved += LoadViews;
            newView.ShowDialog();
        }


        private void LoadViews()
        {
            // Clear the ListView before loading new data
            viewList.Items.Clear();

            try
            {
                using (var connection = new SQLiteConnection(ApplicationContext.GetConnectionString()))
                {
                    connection.Open();

                    string query = "SELECT view_name, parent_view_id FROM Views";

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = query;

                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Sicherstellen, dass tarifurlaub, resturlaub, windows_benutzername und view nicht null sind
                                string viewName = reader["view_name"]?.ToString() ?? "0";
                                string superView = reader["parent_view_id"]?.ToString() ?? "0";


                                // SubItems hinzufügen und null-geschützte Werte einfügen
                                var item = new ListViewItem(viewName);
                                item.SubItems.Add(superView);

                                // Füge das Item in die ListView ein
                                viewList.Items.Add(item);
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

        private void ViewManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            OnViewManagerExit?.Invoke();
        }
    }
}
