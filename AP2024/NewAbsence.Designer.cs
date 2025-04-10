namespace AP2024
{
    partial class NewAbsence
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewAbsence));
            AbsenceTypesCB = new ComboBox();
            StartDateDTP = new DateTimePicker();
            EndDateDTP = new DateTimePicker();
            CommentRTB = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // AbsenceTypesCB
            // 
            AbsenceTypesCB.DropDownStyle = ComboBoxStyle.DropDownList;
            AbsenceTypesCB.FormattingEnabled = true;
            AbsenceTypesCB.Location = new Point(172, 12);
            AbsenceTypesCB.Name = "AbsenceTypesCB";
            AbsenceTypesCB.Size = new Size(200, 23);
            AbsenceTypesCB.TabIndex = 0;
            // 
            // StartDateDTP
            // 
            StartDateDTP.CustomFormat = "";
            StartDateDTP.Location = new Point(172, 41);
            StartDateDTP.Name = "StartDateDTP";
            StartDateDTP.Size = new Size(200, 23);
            StartDateDTP.TabIndex = 1;
            StartDateDTP.Value = new DateTime(2025, 4, 10, 0, 0, 0, 0);
            // 
            // EndDateDTP
            // 
            EndDateDTP.Location = new Point(172, 70);
            EndDateDTP.Name = "EndDateDTP";
            EndDateDTP.Size = new Size(200, 23);
            EndDateDTP.TabIndex = 2;
            EndDateDTP.Value = new DateTime(2025, 4, 10, 0, 0, 0, 0);
            // 
            // CommentRTB
            // 
            CommentRTB.Location = new Point(172, 99);
            CommentRTB.Name = "CommentRTB";
            CommentRTB.Size = new Size(200, 78);
            CommentRTB.TabIndex = 3;
            CommentRTB.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 4;
            label1.Text = "Abwesenheitstyp";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 41);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 5;
            label2.Text = "Startdatum";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 99);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 6;
            label3.Text = "Bemerkung";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 70);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 7;
            label4.Text = "Enddatum";
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(270, 183);
            button1.Name = "button1";
            button1.Size = new Size(102, 35);
            button1.TabIndex = 8;
            button1.Text = "Speichern";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // NewAbsence
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 230);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CommentRTB);
            Controls.Add(EndDateDTP);
            Controls.Add(StartDateDTP);
            Controls.Add(AbsenceTypesCB);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "NewAbsence";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Neue Abwesenheit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox AbsenceTypesCB;
        private DateTimePicker StartDateDTP;
        private DateTimePicker EndDateDTP;
        private RichTextBox CommentRTB;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
    }
}