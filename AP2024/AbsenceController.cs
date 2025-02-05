// Purpose: Controller for handling absence data in the application. This includes loading and saving absence data, as well as coloring the calendar view based on the absence type.
// Creator: Johannes Dietrich
// Created: 05.02.2025
// Last modified: 05.02.2025


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
        public static void ColorAbsence(DataGridView calendarView, int absenceTypeId)
        {
            Color cellColor = Color.White; // Standardfarbe, falls nichts gefunden wird
            string abbreviation = "";

            try
            {
                using (var connection = new SQLiteConnection(ApplicationContext.GetConnectionString()))
                {
                    connection.Open();
                    string query = "SELECT color, abbreviation FROM AbsenceTypes WHERE id = @id";

                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", absenceTypeId);

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read()) // Prüfen, ob Daten vorhanden sind
                            {
                                try
                                {
                                    cellColor = ColorTranslator.FromHtml(reader["color"].ToString());
                                    abbreviation = reader["abbreviation"].ToString();
                                }
                                catch { /* Falls ungültige Farbe, bleibt es Weiß */ }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Laden der Farbe: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Markierte Zellen mit der ermittelten Farbe und Abkürzung einfärben
            foreach (DataGridViewCell cell in calendarView.SelectedCells)
            {
                cell.Style.BackColor = cellColor;
                cell.Value = abbreviation;
                cell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                calendarView.ClearSelection();
            }
        }


        public static void LoadAbsence()
        {

        }

        public static void SaveAbsence()
        {

        }
    }
}
