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
    public partial class AddFlextime : Form
    {

        decimal flextime = 0.00m;
        public event Action OnFlextimeSaved;

        public AddFlextime()
        {
            InitializeComponent();
            LoadFlextime();
        }

        private void LoadFlextime()
        {
            string connectionString = ApplicationContext.GetConnectionString();
            int employeeID = ApplicationContext.USER_ID;

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT flextime FROM Employees WHERE id = @ID";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", employeeID);

                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            flextime = Convert.ToDecimal(result);
                            NUDFlextime.Value = flextime;
                        }
                        else
                        {
                            flextime = 0.00m;
                            NUDFlextime.Value = 0.00m;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fehler beim Laden der Gleitzeit: " + ex.Message, "AP2024");
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            getNUDValue();
            flextime = flextime + 1m;
            updateNumericUpDown();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            getNUDValue();
            flextime = flextime - 1m;
            updateNumericUpDown();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            getNUDValue();
            flextime = flextime + 0.1m;
            updateNumericUpDown();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            getNUDValue();
            flextime = flextime - 0.1m;
            updateNumericUpDown();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            getNUDValue();
            flextime = flextime + 0.01m;
            updateNumericUpDown();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            getNUDValue();
            flextime = flextime - 0.01m;
            updateNumericUpDown();
        }

        private void updateNumericUpDown()
        {
            NUDFlextime.Value = (decimal)flextime;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            flextime = NUDFlextime.Value;
            AddFlextimeToDatabase();
        }

        private void getNUDValue()
        {
            flextime = NUDFlextime.Value;
        }

        private void AddFlextimeToDatabase()
        {
            string connectionString = ApplicationContext.GetConnectionString();
            int EmployeeID = ApplicationContext.USER_ID;

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "UPDATE Employees SET flextime = @flextime WHERE id = @ID";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", EmployeeID);
                        command.Parameters.AddWithValue("@flextime", flextime); // Achte darauf, dass 'flextime' korrekt deklariert ist

                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            NotificationController.Saved();
                            OnFlextimeSaved?.Invoke();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Gleitzeit konnte nicht gespeichert werden.", "AP2024");
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
