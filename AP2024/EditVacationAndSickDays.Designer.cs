namespace AP2024
{
    partial class EditVacationAndSickDays
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditVacationAndSickDays));
            label1 = new Label();
            employee_name = new Label();
            NUDAbsence_days = new NumericUpDown();
            absence_name = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)NUDAbsence_days).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // employee_name
            // 
            employee_name.AutoSize = true;
            employee_name.Location = new Point(251, 24);
            employee_name.Name = "employee_name";
            employee_name.Size = new Size(47, 15);
            employee_name.TabIndex = 1;
            employee_name.Text = "[Name]";
            // 
            // NUDAbsence_days
            // 
            NUDAbsence_days.Location = new Point(251, 66);
            NUDAbsence_days.Name = "NUDAbsence_days";
            NUDAbsence_days.Size = new Size(228, 23);
            NUDAbsence_days.TabIndex = 2;
            // 
            // absence_name
            // 
            absence_name.AutoSize = true;
            absence_name.Location = new Point(12, 74);
            absence_name.Name = "absence_name";
            absence_name.Size = new Size(32, 15);
            absence_name.TabIndex = 3;
            absence_name.Text = "Tage";
            // 
            // button1
            // 
            button1.Location = new Point(404, 136);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Speichern";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // EditVacationAndSickDays
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 171);
            Controls.Add(button1);
            Controls.Add(absence_name);
            Controls.Add(NUDAbsence_days);
            Controls.Add(employee_name);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "EditVacationAndSickDays";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bearbeiten";
            ((System.ComponentModel.ISupportInitialize)NUDAbsence_days).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label employee_name;
        private NumericUpDown NUDAbsence_days;
        private Label absence_name;
        private Button button1;
    }
}