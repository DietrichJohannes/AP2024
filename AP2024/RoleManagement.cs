﻿using System;
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
    public partial class RoleManagement : Form
    {
        public RoleManagement()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            RoleInfo roleInfo = new RoleInfo();
            roleInfo.ShowDialog();
        }
    }
}
