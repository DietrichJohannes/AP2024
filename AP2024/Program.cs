namespace AP2024
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ApplicationContext.GetUserIDByWindowsUser();
            ApplicationContext.GetTheme();

            // SplashScreen anzeigen
            SplashScreen splash = new SplashScreen();
            splash.Show();
            splash.Refresh();

            // 8 Sekunden warten
            Thread.Sleep(2000);

            // SplashScreen schlieﬂen und Hauptform starten
            splash.Close();
            Application.Run(new AP2024());
        }
    }
}