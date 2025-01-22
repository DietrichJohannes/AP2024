using System.Data.SQLite;
using System.Windows.Forms;

namespace AP2024
{
    public partial class AP2024 : Form
    {
        private CalendarController calendarController;

        int SelectedView = 0;

        public AP2024()
        {
            InitializeComponent();
            InitCalendar();                                                                 // Initialisiere den Kalender
            DatabaseController.InitializeDatabase();                                        // Initialisiere (Erstelle) die Datenbank
            LoadViews();
            GetSelectedView();
            LoadEmployees();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        private void InitCalendar()
        {

            calendarController = new CalendarController();
            calendarController.CreateCalendarMonth(monthView);

            // Kalenderwochenansicht erstellen
            calendarController.CreateCalendarWeek(cwView);

            // Tagesansicht erstellen
            calendarController.CreateCalendarDay(calendarView);
        }

        private void calendarView_Scroll(object sender, ScrollEventArgs e)
        {
            SynchronizeScroll();
        }

        private void SynchronizeScroll()
        {

        }

        private void LoadViews()
        {
            string connectionString = ApplicationContext.GetConnectionString();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT id, view_name FROM Views";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            viewCB.Items.Clear();

                            Dictionary<int, string> Views = new Dictionary<int, string>();

                            while (reader.Read())
                            {
                                int id = Convert.ToInt32(reader["id"]);
                                string name = reader["view_name"].ToString();

                                // Füge den Namen zur ComboBox hinzu und speichere die ID
                                Views.Add(id, name);
                            }

                            // Setze DisplayMember und ValueMember
                            viewCB.DataSource = new BindingSource(Views, null);
                            viewCB.DisplayMember = "Value"; // Zeige den Namen an
                            viewCB.ValueMember = "Key";     // Speichere die ID
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "AP2024");
                }
            }
        }

        private void GetSelectedView()
        {
            if (viewCB != null)
            {
                SelectedView = (int)viewCB.SelectedValue;
            }
            else
            {
                MessageBox.Show("Keine View ausgewählt");
            }
        }


        private void LoadEmployees()
        {

            ClearDataGridView();

            try
            {
                using (var connection = new SQLiteConnection(ApplicationContext.GetConnectionString()))
                {
                    connection.Open();

                    string query = "SELECT first_name, last_name, remaining_leave FROM Employees  WHERE view = @view";

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = query;

                        command.Parameters.AddWithValue("@view", SelectedView);

                        using (var reader = command.ExecuteReader())
                        {
                            int rowIndex = 1; // Start ab Zeile 1 im DataGridView

                            while (reader.Read())
                            {
                                // Prüfen, ob Vorname und Nachname null sind
                                string vorname = reader["first_name"]?.ToString() ?? "Unbekannt";
                                string nachname = reader["last_name"]?.ToString() ?? "Unbekannt";
                                string fullName = $"{vorname} {nachname}";

                                // Sicherstellen, dass keine Werte null sind
                                string resturlaub = reader["remaining_leave"]?.ToString() ?? "0";

                                // Dynamisch Zeilen hinzufügen, falls nicht genügend vorhanden
                                while (calendarView.Rows.Count <= rowIndex)
                                {
                                    calendarView.Rows.Add();
                                }

                                // Werte in die Zellen schreiben
                                calendarView.Rows[rowIndex].Cells[0].Value = fullName; // Spalte 0: Mitarbeitername
                                calendarView.Rows[rowIndex].Cells[1].Value = resturlaub; // Spalte 1: Resturlaub

                                rowIndex++; // Zur nächsten Zeile gehen
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Laden der Mitarbeiterdaten: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ClearDataGridView()
        {
            // Überprüfen, ob das DataGridView mehr als eine Zeile hat
            if (calendarView.Rows.Count > 1)
            {
                // Schleife rückwärts, um Zeilen sicher zu entfernen
                for (int i = calendarView.Rows.Count - 1; i >= 1; i--)
                {
                    calendarView.Rows.RemoveAt(i);
                }
            }
        }


        private void infoÜberDenEntwicklerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DevInfo devInfo = new DevInfo();
            devInfo.ShowDialog();
        }

        private void mitarbeiterverwaltungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeManager employeeManager = new EmployeeManager();
            employeeManager.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewManager viewManager = new ViewManager();
            viewManager.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void viewCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetSelectedView();
            LoadEmployees();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AbsenceManager absenceManager = new AbsenceManager();
            absenceManager.Show();
        }

        private void testToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Saved saved = new Saved();
            saved.Show();
        }
    }
}
