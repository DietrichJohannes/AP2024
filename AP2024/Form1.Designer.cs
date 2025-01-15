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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            cwView = new DataGridView();
            statusStrip1 = new StatusStrip();
            menuStrip1 = new MenuStrip();
            meinAP2024ToolStripMenuItem = new ToolStripMenuItem();
            meineDatenToolStripMenuItem = new ToolStripMenuItem();
            einstellungenToolStripMenuItem = new ToolStripMenuItem();
            administrationToolStripMenuItem = new ToolStripMenuItem();
            mitarbeiterverwaltungToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            feiertagsverwaltungToolStripMenuItem = new ToolStripMenuItem();
            adminKonsoleToolStripMenuItem = new ToolStripMenuItem();
            aP2024EinstellungenToolStripMenuItem = new ToolStripMenuItem();
            hilfeToolStripMenuItem = new ToolStripMenuItem();
            hilfeToolStripMenuItem1 = new ToolStripMenuItem();
            infoÜberDenEntwicklerToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            testToolStripMenuItem = new ToolStripMenuItem();
            test5ToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            calendarView = new DataGridView();
            monthView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)cwView).BeginInit();
            menuStrip1.SuspendLayout();
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
            cwView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            cwView.BorderStyle = BorderStyle.None;
            cwView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cwView.Enabled = false;
            cwView.GridColor = Color.LightGray;
            cwView.Location = new Point(347, 120);
            cwView.MultiSelect = false;
            cwView.Name = "cwView";
            cwView.ReadOnly = true;
            cwView.RowHeadersVisible = false;
            cwView.ScrollBars = ScrollBars.None;
            cwView.ShowCellErrors = false;
            cwView.ShowCellToolTips = false;
            cwView.ShowEditingIcon = false;
            cwView.ShowRowErrors = false;
            cwView.Size = new Size(866, 20);
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
            menuStrip1.Items.AddRange(new ToolStripItem[] { meinAP2024ToolStripMenuItem, administrationToolStripMenuItem, hilfeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1225, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // meinAP2024ToolStripMenuItem
            // 
            meinAP2024ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { meineDatenToolStripMenuItem, einstellungenToolStripMenuItem });
            meinAP2024ToolStripMenuItem.Name = "meinAP2024ToolStripMenuItem";
            meinAP2024ToolStripMenuItem.Size = new Size(88, 20);
            meinAP2024ToolStripMenuItem.Text = "Mein AP2024";
            // 
            // meineDatenToolStripMenuItem
            // 
            meineDatenToolStripMenuItem.Name = "meineDatenToolStripMenuItem";
            meineDatenToolStripMenuItem.Size = new Size(145, 22);
            meineDatenToolStripMenuItem.Text = "Meine Daten";
            // 
            // einstellungenToolStripMenuItem
            // 
            einstellungenToolStripMenuItem.Name = "einstellungenToolStripMenuItem";
            einstellungenToolStripMenuItem.Size = new Size(145, 22);
            einstellungenToolStripMenuItem.Text = "Einstellungen";
            // 
            // administrationToolStripMenuItem
            // 
            administrationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mitarbeiterverwaltungToolStripMenuItem, toolStripMenuItem1, toolStripMenuItem2, feiertagsverwaltungToolStripMenuItem, adminKonsoleToolStripMenuItem, aP2024EinstellungenToolStripMenuItem });
            administrationToolStripMenuItem.Name = "administrationToolStripMenuItem";
            administrationToolStripMenuItem.Size = new Size(98, 20);
            administrationToolStripMenuItem.Text = "Administration";
            // 
            // mitarbeiterverwaltungToolStripMenuItem
            // 
            mitarbeiterverwaltungToolStripMenuItem.Name = "mitarbeiterverwaltungToolStripMenuItem";
            mitarbeiterverwaltungToolStripMenuItem.Size = new Size(191, 22);
            mitarbeiterverwaltungToolStripMenuItem.Text = "Mitarbeiterverwaltung";
            mitarbeiterverwaltungToolStripMenuItem.Click += mitarbeiterverwaltungToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(191, 22);
            toolStripMenuItem1.Text = "Views verwalten";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(191, 22);
            toolStripMenuItem2.Text = "Abwesenheitstypen";
            // 
            // feiertagsverwaltungToolStripMenuItem
            // 
            feiertagsverwaltungToolStripMenuItem.Name = "feiertagsverwaltungToolStripMenuItem";
            feiertagsverwaltungToolStripMenuItem.Size = new Size(191, 22);
            feiertagsverwaltungToolStripMenuItem.Text = "Feiertagsverwaltung";
            // 
            // adminKonsoleToolStripMenuItem
            // 
            adminKonsoleToolStripMenuItem.Name = "adminKonsoleToolStripMenuItem";
            adminKonsoleToolStripMenuItem.Size = new Size(191, 22);
            adminKonsoleToolStripMenuItem.Text = "Admin Konsole";
            // 
            // aP2024EinstellungenToolStripMenuItem
            // 
            aP2024EinstellungenToolStripMenuItem.Name = "aP2024EinstellungenToolStripMenuItem";
            aP2024EinstellungenToolStripMenuItem.Size = new Size(191, 22);
            aP2024EinstellungenToolStripMenuItem.Text = "AP2024 Einstellungen";
            // 
            // hilfeToolStripMenuItem
            // 
            hilfeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hilfeToolStripMenuItem1, infoÜberDenEntwicklerToolStripMenuItem });
            hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            hilfeToolStripMenuItem.Size = new Size(44, 20);
            hilfeToolStripMenuItem.Text = "Hilfe";
            // 
            // hilfeToolStripMenuItem1
            // 
            hilfeToolStripMenuItem1.Name = "hilfeToolStripMenuItem1";
            hilfeToolStripMenuItem1.Size = new Size(202, 22);
            hilfeToolStripMenuItem1.Text = "Hilfe";
            // 
            // infoÜberDenEntwicklerToolStripMenuItem
            // 
            infoÜberDenEntwicklerToolStripMenuItem.Name = "infoÜberDenEntwicklerToolStripMenuItem";
            infoÜberDenEntwicklerToolStripMenuItem.Size = new Size(202, 22);
            infoÜberDenEntwicklerToolStripMenuItem.Text = "Info über den Entwickler";
            infoÜberDenEntwicklerToolStripMenuItem.Click += infoÜberDenEntwicklerToolStripMenuItem_Click;
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
            button1.Image = Properties.Resources.refresh;
            button1.Location = new Point(12, 27);
            button1.Name = "button1";
            button1.Size = new Size(35, 35);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Image = Properties.Resources.save;
            button2.Location = new Point(53, 27);
            button2.Name = "button2";
            button2.Size = new Size(35, 35);
            button2.TabIndex = 6;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Image = Properties.Resources.arrow1;
            button3.Location = new Point(94, 27);
            button3.Name = "button3";
            button3.Size = new Size(35, 35);
            button3.TabIndex = 7;
            button3.UseVisualStyleBackColor = true;
            // 
            // calendarView
            // 
            calendarView.AllowUserToAddRows = false;
            calendarView.AllowUserToDeleteRows = false;
            calendarView.AllowUserToResizeColumns = false;
            calendarView.AllowUserToResizeRows = false;
            calendarView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            calendarView.BackgroundColor = SystemColors.Control;
            calendarView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            calendarView.Location = new Point(12, 140);
            calendarView.Name = "calendarView";
            calendarView.ReadOnly = true;
            calendarView.RowHeadersVisible = false;
            calendarView.Size = new Size(1201, 313);
            calendarView.TabIndex = 8;
            calendarView.Scroll += calendarView_Scroll;
            // 
            // monthView
            // 
            monthView.AllowUserToAddRows = false;
            monthView.AllowUserToDeleteRows = false;
            monthView.AllowUserToResizeColumns = false;
            monthView.AllowUserToResizeRows = false;
            monthView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            monthView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            monthView.BorderStyle = BorderStyle.None;
            monthView.CausesValidation = false;
            monthView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            monthView.Enabled = false;
            monthView.GridColor = Color.LightGray;
            monthView.Location = new Point(347, 100);
            monthView.MultiSelect = false;
            monthView.Name = "monthView";
            monthView.ReadOnly = true;
            monthView.RowHeadersVisible = false;
            monthView.ScrollBars = ScrollBars.None;
            monthView.ShowCellErrors = false;
            monthView.ShowCellToolTips = false;
            monthView.ShowEditingIcon = false;
            monthView.ShowRowErrors = false;
            monthView.Size = new Size(866, 20);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "AP2024";
            ((System.ComponentModel.ISupportInitialize)cwView).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
        private ToolStripMenuItem meinAP2024ToolStripMenuItem;
        private ToolStripMenuItem meineDatenToolStripMenuItem;
        private ToolStripMenuItem einstellungenToolStripMenuItem;
        private ToolStripMenuItem administrationToolStripMenuItem;
        private ToolStripMenuItem mitarbeiterverwaltungToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem feiertagsverwaltungToolStripMenuItem;
        private ToolStripMenuItem adminKonsoleToolStripMenuItem;
        private ToolStripMenuItem hilfeToolStripMenuItem;
        private ToolStripMenuItem aP2024EinstellungenToolStripMenuItem;
        private ToolStripMenuItem hilfeToolStripMenuItem1;
        private ToolStripMenuItem infoÜberDenEntwicklerToolStripMenuItem;
    }
}
