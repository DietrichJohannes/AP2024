using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

public class CalendarController
{

    public const int monthsToShow = 14;                                         // Anzuzeigende Monate
    public const int monthBackwards = 2;                                        // Monate in die Vergangenheit
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
    }

    public void CreateCalendarWeek(DataGridView dgv)                            // Methode: Kalenderwochenansicht erstellen
    {
        dgv.Rows.Clear();                                                       // DataGridView zurücksetzen
        dgv.Columns.Clear();

        dgv.ColumnHeadersVisible = false;                                       // Spaltenüberschriften ausblenden

        
        int totalDays = 0;                                                      // Anzahl der Wochen berechnen 
        for (int i = 0; i < monthsToShow; i++)
        {
            DateTime month = startDate.AddMonths(i);
            totalDays += DateTime.DaysInMonth(month.Year, month.Month);         // Tage des Monats hinzufügen
        }
        int weeksToShow = (int)Math.Ceiling(totalDays / 7.0);                   // In Wochen umwandeln (aufgerundet)

        for (int i = 0; i < weeksToShow; i++)                                   // Spalten für die Kalenderwochen hinzufügen
        {
            dgv.Columns.Add($"Column{i}", "");                                  // Leere Spaltenüberschrift
            dgv.Columns[i].Width = 245;                                         // Spaltenbreite setzen
        }

        dgv.Rows.Add();                                                         // Zeile einfügen

        for (int i = 0; i < weeksToShow; i++)                                   // Kalenderwochen in die Spalten einfügen
        {
            DateTime weekStart = startDate.AddDays(i * 7);                      // Startdatum für die Woche berechnen
            CultureInfo culture = CultureInfo.CurrentCulture;                   // Kulturinfo (z. B. für Deutschland)
            int kalenderwoche = culture.Calendar.GetWeekOfYear(                 // Kalenderwoche berechnen
                weekStart,
                CalendarWeekRule.FirstFourDayWeek,                              // Regel für die erste Kalenderwoche
                DayOfWeek.Monday                                                // Montag als erster Wochentag
            );

            string weekLabel = $"KW {kalenderwoche}";                           // Kalenderwoche als Text
            dgv.Rows[0].Cells[i].Value = weekLabel;                             // Kalenderwoche in die Zelle schreiben
        }
    }

    public void CreateCalendarDay(DataGridView dgv)                             // Methode: Tagesansicht erstellen
    {

        dgv.Rows.Clear();                                                       //DataGridView zurücksetzen
        dgv.Columns.Clear();


        dgv.ColumnHeadersVisible = false;                                       // Spaltenüberschriften ausblenden
        dgv.ColumnHeadersVisible = false;                                       // Zeilenüberschriften ausblendn



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
    }


}
