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
    public partial class PublicHolidayManager : Form
    {
        public PublicHolidayManager()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
        }
    }
}
