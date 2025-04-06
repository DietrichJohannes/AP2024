namespace AP2024
{
    partial class AP2024
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AP2024));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            cwView = new DataGridView();
            statusStrip1 = new StatusStrip();
            time_Admin = new ToolStripStatusLabel();
            user = new ToolStripStatusLabel();
            department = new ToolStripStatusLabel();
            flextime = new ToolStripStatusLabel();
            sick_days = new ToolStripStatusLabel();
            last_updated = new ToolStripStatusLabel();
            menuStrip1 = new MenuStrip();
            meinAP2024ToolStripMenuItem = new ToolStripMenuItem();
            meineDatenToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            einstellungenToolStripMenuItem = new ToolStripMenuItem();
            tESTToolStripMenuItem = new ToolStripMenuItem();
            administrationToolStripMenuItem = new ToolStripMenuItem();
            mitarbeiterverwaltungToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            feiertagsverwaltungToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            adminKonsoleToolStripMenuItem = new ToolStripMenuItem();
            aP2024EinstellungenToolStripMenuItem = new ToolStripMenuItem();
            hilfeToolStripMenuItem = new ToolStripMenuItem();
            hilfeToolStripMenuItem1 = new ToolStripMenuItem();
            anleitungToolStripMenuItem = new ToolStripMenuItem();
            infoÜberDenEntwicklerToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            calendarView = new DataGridView();
            monthView = new DataGridView();
            viewCB = new ComboBox();
            label1 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            button4 = new Button();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)cwView).BeginInit();
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)calendarView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)monthView).BeginInit();
            contextMenuStrip1.SuspendLayout();
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
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            cwView.DefaultCellStyle = dataGridViewCellStyle3;
            cwView.GridColor = Color.LightGray;
            cwView.Location = new Point(347, 157);
            cwView.MultiSelect = false;
            cwView.Name = "cwView";
            cwView.ReadOnly = true;
            cwView.RowHeadersVisible = false;
            cwView.ScrollBars = ScrollBars.None;
            cwView.ShowCellToolTips = false;
            cwView.ShowRowErrors = false;
            cwView.Size = new Size(866, 20);
            cwView.TabIndex = 1;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { time_Admin, user, department, flextime, sick_days, last_updated });
            statusStrip1.Location = new Point(0, 587);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1225, 22);
            statusStrip1.TabIndex = 3;
            // 
            // time_Admin
            // 
            time_Admin.Name = "time_Admin";
            time_Admin.Size = new Size(201, 17);
            time_Admin.Spring = true;
            time_Admin.Text = "ZeitAdmin";
            time_Admin.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // user
            // 
            user.Name = "user";
            user.Size = new Size(201, 17);
            user.Spring = true;
            user.Text = "Benutzer";
            user.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // department
            // 
            department.Name = "department";
            department.Size = new Size(201, 17);
            department.Spring = true;
            department.Text = "Abteilung";
            department.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flextime
            // 
            flextime.Name = "flextime";
            flextime.Size = new Size(201, 17);
            flextime.Spring = true;
            flextime.Text = "Gleitzeit";
            flextime.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // sick_days
            // 
            sick_days.Name = "sick_days";
            sick_days.Size = new Size(201, 17);
            sick_days.Spring = true;
            sick_days.Text = "Krankheitstage";
            sick_days.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // last_updated
            // 
            last_updated.Name = "last_updated";
            last_updated.Size = new Size(201, 17);
            last_updated.Spring = true;
            last_updated.Text = "Zuletzt Aktuallisiert:";
            last_updated.TextAlign = ContentAlignment.MiddleRight;
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.Items.AddRange(new ToolStripItem[] { meinAP2024ToolStripMenuItem, tESTToolStripMenuItem, administrationToolStripMenuItem, hilfeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RightToLeft = RightToLeft.No;
            menuStrip1.Size = new Size(1225, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // meinAP2024ToolStripMenuItem
            // 
            meinAP2024ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { meineDatenToolStripMenuItem, toolStripMenuItem5, einstellungenToolStripMenuItem });
            meinAP2024ToolStripMenuItem.Name = "meinAP2024ToolStripMenuItem";
            meinAP2024ToolStripMenuItem.Size = new Size(88, 20);
            meinAP2024ToolStripMenuItem.Text = "Mein AP2024";
            // 
            // meineDatenToolStripMenuItem
            // 
            meineDatenToolStripMenuItem.Name = "meineDatenToolStripMenuItem";
            meineDatenToolStripMenuItem.Size = new Size(205, 22);
            meineDatenToolStripMenuItem.Text = "Meine Daten";
            meineDatenToolStripMenuItem.Click += meineDatenToolStripMenuItem_Click;
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(205, 22);
            toolStripMenuItem5.Text = "Abwesenheit hinzufügen";
            toolStripMenuItem5.Click += toolStripMenuItem5_Click;
            // 
            // einstellungenToolStripMenuItem
            // 
            einstellungenToolStripMenuItem.Name = "einstellungenToolStripMenuItem";
            einstellungenToolStripMenuItem.Size = new Size(205, 22);
            einstellungenToolStripMenuItem.Text = "Einstellungen";
            einstellungenToolStripMenuItem.Click += einstellungenToolStripMenuItem_Click;
            // 
            // tESTToolStripMenuItem
            // 
            tESTToolStripMenuItem.Name = "tESTToolStripMenuItem";
            tESTToolStripMenuItem.Size = new Size(12, 20);
            // 
            // administrationToolStripMenuItem
            // 
            administrationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mitarbeiterverwaltungToolStripMenuItem, toolStripMenuItem1, toolStripMenuItem2, toolStripSeparator1, feiertagsverwaltungToolStripMenuItem, toolStripSeparator2, adminKonsoleToolStripMenuItem, aP2024EinstellungenToolStripMenuItem });
            administrationToolStripMenuItem.Name = "administrationToolStripMenuItem";
            administrationToolStripMenuItem.Size = new Size(98, 20);
            administrationToolStripMenuItem.Text = "Administration";
            administrationToolStripMenuItem.Visible = false;
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
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(191, 22);
            toolStripMenuItem2.Text = "Abwesenheitstypen";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(188, 6);
            // 
            // feiertagsverwaltungToolStripMenuItem
            // 
            feiertagsverwaltungToolStripMenuItem.Name = "feiertagsverwaltungToolStripMenuItem";
            feiertagsverwaltungToolStripMenuItem.Size = new Size(191, 22);
            feiertagsverwaltungToolStripMenuItem.Text = "Feiertagsverwaltung";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(188, 6);
            // 
            // adminKonsoleToolStripMenuItem
            // 
            adminKonsoleToolStripMenuItem.Name = "adminKonsoleToolStripMenuItem";
            adminKonsoleToolStripMenuItem.Size = new Size(191, 22);
            adminKonsoleToolStripMenuItem.Text = "Admin Konsole";
            adminKonsoleToolStripMenuItem.Click += adminKonsoleToolStripMenuItem_Click;
            // 
            // aP2024EinstellungenToolStripMenuItem
            // 
            aP2024EinstellungenToolStripMenuItem.Name = "aP2024EinstellungenToolStripMenuItem";
            aP2024EinstellungenToolStripMenuItem.Size = new Size(191, 22);
            aP2024EinstellungenToolStripMenuItem.Text = "AP2024 Einstellungen";
            // 
            // hilfeToolStripMenuItem
            // 
            hilfeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hilfeToolStripMenuItem1, anleitungToolStripMenuItem, infoÜberDenEntwicklerToolStripMenuItem });
            hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            hilfeToolStripMenuItem.Size = new Size(44, 20);
            hilfeToolStripMenuItem.Text = "Hilfe";
            // 
            // hilfeToolStripMenuItem1
            // 
            hilfeToolStripMenuItem1.Name = "hilfeToolStripMenuItem1";
            hilfeToolStripMenuItem1.Size = new Size(202, 22);
            hilfeToolStripMenuItem1.Text = "Homepage von AP2024";
            hilfeToolStripMenuItem1.Click += hilfeToolStripMenuItem1_Click;
            // 
            // anleitungToolStripMenuItem
            // 
            anleitungToolStripMenuItem.Name = "anleitungToolStripMenuItem";
            anleitungToolStripMenuItem.Size = new Size(202, 22);
            anleitungToolStripMenuItem.Text = "Anleitung";
            anleitungToolStripMenuItem.Click += anleitungToolStripMenuItem_Click;
            // 
            // infoÜberDenEntwicklerToolStripMenuItem
            // 
            infoÜberDenEntwicklerToolStripMenuItem.Name = "infoÜberDenEntwicklerToolStripMenuItem";
            infoÜberDenEntwicklerToolStripMenuItem.Size = new Size(202, 22);
            infoÜberDenEntwicklerToolStripMenuItem.Text = "Info über den Entwickler";
            infoÜberDenEntwicklerToolStripMenuItem.Click += infoÜberDenEntwicklerToolStripMenuItem_Click;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(12, 27);
            button1.Name = "button1";
            button1.Size = new Size(35, 35);
            button1.TabIndex = 5;
            toolTip1.SetToolTip(button1, "Neuladen");
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(53, 27);
            button2.Name = "button2";
            button2.Size = new Size(35, 35);
            button2.TabIndex = 6;
            toolTip1.SetToolTip(button2, "Speichern");
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(94, 27);
            button3.Name = "button3";
            button3.Size = new Size(35, 35);
            button3.TabIndex = 7;
            toolTip1.SetToolTip(button3, "Gehe zu Heute");
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
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
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            calendarView.DefaultCellStyle = dataGridViewCellStyle4;
            calendarView.Location = new Point(12, 177);
            calendarView.Name = "calendarView";
            calendarView.ReadOnly = true;
            calendarView.RowHeadersVisible = false;
            calendarView.Size = new Size(1201, 407);
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
            monthView.EditMode = DataGridViewEditMode.EditProgrammatically;
            monthView.GridColor = Color.LightGray;
            monthView.Location = new Point(347, 137);
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
            // viewCB
            // 
            viewCB.DropDownStyle = ComboBoxStyle.DropDownList;
            viewCB.Location = new Point(347, 39);
            viewCB.Name = "viewCB";
            viewCB.Size = new Size(240, 23);
            viewCB.TabIndex = 10;
            viewCB.SelectedIndexChanged += viewCB_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(241, 47);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 11;
            label1.Text = "View";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripSeparator3, toolStripMenuItem4, toolStripMenuItem3 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(202, 54);
            contextMenuStrip1.Text = "Abwesenheiten";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(198, 6);
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(201, 22);
            toolStripMenuItem4.Text = "Abwesenheit bearbeiten";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(201, 22);
            toolStripMenuItem3.Text = "Abwesenheit löschen";
            // 
            // button4
            // 
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(135, 27);
            button4.Name = "button4";
            button4.Size = new Size(35, 35);
            button4.TabIndex = 12;
            toolTip1.SetToolTip(button4, "Gleitzeit eintragen");
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // AP2024
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1225, 609);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(viewCB);
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
            Name = "AP2024";
            Text = "AP2024";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)cwView).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)calendarView).EndInit();
            ((System.ComponentModel.ISupportInitialize)monthView).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView monthView;
        private DataGridView cwView;
        private DataGridView calendarView;
        private StatusStrip statusStrip1;
        private MenuStrip menuStrip1;
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
        private ComboBox viewCB;
        private Label label1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem anleitungToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripStatusLabel time_Admin;
        private ToolStripStatusLabel user;
        private ToolStripStatusLabel sick_days;
        private ToolStripStatusLabel last_updated;
        private ToolStripStatusLabel department;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem tESTToolStripMenuItem;
        private ToolStripStatusLabel flextime;
        private Button button4;
        private ToolTip toolTip1;
    }
}
