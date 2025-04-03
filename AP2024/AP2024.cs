using System.Data.SQLite;
using System.Diagnostics;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AP2024
{
    public partial class AP2024 : Form
    {
        private CalendarController calendarController;
        int SelectedView = 0;

        public AP2024()
        {
            InitializeComponent();
            InitDataGridView();
            InitCalendar();                                                                 // Initialisiere den Kalender
            DatabaseController.InitializeDatabase();                                        // Initialisiere (Erstelle) die Datenbank
            ApplicationContext.InitStart();                                                 // Initialisiere die Anwendung
            LoadViews();                                                                    // Lade die Verfügbaren Views in die ComboBox
            GetSelectedView();                                                              // Hole die ID des ausgewählten Views
            LoadEmployees();                                                                // Lade die Mitarbeiter dem View entsprechend dem View
            LoadAbsenceTypes();                                                             // Lade die Abwesenheitsarten in den ContextMenuStrip
            AbsenceController.LoadAbsence();                                                // Lade die Abwesenheiten in den Kalender
            RollController.EnableAdminControls(administrationToolStripMenuItem);            // Aktiviere Adminrechte falls vergeben
            StatusStripController.SetStatusStrip(statusStrip1);                             // Setze den StatusStrip
            calendarController.HighlightWeekends(calendarView);                             // Markiere die Wochenenden in der Tagesansicht grau;                                   // Markiere die Wochenenden in der Wochenansicht
        }

        private void InitDataGridView()
        {
            typeof(DataGridView).InvokeMember("DoubleBuffered",
            System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.SetProperty,
            null, calendarView, new object[] { true });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadEmployees();                                                                // Lade die Mitarbeeiter neu
            AbsenceController.LoadAbsence();                                                // Lade die Abwesenheiten neu
            calendarController.HighlightHolidays(calendarView);                             // Markiere die Feiertage in der Tagesansicht grau
            calendarController.HighlightWeekends(calendarView);                             // Markiere die Wochenenden in der Tagesansicht grau
            StatusStripController.SetLastUpdated();                                         // Setze den letzten Aktualisierungszeitpunkt
        }

        private void InitCalendar()
        {
            calendarController = new CalendarController();                                  // Initialisiere den CalendarController

            calendarController.CreateCalendarMonth(monthView);                              // Erstelle den Monatskalender

            calendarController.CreateCalendarWeek(cwView);                                  // Erstelle den Wochenkalender

            calendarController.CreateCalendarDay(calendarView);                             // Erstelle den Tageskalender

            calendarController.HighlightHolidays(calendarView);                             // Markiere die Feiertage in der Tagesansicht grau

            calendarController.CreateSilentCalendar(calendarView);                          // Erstelle den Silent-Kalender

            ScrollToToday();                                                                // Scrolle zum heutigen Tag
        }

        private void ScrollToToday()
        {
            calendarController.HighlightToday(calendarView);                                 // Markiere den heutigen Tag in der Tagesansicht gelb
        }

        private void calendarView_Scroll(object sender, ScrollEventArgs e)
        {
            SynchronizeScroll();                                                            // Rufe Methode auf um das Scrollen zu synchronisieren
        }

        private void SynchronizeScroll()
        {

        }

        private void LoadViews()
        {
            viewCB.DataSource = null;                                                               // Setze die DataSource auf null
            viewCB.Items.Clear();                                                                   // Lösche alle Items aus der ComboBox

            string connectionString = ApplicationContext.GetConnectionString();                     // Hole den ConnectionString

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();                                                              // Öffne die Verbindung zur Datenbank

                    string query = "SELECT id, view_name FROM Views";                               // SQL-Abfrage um alle Views zu holen

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            Dictionary<int, string> Views = new Dictionary<int, string>();          // Erstelle ein Dictionary um die Views zu speichern

                            while (reader.Read())                                                   // Lese alle Views aus der Datenbank
                            {
                                int id = Convert.ToInt32(reader["id"]);
                                string name = reader["view_name"].ToString();
                                Views.Add(id, name);
                            }

                            if (Views.Count > 0)
                            {
                                viewCB.DataSource = new BindingSource(Views, null);
                                viewCB.DisplayMember = "Value";
                                viewCB.ValueMember = "Key";
                                viewCB.SelectedIndex = 0;                                           // Wähle das erste Element aus
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "AP2024");
                }
            }
        }


        private void GetSelectedView()                                                            // Lese die ID des ausgewählen Views aus
        {
            if (viewCB != null && viewCB.SelectedValue != null)
            {
                SelectedView = (int)viewCB.SelectedValue;
            }
            else
            {

            }
        }



        private void LoadEmployees()                                                             // Methode: Lade die Mitarbeiter in das DataGridView
        {

            ClearDataGridView();                                                                 // Lösche alle Zeilen aus dem DataGridView

            try
            {
                using (var connection = new SQLiteConnection(ApplicationContext.GetConnectionString()))
                {
                    connection.Open();                                                          // Öffne die Verbindung zur Datenbank

                    string query = "SELECT first_name, last_name, remaining_leave FROM Employees  WHERE view = @view ORDER BY last_name ASC";      // SQL-Abfrage um alle Mitarbeiter zu holen

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = query;

                        command.Parameters.AddWithValue("@view", SelectedView);                                             // View als Parameter hinzufügen

                        using (var reader = command.ExecuteReader())
                        {
                            int rowIndex = 1;                                                                               // Start ab Zeile 1 im DataGridView

                            while (reader.Read())
                            {

                                string vorname = reader["first_name"]?.ToString() ?? "Unbekannt";                           // Hole den Vornamen aus der Datenbank
                                string nachname = reader["last_name"]?.ToString() ?? "Unbekannt";                           // Hole den Nachnamen aus der Datenbank
                                string fullName = $"{vorname} {nachname}";                                                  // Setze den Namen zusammen

                                // Sicherstellen, dass keine Werte null sind
                                string resturlaub = reader["remaining_leave"]?.ToString() ?? "0";                           // Hole den Resturlaub aus der Datenbank

                                // Dynamisch Zeilen hinzufügen, falls nicht genügend vorhanden
                                while (calendarView.Rows.Count <= rowIndex)
                                {
                                    calendarView.Rows.Add();                                                                // Füge eine neue Zeile hinzu
                                }

                                // Werte in die Zellen schreiben
                                calendarView.Rows[rowIndex].Cells[0].Value = fullName;                                      // Spalte 0: Mitarbeitername
                                calendarView.Rows[rowIndex].Cells[1].Value = resturlaub;                                    // Spalte 1: Resturlaub

                                rowIndex++;                                                                                 // Zur nächsten Zeile gehen
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

        private void LoadAbsenceTypes()
        {
            contextMenuStrip1.Items.Clear(); // Menüpunkte löschen
            calendarView.ContextMenuStrip = contextMenuStrip1;

            try
            {
                using (var connection = new SQLiteConnection(ApplicationContext.GetConnectionString()))
                {
                    connection.Open();
                    string query = "SELECT id, type_name, abbreviation, color FROM AbsenceTypes";

                    using (var command = new SQLiteCommand(query, connection))
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int typeId = reader.GetInt32(0);
                            string typeName = reader.GetString(1);
                            string abbreviation = reader.GetString(2);
                            string colorHex = reader.GetString(3);

                            // Farbe umwandeln, Standardfarbe falls ungültig
                            Color itemColor = Color.Black;
                            try { itemColor = ColorTranslator.FromHtml(colorHex); }
                            catch { }

                            // **Daten in den Cache speichern** 
                            AbsenceController.absenceCache[typeId] = (itemColor, abbreviation);

                            // Farbiges Icon für Menüpunkt erstellen
                            Bitmap colorIcon = new Bitmap(16, 16);
                            using (Graphics g = Graphics.FromImage(colorIcon))
                            {
                                g.Clear(itemColor);
                            }

                            // Menüpunkt für den Kontextmenü-Eintrag
                            ToolStripMenuItem menuItem = new ToolStripMenuItem(typeName)
                            {
                                Tag = typeId,
                                Image = colorIcon
                            };

                            // Event-Handler für Auswahl
                            menuItem.Click += (s, e) =>
                            {
                                int selectedTypeId = (int)((ToolStripMenuItem)s).Tag;
                                AbsenceController.ColorAbsence(calendarView, selectedTypeId);
                            };

                            contextMenuStrip1.Items.Add(menuItem);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Laden der Abwesenheitstypen: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Standard-Einträge hinzufügen
            AddStandardEntries();
        }

        private void AddStandardEntries()
        {
            // Trennlinie hinzufügen, falls das Menü bereits Einträge hat
            if (contextMenuStrip1.Items.Count > 0)
            {
                contextMenuStrip1.Items.Add(new ToolStripSeparator());
            }

            // Menüpunkt "Abwesenheit bearbeiten" hinzufügen
            ToolStripMenuItem editAbsenceItem = new ToolStripMenuItem("Abwesenheit bearbeiten")
            {
                Tag = "edit"
            };

            editAbsenceItem.Click += (s, e) =>
            {
                AbsenceController.EditAbsence();
            };


            // Menüpunkt "Abwesenheit löschen" hinzufügen
            ToolStripMenuItem deleteAbsenceItem = new ToolStripMenuItem("Abwesenheit löschen")
            {
                Tag = "delete"
            };

            deleteAbsenceItem.Click += (s, e) =>
            {
                AbsenceController.ClearAbsence(calendarView);
            };

            contextMenuStrip1.Items.Add(editAbsenceItem);
            contextMenuStrip1.Items.Add(deleteAbsenceItem);

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
            employeeManager.OnEmployeeManagerExit += LoadEmployees;
            employeeManager.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewManager viewManager = new ViewManager();
            viewManager.OnViewManagerExit += LoadViews;
            viewManager.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AbsenceManager absenceManager = new AbsenceManager();
            absenceManager.OnAbsenceManagerExit += LoadAbsenceTypes;
            absenceManager.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ScrollToToday();
        }

        private void viewCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetSelectedView();
            LoadEmployees();
        }

        private void adminKonsoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminManager adminManager = new AdminManager();
            adminManager.Show();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetupController.StartSetup();
        }

        private void hilfeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Öffnet die HTML-Datei im Standardbrowser
            Process.Start(new ProcessStartInfo("https://www.ap2024.de") { UseShellExecute = true });
        }

        private void anleitungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Öffnet die HTML-Datei im Standardbrowser
            Process.Start(new ProcessStartInfo("https://www.ap2024.de/directions") { UseShellExecute = true });
        }

        private void meineDatenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMyData showMyData = new ShowMyData();
            showMyData.ShowDialog();
        }

        private void einstellungenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserSettings userSettings = new UserSettings();
            userSettings.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            NewAbsence newAbsence = new NewAbsence();
            newAbsence.ShowDialog();
        }
    }
}
