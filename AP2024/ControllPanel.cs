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
    public partial class ControllPanel: Form
    {
        public ControllPanel()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
        }
    }
}
