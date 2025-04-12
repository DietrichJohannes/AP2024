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
        int SelectedAbsenceTypeId = 0;
        int employeeID = ApplicationContext.USER_ID;
        DateTime StartDate;
        DateTime EndDate;
        string Comment;
        string CreatedBy;

        public NewAbsence()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            LoadAbsenceTypes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreatedBy = "[" + ApplicationContext.GetCurrentWindowsUser() + "] am " +ApplicationContext.GetCurrentDate() + " um " + ApplicationContext.GetCurrentTime();
            SelectedAbsenceTypeId = (int)AbsenceTypesCB.SelectedValue;
            StartDate = StartDateDTP.Value;
            EndDate = EndDateDTP.Value;
            Comment = CommentRTB.Text;
            SaveAbsence();
        }

        private void LoadAbsenceTypes()
        {
            string connectionString = ApplicationContext.GetConnectionString();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT id, type_name FROM AbsenceTypes";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            AbsenceTypesCB.Items.Clear();

                            Dictionary<int, string> Views = new Dictionary<int, string>();

                            while (reader.Read())
                            {
                                int id = Convert.ToInt32(reader["id"]);
                                string name = reader["type_name"].ToString();

                                // Füge den Namen zur ComboBox hinzu und speichere die ID
                                Views.Add(id, name);
                            }

                            // Setze DisplayMember und ValueMember
                            AbsenceTypesCB.DataSource = new BindingSource(Views, null);
                            AbsenceTypesCB.DisplayMember = "Value"; // Zeige den Namen an
                            AbsenceTypesCB.ValueMember = "Key";     // Speichere die ID
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "AP2024");
                }
            }
        }

        private void SaveAbsence()
        {
            // Connection String für die Datenbank
            string connectionString = ApplicationContext.GetConnectionString();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    // Datenbankverbindung öffnen
                    connection.Open();

                    // Werte übergeben
                    string query = "INSERT INTO Absences (employee_id, absence_type_id, start_date, end_date, comment, created_by) VALUES (@employee_id, @absence_id, @start_date, @end_date, @comment, @created_by)";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@employee_id", employeeID);
                        command.Parameters.AddWithValue("@absence_id", SelectedAbsenceTypeId);
                        command.Parameters.AddWithValue("@start_date", StartDate);
                        command.Parameters.AddWithValue("@end_date", EndDate);
                        command.Parameters.AddWithValue("@comment", Comment);
                        command.Parameters.AddWithValue("@created_by", CreatedBy);

                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            NotificationController.Saved();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Abwesenheit konnte nicht gespeichert werden.", "AP2024");
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
