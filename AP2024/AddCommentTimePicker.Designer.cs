namespace AP2024
{
    partial class AddCommentTimePicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCommentTimePicker));
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            checkBox1 = new CheckBox();
            dateTimePicker2 = new DateTimePicker();
            button2 = new Button();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "HH:mm";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(155, 30);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.Size = new Size(176, 23);
            dateTimePicker1.TabIndex = 0;
            dateTimePicker1.Value = new DateTime(2025, 4, 8, 7, 0, 0, 0);
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 1;
            label1.Text = "Abwesend ab";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 59);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 3;
            label2.Text = "Abwesend bis";
            // 
            // button1
            // 
            button1.Location = new Point(337, 30);
            button1.Name = "button1";
            button1.Size = new Size(120, 23);
            button1.TabIndex = 4;
            button1.Text = "Jetzt";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(155, 85);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 5;
            label3.Text = "oder";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(155, 103);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(102, 19);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Bis Feierabend";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "HH:mm";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(155, 59);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.ShowUpDown = true;
            dateTimePicker2.Size = new Size(176, 23);
            dateTimePicker2.TabIndex = 7;
            dateTimePicker2.Value = new DateTime(2025, 4, 8, 16, 0, 0, 0);
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // button2
            // 
            button2.Location = new Point(382, 208);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 8;
            button2.Text = "Speichern";
            button2.UseVisualStyleBackColor = true;
            // 
            // AddCommentTimePicker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 243);
            Controls.Add(button2);
            Controls.Add(dateTimePicker2);
            Controls.Add(checkBox1);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AddCommentTimePicker";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Abwesenheits Ziet hinzufügen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
        private CheckBox checkBox1;
        private DateTimePicker dateTimePicker2;
        private Button button2;
    }
}