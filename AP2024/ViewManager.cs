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
    public partial class ViewManager : Form
    {
        public ViewManager()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SuperViewManager superViewManager = new SuperViewManager();
            superViewManager.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NewView newView = new NewView();
            newView.ShowDialog();
        }
    }
}
