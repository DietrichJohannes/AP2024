using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP2024
{
    public static class LeaveHandler
    {
        public static void ResetSickdays()
        {
            try
            {
                using (var connection = new SQLiteConnection(ApplicationContext.GetConnectionString()))
                {
                    connection.Open();
                    string query = "UPDATE Employees SET sick_days = 0";
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = query;
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log them)
                Console.WriteLine($"Error resetting sick days: {ex.Message}");
            }
        }

        public static void DistributeVacationdays()
        {
            try
            {
                using (var connection = new SQLiteConnection(ApplicationContext.GetConnectionString()))
                {
                    connection.Open();
                    string query = "UPDATE Employees SET remaining_leave = leave_entitlement";
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = query;
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log them)
                Console.WriteLine($"Error distributing vacation days: {ex.Message}");
            }
        }

    }
}
