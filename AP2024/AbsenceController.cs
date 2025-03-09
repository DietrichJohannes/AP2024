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


        public static void LoadAbsence()
        {

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
