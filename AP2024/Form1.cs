namespace AP2024
{
    public partial class Form1 : Form
    {
        private CalendarController calendarController;

        public Form1()
        {
            InitializeComponent();
            initCalendar();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void initCalendar()
        {
            // Monatsansicht erstellen
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
    }
}
