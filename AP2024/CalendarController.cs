// Purpose: Controller for the calendar view. It creates the calendar view for the month, week and day view.
// Creator: Johannes Dietrich 2025
// Created: 15.01.2025
// Last modified: 15.01.2025

// Zeile 20 - 49 : Erstellen der Monatsansicht
// Zeile 54 - 92 : Erstellen der Kalenderwochenansicht
// Zeile 86 - 157 : Erstellen der Tagesansicht


using System;
using System.Drawing;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;


public class CalendarController
{

    public const int monthsToShow = 14;                                         // Anzuzeigende Monate
    public const int monthBackwards = 2;                                        // Monate in die Vergangenheit
    public int weeksToShow => (int)Math.Ceiling(monthsToShow * 4.33);           // Abgeleitete Anzahl der Wochen

    public DateTime startDate = DateTime.Now.AddMonths(-monthBackwards);        // Startdatum des Kalenders

    public void CreateCalendarMonth(DataGridView dgv)                           // Methode: Monatsansicht erstellen
    {
       
        dgv.Rows.Clear();                                                       // DataGridView zurücksetzen
        dgv.Columns.Clear();



        dgv.ColumnHeadersVisible = false;                                       // Spaltenüberschriften ausblenden

        
        for (int i = 0; i < monthsToShow; i++)                                  // Spalten für die Monate hinzufügen
        {
            dgv.Columns.Add($"Column{i}", "");                                  // Leere Spaltenüberschrift
            dgv.Columns[i].Width = 1000;                                        // Spaltenbreite setzen
        }

        dgv.Rows.Add();                                                         // Zeile einfügen

        for (int i = 0; i < monthsToShow; i++)                                  // Monate in die Spalten einfügen
        {
            DateTime month = startDate.AddMonths(i);                            // Anzuzeigender Monat berechnen
            string monthYear = month.ToString("MMMM yyyy");                     // Monat und Jahr als Text

           
            dgv.Rows[0].Cells[i].Value = monthYear;                             // Monat und Jahr in die Zelle schreiben

        }
        dgv.ClearSelection();                                                   // Auswahl aufheben
    }

    public void CreateCalendarWeek(DataGridView dgv)                            // Methode: Kalenderwochenansicht erstellen
    {
        dgv.Rows.Clear();                                                       // DataGridView zurücksetzen
        dgv.Columns.Clear();

        dgv.ColumnHeadersVisible = false;                                       // Spaltenüberschriften ausblenden

        for (int i = 0; i < weeksToShow; i++)                                   // Spalten für die Kalenderwochen hinzufügen
        {
            dgv.Columns.Add($"Column{i}", "");                                  // Leere Spaltenüberschrift
            dgv.Columns[i].Width = 245;                                         // Spaltenbreite setzen
        }

        dgv.Rows.Add();                                                         // Zeile einfügen

        for (int i = 0; i < weeksToShow; i++)                                   // Kalenderwochen in die Spalten einfügen
        {
            DateTime weekStart = startDate.AddDays(i * 7);                      // Startdatum um Wochen erhöhen
            int calendarWeek = System.Globalization.CultureInfo
                .CurrentCulture.Calendar.GetWeekOfYear(weekStart,
                    System.Globalization.CalendarWeekRule.FirstFourDayWeek,
                    DayOfWeek.Monday);                                          // Kalenderwoche berechnen

            dgv.Rows[0].Cells[i].Value = $"KW{calendarWeek}";                   // KW in die Zelle schreiben
        }

        dgv.ClearSelection();                                                   // Auswahl aufheben

    }

