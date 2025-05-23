﻿namespace AP2024
{
    partial class UserSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserSettings));
            label1 = new Label();
            label2 = new Label();
            checkBox1 = new CheckBox();
            comboBox1 = new ComboBox();
            label3 = new Label();
            checkBox2 = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(241, 25);
            label1.TabIndex = 0;
            label1.Text = "Datenschutzeinstellungen";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 138);
            label2.Name = "label2";
            label2.Size = new Size(163, 25);
            label2.TabIndex = 1;
            label2.Text = "Erscheinungsbild";
            // 
            // checkBox1
            // 
            checkBox1.Location = new Point(12, 71);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(368, 36);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Andere Benutzer können Details über deine Abwesenheit sehen (Außgenommen Admins)";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Hell", "Dunkel" });
            comboBox1.Location = new Point(12, 190);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(180, 23);
            comboBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 247);
            label3.Name = "label3";
            label3.Size = new Size(84, 25);
            label3.TabIndex = 4;
            label3.Text = "Gleitzeit";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(12, 304);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(129, 19);
            checkBox2.TabIndex = 5;
            checkBox2.Text = "Gleitzeit verwenden";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // UserSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 476);
            Controls.Add(checkBox2);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(checkBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UserSettings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Einstellungen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private CheckBox checkBox1;
        private ComboBox comboBox1;
        private Label label3;
        private CheckBox checkBox2;
    }
}