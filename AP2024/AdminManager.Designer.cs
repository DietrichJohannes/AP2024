namespace AP2024
{
    partial class AdminManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminManager));
            adminListView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // adminListView
            // 
            adminListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            adminListView.Location = new Point(12, 12);
            adminListView.Name = "adminListView";
            adminListView.Size = new Size(776, 359);
            adminListView.TabIndex = 0;
            adminListView.UseCompatibleStateImageBehavior = false;
            adminListView.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Admins";
            columnHeader1.Width = 385;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Rolle";
            columnHeader2.Width = 385;
            // 
            // button1
            // 
            button1.Location = new Point(713, 377);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Löschen";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(632, 377);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Bearbeiten";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(632, 406);
            button3.Name = "button3";
            button3.Size = new Size(156, 23);
            button3.TabIndex = 3;
            button3.Text = "Admin hinzufügen";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 377);
            button4.Name = "button4";
            button4.Size = new Size(156, 23);
            button4.TabIndex = 4;
            button4.Text = "Rolle ändern";
            button4.UseVisualStyleBackColor = true;
            // 
            // AdminManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(adminListView);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminManager";
            Text = "Admin Konsole";
            ResumeLayout(false);
        }

        #endregion

        private ListView adminListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}