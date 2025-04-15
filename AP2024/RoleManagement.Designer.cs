namespace AP2024
{
    partial class RoleManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoleManagement));
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            employee_Name = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Zeit Administrator", "Admin", "Bearbeiter", "Mitarbeiter" });
            comboBox1.Location = new Point(301, 41);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(268, 23);
            comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(152, 15);
            label1.TabIndex = 1;
            label1.Text = "Berechtigungen ändern für:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 49);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 2;
            label2.Text = "Rolle";
            // 
            // employee_Name
            // 
            employee_Name.Location = new Point(301, 9);
            employee_Name.Name = "employee_Name";
            employee_Name.Size = new Size(268, 23);
            employee_Name.TabIndex = 3;
            employee_Name.Text = "[Mitarbeiter Name]";
            // 
            // button1
            // 
            button1.Location = new Point(494, 107);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Speichern";
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(301, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // RoleManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 142);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(employee_Name);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RoleManagement";
            Text = "Benutzerrechte Verwalten";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private Label employee_Name;
        private Button button1;
        private PictureBox pictureBox1;
    }
}