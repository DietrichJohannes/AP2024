// Purpose: Controller for handling absence data in the application. This includes loading, saving, deleting absence data, as well as coloring the calendar view based on the absence type.
// Creator: Johannes Dietrich
// Created: 05.02.2025
// Last modified: 09.03.2025


using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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


        public static List<(int EmployeeId, DateTime Start, DateTime End, string Abbr, Color Color)> LoadAbsence()
        {
            var absences = new List<(int, DateTime, DateTime, string, Color)>();

            try
            {
                using (var connection = new SQLiteConnection(ApplicationContext.GetConnectionString()))
                {
                    connection.Open();

                    string query = @"
SELECT a.employee_id, a.start_date, a.end_date, t.abbreviation, t.color
FROM Absences a
JOIN AbsenceTypes t ON a.absence_type_id = t.id
ORDER BY a.employee_id, a.start_date";

                    using (var command = new SQLiteCommand(query, connection))
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int employeeId = Convert.ToInt32(reader["employee_id"]);
                            DateTime start = DateTime.Parse(reader["start_date"].ToString());
                            DateTime end = DateTime.Parse(reader["end_date"].ToString());
                            string abbr = reader["abbreviation"]?.ToString() ?? "";
                            string colorHex = reader["color"]?.ToString() ?? "#FFFFFF";

                            Color color;
                            try { color = ColorTranslator.FromHtml(colorHex); }
                            catch { color = Color.White; }

                            absences.Add((employeeId, start, end, abbr, color));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Laden der Abwesenheiten: " + ex.Message, "AP2024");
            }

            return absences;
        }





public static void ApplyAbsences(DataGridView dgv)
    {
        if (dgv == null) return;

        var absences = LoadAbsence();
        if (absences == null || absences.Count == 0) return;

        SuspendRedraw(dgv);

        dgv.SuspendLayout();

        // 1. Mapping: Datum → Spalte
        Dictionary<DateTime, int> columnIndexByDate = new();
        foreach (DataGridViewColumn col in dgv.Columns)
        {
            if (DateTime.TryParseExact(col.HeaderText, "dd.MM.yyyy", null,
                System.Globalization.DateTimeStyles.None, out DateTime date))
            {
                columnIndexByDate[date.Date] = col.Index;
            }
        }

        // 2. Mapping: Mitarbeiter-ID → DataGridViewRow
        Dictionary<int, DataGridViewRow> employeeRows = new();
        foreach (DataGridViewRow row in dgv.Rows)
        {
            if (row.HeaderCell.Value != null && int.TryParse(row.HeaderCell.Value.ToString(), out int id))
            {
                employeeRows[id] = row;
            }
        }

        // 3. Anwenden
        foreach (var absence in absences)
        {
            if (!employeeRows.TryGetValue(absence.EmployeeId, out DataGridViewRow row))
                continue;

            for (DateTime day = absence.Start.Date; day <= absence.End.Date; day = day.AddDays(1))
            {
                if (columnIndexByDate.TryGetValue(day, out int colIndex))
                {
                    var cell = row.Cells[colIndex];

                    if (cell.Value?.ToString() != absence.Abbr)
                        cell.Value = absence.Abbr;

                    if (cell.Style.BackColor != absence.Color)
                    {
                        cell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        cell.Style.BackColor = absence.Color;
                        cell.Style.ForeColor = Color.Black;
                    }
                }
            }
        }

        dgv.ResumeLayout();
        ResumeRedraw(dgv);
        dgv.Invalidate(); // Neu zeichnen
    }


        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int msg, bool wParam, int lParam);

        private const int WM_SETREDRAW = 11;

        private static void SuspendRedraw(Control control)
        {
            SendMessage(control.Handle, WM_SETREDRAW, false, 0);
        }

        private static void ResumeRedraw(Control control)
        {
            SendMessage(control.Handle, WM_SETREDRAW, true, 0);
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
