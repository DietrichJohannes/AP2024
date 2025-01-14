namespace AP2024
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            cwView = new DataGridView();
            statusStrip1 = new StatusStrip();
            menuStrip1 = new MenuStrip();
            contextMenuStrip1 = new ContextMenuStrip(components);
            testToolStripMenuItem = new ToolStripMenuItem();
            test5ToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            calendarView = new DataGridView();
            monthView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)cwView).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)calendarView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)monthView).BeginInit();
            SuspendLayout();
            // 
            // cwView
            // 
            cwView.AllowUserToAddRows = false;
            cwView.AllowUserToDeleteRows = false;
            cwView.AllowUserToResizeColumns = false;
            cwView.AllowUserToResizeRows = false;
            cwView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cwView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cwView.Location = new Point(347, 107);
            cwView.Name = "cwView";
            cwView.ScrollBars = ScrollBars.None;
            cwView.Size = new Size(866, 28);
            cwView.TabIndex = 1;
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 493);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1225, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1225, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { testToolStripMenuItem, test5ToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(100, 48);
            // 
            // testToolStripMenuItem
            // 
            testToolStripMenuItem.Name = "testToolStripMenuItem";
            testToolStripMenuItem.Size = new Size(99, 22);
            testToolStripMenuItem.Text = "Test";
            // 
            // test5ToolStripMenuItem
            // 
            test5ToolStripMenuItem.Name = "test5ToolStripMenuItem";
            test5ToolStripMenuItem.Size = new Size(99, 22);
            test5ToolStripMenuItem.Text = "test5";
            // 
            // button1
            // 
            button1.Location = new Point(12, 27);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(93, 27);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(174, 27);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 7;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // calendarView
            // 
            calendarView.AllowUserToAddRows = false;
            calendarView.AllowUserToDeleteRows = false;
            calendarView.AllowUserToResizeColumns = false;
            calendarView.AllowUserToResizeRows = false;
            calendarView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            calendarView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            calendarView.Location = new Point(12, 141);
            calendarView.Name = "calendarView";
            calendarView.Size = new Size(1201, 313);
            calendarView.TabIndex = 8;
            // 
            // monthView
            // 
            monthView.AllowUserToAddRows = false;
            monthView.AllowUserToDeleteRows = false;
            monthView.AllowUserToResizeColumns = false;
            monthView.AllowUserToResizeRows = false;
            monthView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            monthView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            monthView.GridColor = Color.Black;
            monthView.Location = new Point(347, 73);
            monthView.Name = "monthView";
            monthView.ScrollBars = ScrollBars.None;
            monthView.Size = new Size(866, 28);
            monthView.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1225, 515);
            Controls.Add(monthView);
            Controls.Add(calendarView);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Controls.Add(cwView);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "AP2024";
            ((System.ComponentModel.ISupportInitialize)cwView).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)calendarView).EndInit();
            ((System.ComponentModel.ISupportInitialize)monthView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView monthView;
        private DataGridView cwView;
        private DataGridView calendarView;
        private StatusStrip statusStrip1;
        private MenuStrip menuStrip1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem testToolStripMenuItem;
        private ToolStripMenuItem test5ToolStripMenuItem;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
    }
}