    public void CreateCalendarDay(DataGridView dgv)                             // Methode: Tagesansicht erstellen
    {

        dgv.Rows.Clear();                                                       //DataGridView zurücksetzen
        dgv.Columns.Clear();


        dgv.ColumnHeadersVisible = false;                                       // Spaltenüberschriften ausblenden



        int daysToShow = 0;                                                     // Anzahl der anzuzeigenden Tage berechnen
        for (int i = 0; i < monthsToShow; i++)
        {
            DateTime month = startDate.AddMonths(i);                            
            daysToShow += DateTime.DaysInMonth(month.Year, month.Month);
        }


        for (int i = 0; i < daysToShow + 2; i++)                                // Spalten für die Tage hinzufügen + 2 für den Mitarbeiternamen und RestUrlaub
        {
            dgv.Columns.Add($"Column{i}", "");                                  // Leere Spaltenüberschrift


            if (i == 0)
            {
                dgv.Columns[i].Width = 300;                                     // Spaltenbreite für den Namen: 300 px
            }
            else
            {
                dgv.Columns[i].Width = 35;                                     // Spaltenbreite für Tage:      35 px
            }
        }

            dgv.Rows.Add();                                                    // Zeile einfügen


        dgv.Rows[0].Cells[1].Value = "RU";                                     // "RU" -> Resturlaub in die Zelle schreiben
            dgv.Rows[0].Cells[0].Value = "Mitarbeiter";                        // "Mitarbeiter" in die Zelle schreiben
            dgv.Columns[0].Frozen = true;                                      // Erste Spalte fixieren
            dgv.Columns[1].Frozen = true;                                      // Zweite Spalte fixieren

        // Tage in die erste Zeile einfügen
        DateTime currentDay = startDate;
        for (int i = 0; i < daysToShow; i++)
        {
            string dayText = currentDay.ToString("ddd") + "\n" + currentDay.ToString("dd"); // Mehrzeiliger Text

            // Text in die Zellen der ersten Zeile einfügen
            dgv.Rows[0].Cells[i + 2].Value = dayText;

            // Optional: Zellenformatierung
            dgv.Rows[0].Cells[i + 2].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Rows[0].Cells[i + 2].Style.WrapMode = DataGridViewTriState.True; // Textumbruch aktivieren


            // Nächster Tag
            currentDay = currentDay.AddDays(1);
        }

        
        dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;           // Automatische Zeilenhöhe anpassen
        dgv.ClearSelection();                                                   // Auswahl aufheben
    }

    public void CreateSilentCalendar(DataGridView dgv)                          // Methode: Stiller Kalender
    {

        int daysToShow = 0;                                                     // Anzahl der anzuzeigenden Tage berechnen
        for (int i = 0; i < monthsToShow; i++)
        {
            DateTime month = startDate.AddMonths(i);
            daysToShow += DateTime.DaysInMonth(month.Year, month.Month);
        }

        DateTime currentDay = startDate;
        for (int i = 0; i < daysToShow; i++)
        {
            string dayText = currentDay.ToString("dd.MM.yyyy");                 // Mehrzeiliger Text

            // Text in die Zellen der ersten Zeile einfügen
            dgv.Columns[i + 2].HeaderText = dayText;

            // Nächster Tag
            currentDay = currentDay.AddDays(1);
        }

    }

    public void HighlightWeekends(DataGridView dgv)
    {
        if (dgv.Columns.Count > 0 && dgv.Rows.Count > 0) // Prüfen, ob Spalten und Zeilen vorhanden sind
        {
            for (int i = 0; i < dgv.Columns.Count; i++) // Durch alle Spalten iterieren
            {
                if (DateTime.TryParseExact(dgv.Columns[i].HeaderText, "dd.MM.yyyy",
                                           System.Globalization.CultureInfo.InvariantCulture,
                                           System.Globalization.DateTimeStyles.None, out DateTime columnDate))
                {
                    if (columnDate.DayOfWeek == DayOfWeek.Saturday || columnDate.DayOfWeek == DayOfWeek.Sunday)
                    {
                        // Alle Zellen unter der ersten Zeile einfärben
                        for (int j = 1; j < dgv.Rows.Count; j++)
                        {
                            dgv.Rows[j].Cells[i].Style.BackColor = Color.Gray;
                            dgv.Rows[j].Cells[i].Value = "";
                        }
                    }
                }
            }
        }
    }


    public async Task HighlightHolidays(DataGridView dgv)
    {
        LoadHolidayAPI.HighlightHolidaysAsync(dgv);
    }

public void HighlightToday(DataGridView dgv)                                  // Methode: Zum heutigen Tag scrollen
    {
        string Today = DateTime.Now.ToString("dd.MM.yyyy");               // Heutiges Datum als Text
        int i = 0;

        if (dgv.Columns.Count > 0) // Prüfen, ob Spalten vorhanden sind
        {
            do
            {
                if (dgv.Columns[i].HeaderText == Today)
                {
                    dgv.Rows[0].Cells[i].Style.BackColor = Color.Yellow;
                    dgv.FirstDisplayedScrollingColumnIndex = i - 18;
                }
                i++;
            }
            while (i < dgv.Columns.Count);
        }
    }
}
