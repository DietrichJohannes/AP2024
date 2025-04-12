// Purpose: Controller for handling absence data in the application. This includes loading, saving, deleting absence data, as well as coloring the calendar view based on the absence type.
// Creator: Johannes Dietrich
// Created: 05.02.2025
// Last modified: 09.03.2025


using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP2024
{
    public class AbsenceController
    {

        public static Dictionary<int, (Color, string)> absenceCache = new();

        public static void ColorAbsence(DataGridView calendarView, int absenceTypeId)
        {
            if (!absenceCache.TryGetValue(absenceTypeId, out var absenceData))
            {
                MessageBox.Show($"Abwesenheitstyp {absenceTypeId} nicht gefunden!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Color cellColor = absenceData.Item1;
            string abbreviation = absenceData.Item2;

            // Performance verbessern mit SuspendLayout
            calendarView.SuspendLayout();
            foreach (DataGridViewCell cell in calendarView.SelectedCells)
            {
                cell.Style.BackColor = cellColor;
                cell.Value = abbreviation;
                cell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            calendarView.ClearSelection();
            calendarView.ResumeLayout();
        }


        public static void LoadAbsence(DataGridView dgv)
        {
            // Connection String für die Datenbank
            string connectionString = ApplicationContext.GetConnectionString();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    // Datenbankverbindung öffnen
                    connection.Open();

                    // SQL-Abfrage, die alle Abwesenheiten mit Typinformationen enthält
                    string query = @"
                SELECT a.employee_id, a.start_date, a.end_date, t.abbreviation, t.color
                FROM Absences a
                JOIN AbsenceTypes t ON a.absence_type_id = t.id";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        // Liste zum Zwischenspeichern der Daten
                        var absences = new List<(int EmployeeId, DateTime Start, DateTime End, string Abbr, string Color)>();

                        while (reader.Read())
                        {
                            absences.Add((
                                Convert.ToInt32(reader["employee_id"]),
                                DateTime.Parse(reader["start_date"].ToString()),
                                DateTime.Parse(reader["end_date"].ToString()),
                                reader["abbreviation"].ToString(),
                                reader["color"].ToString()
                            ));
                        }

                        // Alle Zeilen im Kalender durchgehen (eine Zeile pro Mitarbeiter)
                        foreach (DataGridViewRow row in dgv.Rows)
                        {
                            if (row.HeaderCell.Value == null)
                                continue;

                            if (!int.TryParse(row.HeaderCell.Value.ToString(), out int employeeId))
                                continue;

                            // Alle Abwesenheiten für diesen Mitarbeiter
                            var employeeAbsences = absences.Where(a => a.EmployeeId == employeeId);

                            foreach (var absence in employeeAbsences)
                            {
                                // Jeden Tag im Zeitraum markieren
                                for (DateTime date = absence.Start; date <= absence.End; date = date.AddDays(1))
                                {
                                    foreach (DataGridViewColumn col in dgv.Columns)
                                    {
                                        if (DateTime.TryParseExact(col.HeaderText, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime colDate)
                                            && colDate.Date == date.Date)
                                        {
                                            var cell = row.Cells[col.Index];
                                            cell.Value = absence.Abbr;
                                            cell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                            cell.Style.BackColor = ColorTranslator.FromHtml(absence.Color);
                                            cell.Style.ForeColor = Color.Black;
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fehler beim Laden der Abwesenheiten: " + ex.Message, "AP2024");
                }
            }
        }

        public static void SaveAbsence()
        {

        }

        public static void EditAbsence()
        {

        }

        public static void ClearAbsence(DataGridView calendarView)
        {
            if (calendarView.SelectedCells.Count == 0)
            {
                MessageBox.Show("Bitte wählen Sie eine Zelle aus, um die Abwesenheit zu löschen.", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (DataGridViewCell cell in calendarView.SelectedCells)
            {
                if (cell.Style.BackColor != Color.White) // Falls die Zelle eingefärbt ist
                {
                    cell.Style.BackColor = Color.White; // Farbe zurücksetzen
                    cell.Value = string.Empty; // Inhalt löschen (falls notwendig)
                }
            }
        }

    }
}
