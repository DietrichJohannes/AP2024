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
    public partial class AddCommentTimePicker : Form
    {
        DateTime lastValue1;
        DateTime lastValue2;

        bool setValue = false;

        public AddCommentTimePicker()
        {
            InitializeComponent();
            lastValue1 = dateTimePicker1.Value;
            lastValue2 = dateTimePicker2.Value;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime currentValue = dateTimePicker1.Value;

            if(!setValue)
            {
            // Berechne, ob hoch oder runter gedrückt wurde
            if (currentValue > lastValue1)
            {
                dateTimePicker1.Value = lastValue1.AddMinutes(30);
            }
            else
            {
                dateTimePicker1.Value = lastValue1.AddMinutes(-30);
            }

            lastValue1 = dateTimePicker1.Value;
            }

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateTime currentValue = dateTimePicker2.Value;


            // Berechne, ob hoch oder runter gedrückt wurde
            if (currentValue > lastValue2)
            {
                dateTimePicker2.Value = lastValue2.AddMinutes(30);
            }
            else
            {
                dateTimePicker2.Value = lastValue2.AddMinutes(-30);
            }

            lastValue2 = dateTimePicker2.Value;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                dateTimePicker2.Enabled = false;
            }
            else
            {
                dateTimePicker2.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setValue = true;
            dateTimePicker1.Value = DateTime.Parse(ApplicationContext.GetCurrentTime());
            lastValue1 = dateTimePicker1.Value;
            setValue = false;
        }
    }
}
