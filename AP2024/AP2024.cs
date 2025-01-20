namespace AP2024
{
    public partial class AP2024 : Form
    {
        private CalendarController calendarController;

        public AP2024()
        {
            InitializeComponent();
            initCalendar();                                                                 // Initialisiere den Kalender
            DatabaseController.InitializeDatabase();                                        // Initialisiere (Erstelle) die Datenbank
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void initCalendar()
        {

            calendarController = new CalendarController();
            calendarController.CreateCalendarMonth(monthView);

            // Kalenderwochenansicht erstellen
            calendarController.CreateCalendarWeek(cwView);

            // Tagesansicht erstellen
            calendarController.CreateCalendarDay(calendarView);
        }

        private void calendarView_Scroll(object sender, ScrollEventArgs e)
        {
            SynchronizeScroll();
        }

        private void SynchronizeScroll()
        {
            if (cwView.FirstDisplayedScrollingRowIndex != calendarView.FirstDisplayedScrollingRowIndex)
                cwView.FirstDisplayedScrollingRowIndex = calendarView.FirstDisplayedScrollingRowIndex;

            if (monthView.FirstDisplayedScrollingRowIndex != calendarView.FirstDisplayedScrollingRowIndex)
                monthView.FirstDisplayedScrollingRowIndex = calendarView.FirstDisplayedScrollingRowIndex;
        }

        private void info‹berDenEntwicklerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DevInfo devInfo = new DevInfo();
            devInfo.ShowDialog();
        }

        private void mitarbeiterverwaltungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeManager employeeManager = new EmployeeManager();
            employeeManager.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewManager viewManager = new ViewManager();
            viewManager.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
