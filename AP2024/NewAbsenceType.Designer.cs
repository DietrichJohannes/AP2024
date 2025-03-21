namespace AP2024
{
    partial class NewAbsenceType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewAbsenceType));
            nameTextBox = new TextBox();
            abbreviationTextBox = new TextBox();
            btnChooseColor = new Button();
            requestCommentCheckBox = new CheckBox();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(218, 12);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(146, 23);
            nameTextBox.TabIndex = 0;
            // 
            // abbreviationTextBox
            // 
            abbreviationTextBox.Location = new Point(218, 38);
            abbreviationTextBox.Name = "abbreviationTextBox";
            abbreviationTextBox.Size = new Size(146, 23);
            abbreviationTextBox.TabIndex = 1;
            // 
            // btnChooseColor
            // 
            btnChooseColor.Location = new Point(218, 67);
            btnChooseColor.Name = "btnChooseColor";
            btnChooseColor.Size = new Size(146, 23);
            btnChooseColor.TabIndex = 2;
            btnChooseColor.Text = "Farbe wählen";
            btnChooseColor.UseVisualStyleBackColor = true;
            btnChooseColor.Click += btnChooseColor_Click;
            // 
            // requestCommentCheckBox
            // 
            requestCommentCheckBox.AutoSize = true;
            requestCommentCheckBox.Location = new Point(218, 96);
            requestCommentCheckBox.Name = "requestCommentCheckBox";
            requestCommentCheckBox.Size = new Size(15, 14);
            requestCommentCheckBox.TabIndex = 3;
            requestCommentCheckBox.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(291, 143);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Speichern";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 6;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 46);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 7;
            label2.Text = "Kürzel";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 75);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 8;
            label3.Text = "Farbe";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 100);
            label4.Name = "label4";
            label4.Size = new Size(125, 15);
            label4.TabIndex = 9;
            label4.Text = "Kommentar verlangen";
            // 
            // NewAbsence
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 177);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(requestCommentCheckBox);
            Controls.Add(btnChooseColor);
            Controls.Add(abbreviationTextBox);
            Controls.Add(nameTextBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "NewAbsence";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Abwesenheitstyp hinzufügen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameTextBox;
        private TextBox abbreviationTextBox;
        private Button btnChooseColor;
        private CheckBox requestCommentCheckBox;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}