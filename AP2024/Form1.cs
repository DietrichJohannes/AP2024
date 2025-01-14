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
    }
}
