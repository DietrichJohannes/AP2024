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
    public partial class NewView : Form
    {
        int SelectedSuperViewID = 0;
        public static event Action OnViewSaved;

        public NewView()
        {
            InitializeComponent();
            LoadSuperViews();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewSuperView newSuperView = new NewSuperView();
            newSuperView.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetSelectedViewID();
            SaveNewView();
        }

        private void SaveNewView()
        {
            string viewName = viewNameText.Text;


            // Connection String für die Datenbank
            string connectionString = ApplicationContext.GetConnectionString();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    // Datenbankverbindung öffnen
                    connection.Open();

                    // Werte übergeben
                    string query = "INSERT INTO Views (view_name, parent_view_id) VALUES (@viewName, @parentViewID)";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@viewName", viewName);
                        command.Parameters.AddWithValue("@parentViewID", SelectedSuperViewID);

                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            NotificationController.Saved();
                            OnViewSaved?.Invoke();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("View konnte nicht gespeichert werden.", "AP2024");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fehler: " + ex.Message);
                }
            }
        }

        private void LoadSuperViews()
        {
            string connectionString = ApplicationContext.GetConnectionString();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT id, super_view_name FROM SuperViews";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            superViewCB.Items.Clear();

                            Dictionary<int, string> Views = new Dictionary<int, string>();

                            while (reader.Read())
                            {
                                int id = Convert.ToInt32(reader["id"]);
                                string name = reader["super_view_name"].ToString();

                                // Füge den Namen zur ComboBox hinzu und speichere die ID
                                Views.Add(id, name);
                            }

                            // Setze DisplayMember und ValueMember
                            superViewCB.DataSource = new BindingSource(Views, null);
                            superViewCB.DisplayMember = "Value"; // Zeige den Namen an
                            superViewCB.ValueMember = "Key";     // Speichere die ID
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
            if (superViewCB != null)
            {
                SelectedSuperViewID = (int)superViewCB.SelectedValue;
            }
        }
    }
}
