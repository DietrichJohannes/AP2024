using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace AP2024
{
    internal class DatabaseController
    {
        public static void InitializeDatabase()
        {
            string folderPath = "data";
            string databasePath = Path.Combine(folderPath, "AP2024.db");

            // Überprüfen, ob der Ordner 'data' existiert, falls nicht, wird er erstellt.
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            // Den Ordner als versteckt markieren
            File.SetAttributes(folderPath, FileAttributes.Hidden);

            // Verbindung zur Datenbank herstellen
            using (var connection = new SQLiteConnection(ApplicationContext.GetConnectionString())) // Verwende SQLiteConnection aus System.Data.SQLite
            {
                connection.Open();

                // Tabelle für Abwesenheitsarten
                string createAbsenceTypesTableQuery = @"CREATE TABLE IF NOT EXISTS AbsenceTypes (
                                                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                                                        type_name TEXT NOT NULL,
                                                        abbreviation TEXT NOT NULL,
                                                        color TEXT NOT NULL,
                                                        requires_comment INTEGER NOT NULL DEFAULT 0
                                                        );";

                ExecuteNonQuery(connection, createAbsenceTypesTableQuery);

                // Tabelle für Mitarbeiter
                string createEmployeesTableQuery = @"CREATE TABLE IF NOT EXISTS Employees (
                                                       id INTEGER PRIMARY KEY AUTOINCREMENT,
                                                       first_name TEXT NOT NULL,
                                                       last_name TEXT NOT NULL,
                                                       windows_username TEXT NOT NULL,
                                                       view INTEGER NOT NULL,
                                                       leave_entitlement INTEGER NOT NULL,
                                                       remaining_leave INTEGER NOT NULL,
                                                       sick_days INTEGER DEFAULT 0
                                                       );";


                ExecuteNonQuery(connection, createEmployeesTableQuery);

                // Tabelle für Abwesenheiten
                string createAbsencesTableQuery = @"CREATE TABLE IF NOT EXISTS Absences (
                                                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                                                        employee_id INTEGER NOT NULL,
                                                        absence_type_id INTEGER NOT NULL,
                                                        start_date TEXT NOT NULL,
                                                        end_date TEXT NOT NULL,
                                                        comment TEXT NOT NULL,
                                                        created_by TEXT NOT NULL,
                                                        FOREIGN KEY (employee_id) REFERENCES Employees(id),
                                                        FOREIGN KEY (absence_type_id) REFERENCES AbsenceTypes(id)
                                                        );";

                ExecuteNonQuery(connection, createAbsencesTableQuery);

                string createViewTableQuery = @"CREATE TABLE IF NOT EXISTS Views (
                                                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                                                        view_name TEXT NOT NULL,
                                                        parent_view_id INTEGER
                                                        );";

                ExecuteNonQuery(connection, createViewTableQuery);

                string createSuperViewTableQuery = @"CREATE TABLE IF NOT EXISTS SuperViews (
                                                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                                                        super_view_name TEXT NOT NULL
                                                        );";

                ExecuteNonQuery(connection, createSuperViewTableQuery);

                // Tabelle für Feiertage
                string createHolidayTableQuery = @"CREATE TABLE IF NOT EXISTS PublicHolidays (
                                                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                                                        holiday_name TEXT NOT NULL,
                                                        holiday_date TEXT NOT NULL,
                                                        is_recurring INTEGER NOT NULL DEFAULT 0
                                                        );";

                ExecuteNonQuery(connection, createHolidayTableQuery);

                // Tabelle für Admins
                string createAdministratorTableQuery = @"CREATE TABLE IF NOT EXISTS Administrators (
                                                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                                                        windows_username TEXT NOT NULL
                                                        );";

                ExecuteNonQuery(connection, createAdministratorTableQuery);

                // Tabelle für Einstellungen
                string createSettingsTableQuery = @"CREATE TABLE IF NOT EXISTS Settings (
                                                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                                                        can_add_themselves INTEGER NOT NULL DEFAULT 0,
                                                        can_edit_themselves INTEGER NOT NULL DEFAULT 0,
                                                        department TEXT NOT NULL DEFAULT '[Abteilung]',
                                                        time_admin TEXT NOT NULL DEFAULT '[ZeitAdmin]'
                                                        );";

                ExecuteNonQuery(connection, createSettingsTableQuery);
            }

            Console.WriteLine("Datenbank-Initialisierung abgeschlossen.");
        }

        // Hilfsmethode zum Ausführen von Nicht-Abfrage-SQL-Befehlen
        private static void ExecuteNonQuery(SQLiteConnection connection, string query)
        {
            using (var command = new SQLiteCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }
        }
    }

}
