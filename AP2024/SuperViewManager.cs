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
    public partial class SuperViewManager : Form
    {
        public SuperViewManager()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NewSuperView newSuperView = new NewSuperView();
            newSuperView.ShowDialog();
        }
    }
}
