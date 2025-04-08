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
    public partial class AbsenceManager : Form
    {

        public event Action OnAbsenceManagerExit;

        public AbsenceManager()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            LoadAbsenceTypes();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NewAbsenceType newAbsence = new NewAbsenceType();
            newAbsence.OnAbsenceTypeSaved += LoadAbsenceTypes;
            newAbsence.ShowDialog();
        }

        protected void LoadAbsenceTypes()
        {
            // Clear the ListView before loading new data
            absenceTypeListView.Items.Clear();

            try
            {
                using (var connection = new SQLiteConnection(ApplicationContext.GetConnectionString()))
                {
                    connection.Open();

                    string query = "SELECT type_name, abbreviation, color, requires_comment FROM AbsenceTypes";

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = query;

                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Sicherstellen, dass tarifurlaub, resturlaub, windows_benutzername und view nicht null sind
                                string abwesenheitstypName = reader["type_name"]?.ToString() ?? "Kein Name gefunden";
                                string abkürzung = reader["abbreviation"]?.ToString() ?? "Keine Abkürtzung gefunden";
                                string farbe = reader["color"]?.ToString() ?? "Keine Farbe gefunden";
                                string kommentarVerlangen = reader["requires_comment"]?.ToString() ?? "Unbekannt";

                                // SubItems hinzufügen und null-geschützte Werte einfügen
                                var item = new ListViewItem(abwesenheitstypName);
                                item.SubItems.Add(abkürzung);
                                item.SubItems.Add(farbe);
                                item.SubItems.Add(kommentarVerlangen);

                                // Füge das Item in die ListView ein
                                absenceTypeListView.Items.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Laden der Abwesenheitstypen: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AbsenceManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            OnAbsenceManagerExit?.Invoke();
        }
    }
}

