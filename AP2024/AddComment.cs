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
    public partial class AddComment : Form
    {

        public string CommentText { get; private set; }

        public AddComment()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CommentText = comment_richText.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
