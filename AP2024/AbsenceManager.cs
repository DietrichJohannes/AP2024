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
    public partial class AbsenceManager : Form
    {
        public AbsenceManager()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NewAbsence newAbsence = new NewAbsence();
            newAbsence.ShowDialog();
        }
    }
}
