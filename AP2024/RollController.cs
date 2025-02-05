using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP2024
{
    public static class RollController
    {
        public static void EnableAdminControls(ToolStripMenuItem AdminMenuItem)
        {
            try
            {
                using (var connection = new SQLiteConnection(ApplicationContext.GetConnectionString()))
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM Administrators WHERE windows_username = @user";

                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@user", ApplicationContext.GetCurrentWindowsUser());

                        int count = Convert.ToInt32(command.ExecuteScalar());

                        if (count > 0)
                        {
                            AdminMenuItem.Visible = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Laden der Administratorrechte: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
