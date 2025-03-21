using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

public static class LoadHolidayAPI
{
    public static async Task HighlightHolidaysAsync(DataGridView dgv)
    {
        if (dgv.Columns.Count > 0 && dgv.Rows.Count > 0)
        {
            // Feiertage abrufen
            List<DateTime> holidays = await GetHolidaysAsync();

            // Feiertage in einer MessageBox ausgeben
            string holidayList = string.Join("\n", holidays.Select(h => h.ToString("dd.MM.yyyy")));

            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                if (DateTime.TryParseExact(dgv.Columns[i].HeaderText, "dd.MM.yyyy",
                                           CultureInfo.InvariantCulture,
                                           DateTimeStyles.None, out DateTime columnDate))
                {
                    if (holidays.Contains(columnDate))
                    {
                        for (int j = 1; j < dgv.Rows.Count; j++)
                        {
                            dgv.Rows[j].Cells[i].Style.BackColor = Color.Gray;
                        }
                    }
                }
            }
        }
    }

    private static async Task<List<DateTime>> GetHolidaysAsync()
    {
        using (HttpClient client = new HttpClient())
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("https://block-quiz.de/api/holidays.json");
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();

                    // JSON-Daten in ein Objekt deserialisieren
                    var holidayData = JsonSerializer.Deserialize<HolidayRoot>(json, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true // Case-Insensitive für JSON-Keys aktivieren!
                    });

                    if (holidayData?.Feiertage == null)
                    {
                        MessageBox.Show("Feiertagsdaten sind leer oder ungültig.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return new List<DateTime>();
                    }

                    // Feiertage in DateTime-Format umwandeln
                    List<DateTime> holidays = holidayData.Feiertage
                        .Select(h => DateTime.ParseExact(h.Datum, "dd.MM.yyyy", CultureInfo.InvariantCulture))
                        .ToList();

                    return holidays;
                }
                else
                {
                    MessageBox.Show("Fehler beim Abrufen der Feiertage. Statuscode: " + response.StatusCode, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return new List<DateTime>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler: " + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<DateTime>();
            }
        }
    }
}

// **Angepasste Klassen mit JSON-Attributen**
public class HolidayRoot
{
    [JsonPropertyName("feiertage")] // Hier anpassen, damit es mit dem JSON-Namen übereinstimmt
    public List<Holiday> Feiertage { get; set; }
}

public class Holiday
{
    [JsonPropertyName("datum")] // Hier anpassen für korrektes Mapping
    public string Datum { get; set; }

    [JsonPropertyName("name")] // Falls du den Namen auch brauchst
    public string Name { get; set; }
}
