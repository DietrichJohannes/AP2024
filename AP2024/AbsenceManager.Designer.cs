namespace AP2024
{
    partial class AbsenceManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AbsenceManager));
            absenceTypeListView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // absenceTypeListView
            // 
            absenceTypeListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            absenceTypeListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            absenceTypeListView.Location = new Point(12, 12);
            absenceTypeListView.Name = "absenceTypeListView";
            absenceTypeListView.Size = new Size(597, 282);
            absenceTypeListView.TabIndex = 0;
            absenceTypeListView.UseCompatibleStateImageBehavior = false;
            absenceTypeListView.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Name";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Kürzel";
            columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Farbe";
            columnHeader3.Width = 160;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Kommentar verlangen";
            columnHeader4.Width = 150;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(511, 300);
            button1.Name = "button1";
            button1.Size = new Size(97, 23);
            button1.TabIndex = 1;
            button1.Text = "Löschen";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.Location = new Point(408, 300);
            button2.Name = "button2";
            button2.Size = new Size(97, 23);
            button2.TabIndex = 2;
            button2.Text = "Bearbeiten";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button3.Location = new Point(408, 329);
            button3.Name = "button3";
            button3.Size = new Size(200, 23);
            button3.TabIndex = 3;
            button3.Text = "Abwesenheitstyp hinzufügen";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // AbsenceManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 364);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(absenceTypeListView);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AbsenceManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Abwesenheitstypen verwalten";
            FormClosing += AbsenceManager_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private ListView absenceTypeListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}