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

            // SplashScreen anzeigen
            SplashScreen splash = new SplashScreen();
            splash.Show();
            splash.Refresh();

            // 8 Sekunden warten
            Thread.Sleep(8000);

            // SplashScreen schlieﬂen und Hauptform starten
            splash.Close();
            Application.Run(new AP2024());
        }
    }
}