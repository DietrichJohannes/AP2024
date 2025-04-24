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
    public partial class EditVacationAndSickDays : Form
    {
        public event Action OnEditFormExit;

        int _EmployeeID;
        int _mode;

        public EditVacationAndSickDays(int EmployeeID, int mode)
        {
            InitializeComponent();
            _EmployeeID = EmployeeID;
            _mode = mode;
            GetWindowMode();
            GetEmployeeName();
            LoadAbsenceDays();
        }

        private void GetEmployeeName()
        {
            try
            {
                using (var connection = new SQLiteConnection(ApplicationContext.GetConnectionString()))
                {
                    connection.Open();
                    string query = "SELECT first_name, last_name FROM Employees WHERE id = @id";
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", _EmployeeID);
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string vorname = reader["first_name"]?.ToString() ?? "Unbekannt";
                                string nachname = reader["last_name"]?.ToString() ?? "Unbekannt";
                                string fullName = $"{vorname} {nachname}";
                                employee_name.Text = fullName;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Abrufen des Mitarbeiters: " + ex.Message);
            }
        }

        private void GetWindowMode()
        {
            if (_mode == 0)
            {
                this.Text = "Krankheitstage bearbeiten";
                absence_name.Text = "Krankheitstage";
            }
            else if (_mode == 1)
            {
                this.Text = "Urlaubstage bearbeiten";
                absence_name.Text = "Urlaubstage";
            }
        }

        private void LoadAbsenceDays()
        {
            try
            {
                using (var connection = new SQLiteConnection(ApplicationContext.GetConnectionString()))
                {
                    connection.Open();
                    string query = "SELECT sick_days, remaining_leave FROM Employees WHERE id = @id";
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", _EmployeeID);
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                if (_mode == 0)
                                {
                                    int sickDays = Convert.ToInt32(reader["sick_days"]);
                                    NUDAbsence_days.Value = sickDays;
                                }
                                else if (_mode == 1)
                                {
                                    int vacationDays = Convert.ToInt32(reader["remaining_leave"]);
                                    NUDAbsence_days.Value = vacationDays;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Laden der Abwesenheitstage: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveAbsenceDays();
        }

        private void SaveAbsenceDays()
        {
            try
            {
                using (var connection = new SQLiteConnection(ApplicationContext.GetConnectionString()))
                {
                    connection.Open();
                    string column = _mode == 0 ? "sick_days" : "remaining_leave";
                    string query = $"UPDATE Employees SET {column} = @value WHERE id = @id";

                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@value", (int)NUDAbsence_days.Value);
                        command.Parameters.AddWithValue("@id", _EmployeeID);
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected == 0)
                        {
                            MessageBox.Show("Kein Datensatz wurde aktualisiert.");
                        }
                        else
                        {
                            NotificationController.Updated();
                            OnEditFormExit.Invoke();
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Speichern der Abwesenheitstage: " + ex.Message);
            }
        }
    }
}
