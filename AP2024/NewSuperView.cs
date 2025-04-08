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
    public partial class NewSuperView : Form
    {
        int _NewSuperView_WindowMode { get; set; }

        public NewSuperView(int windowMode)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            _NewSuperView_WindowMode = windowMode;
            GetWindowMode();
        }

        private void GetWindowMode()
        {
            if (_NewSuperView_WindowMode == 2)
            {
                MessageBox.Show("Hier können Sie SuperViews hinzufügen.\nBeispiele sind z.B. Abteilungen, Gruppen, Teams...", "AP2024 Setup");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveSuperView();
        }

        private void SaveSuperView()
        {
            string viewName = superViewNameText.Text;


            // Connection String für die Datenbank
            string connectionString = ApplicationContext.GetConnectionString();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    // Datenbankverbindung öffnen
                    connection.Open();

                    // Werte übergeben
                    string query = "INSERT INTO SuperViews (super_view_name) VALUES (@superview_name)";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@superview_name", viewName);

                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            NotificationController.Saved();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("SuperView konnte nicht gespeichert werden.", "AP2024");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fehler: " + ex.Message);
                }
            }
        }
    }
}
