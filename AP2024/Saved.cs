using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP2024
{
    public partial class Saved : Form
    {
        public Saved()
        {
            InitializeComponent();


            // Timer erstellen
            System.Windows.Forms.Timer closeTimer = new System.Windows.Forms.Timer();                   // Timer initialisieren
            closeTimer.Interval = 500;                                                                  // 800ms warten
            closeTimer.Tick += CloseTimer_Tick;                                                         // Eventhandler für das Tick-Ereignis
            closeTimer.Start();                                                                         // Timer starten
        }

        private void CloseTimer_Tick(object sender, EventArgs e)
        {
            
            System.Windows.Forms.Timer timer = sender as System.Windows.Forms.Timer;
            timer.Stop();                                                                               // Timer stoppen

           
            this.Close();                                                                               // Form schließen
        }
    }
}