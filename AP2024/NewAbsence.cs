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
    public partial class NewAbsence : Form
    {

        private Color selectedColor = Color.White;
        string hexColor = "#FFFFFF";
        public event Action OnAbsenceTypeSaved;

        public NewAbsence()
        {
            InitializeComponent();
        }
        private void btnChooseColor_Click(object sender, EventArgs e)
        {

            // Öffne die Farbpalette
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Color selectedColor = colorDialog.Color; // Die gewählte Farbe als Color-Objekt speichern
                hexColor = $"#{selectedColor.R:X2}{selectedColor.G:X2}{selectedColor.B:X2}"; // Die Farbe als Hex-String speichern

                btnChooseColor.BackColor = selectedColor; // Zeige die gewählte Farbe im Button an
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {   
            SaveAbsenceTypes();
            NotificationController.Saved();
        }

        private void SaveAbsenceTypes() 
        {
            string name = nameTextBox.Text;
            string abbreviation = abbreviationTextBox.Text;
            int requiresComment = 0;

            if (requestCommentCheckBox.Checked) {
                requiresComment = 1;
            }

            // Connection String für die Datenbank
            string connectionString = ApplicationContext.GetConnectionString();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    // Datenbankverbindung öffnen
                    connection.Open();

                    // Werte übergeben
                    string query = "INSERT INTO AbsenceTypes (type_name, abbreviation, color, requires_comment) VALUES (@type_name, @abbreviation, @color, @requires_comment)";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@type_name", name);
                        command.Parameters.AddWithValue("@abbreviation", abbreviation);
                        command.Parameters.AddWithValue("@color", hexColor);
                        command.Parameters.AddWithValue("@requires_comment", requiresComment);

                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            NotificationController.Saved();
                            OnAbsenceTypeSaved?.Invoke();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Daten konnte nicht gespeichert werden.", "AP2024");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fehler: " + ex.Message);
                }
            }
        }
    }


 }
 
