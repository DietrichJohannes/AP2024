namespace AP2024
{
    partial class AP2024Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AP2024Settings));
            user_can_add_themselvesCB = new CheckBox();
            user_can_edit_themselvesCB = new CheckBox();
            button1 = new Button();
            departmentTB = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            leave_entitlementNUD = new NumericUpDown();
            remaining_leaveNUD = new NumericUpDown();
            label7 = new Label();
            label8 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)leave_entitlementNUD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)remaining_leaveNUD).BeginInit();
            SuspendLayout();
            // 
            // user_can_add_themselvesCB
            // 
            user_can_add_themselvesCB.AutoSize = true;
            user_can_add_themselvesCB.Location = new Point(307, 184);
            user_can_add_themselvesCB.Name = "user_can_add_themselvesCB";
            user_can_add_themselvesCB.Size = new Size(15, 14);
            user_can_add_themselvesCB.TabIndex = 0;
            user_can_add_themselvesCB.UseVisualStyleBackColor = true;

            // 
            // user_can_edit_themselvesCB
            // 
            user_can_edit_themselvesCB.AutoSize = true;
            user_can_edit_themselvesCB.Location = new Point(307, 321);
            user_can_edit_themselvesCB.Name = "user_can_edit_themselvesCB";
            user_can_edit_themselvesCB.Size = new Size(15, 14);
            user_can_edit_themselvesCB.TabIndex = 1;
            user_can_edit_themselvesCB.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(631, 325);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Speichern";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // departmentTB
            // 
            departmentTB.Location = new Point(140, 62);
            departmentTB.Name = "departmentTB";
            departmentTB.ReadOnly = true;
            departmentTB.Size = new Size(182, 23);
            departmentTB.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(111, 30);
            label1.TabIndex = 4;
            label1.Text = "Abteilung";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 70);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 5;
            label2.Text = "Abteilung";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 128);
            label3.Name = "label3";
            label3.Size = new Size(123, 30);
            label3.TabIndex = 6;
            label3.Text = "Mitarbeiter";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 184);
            label4.Name = "label4";
            label4.Size = new Size(228, 15);
            label4.TabIndex = 7;
            label4.Text = "Mitarbeiter können sich selbst hinzufügen";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 321);
            label5.Name = "label5";
            label5.Size = new Size(218, 15);
            label5.TabIndex = 8;
            label5.Text = "Mitarbeiter können ihr Daten Bearbeiten";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 215);
            label6.Name = "label6";
            label6.Size = new Size(80, 15);
            label6.TabIndex = 9;
            label6.Text = "Standartwerte";
            // 
            // leave_entitlementNUD
            // 
            leave_entitlementNUD.Location = new Point(202, 241);
            leave_entitlementNUD.Name = "leave_entitlementNUD";
            leave_entitlementNUD.Size = new Size(120, 23);
            leave_entitlementNUD.TabIndex = 10;
            // 
            // remaining_leaveNUD
            // 
            remaining_leaveNUD.Location = new Point(202, 270);
            remaining_leaveNUD.Name = "remaining_leaveNUD";
            remaining_leaveNUD.Size = new Size(120, 23);
            remaining_leaveNUD.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(33, 249);
            label7.Name = "label7";
            label7.Size = new Size(64, 15);
            label7.TabIndex = 12;
            label7.Text = "Tarifurlaub";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(33, 278);
            label8.Name = "label8";
            label8.Size = new Size(63, 15);
            label8.TabIndex = 13;
            label8.Text = "Resturlaub";
            // 
            // button2
            // 
            button2.Location = new Point(370, 62);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 14;
            button2.Text = "Bearbeiten";
            button2.UseVisualStyleBackColor = true;
            // 
            // AP2024Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 360);
            Controls.Add(button2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(remaining_leaveNUD);
            Controls.Add(leave_entitlementNUD);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(departmentTB);
            Controls.Add(button1);
            Controls.Add(user_can_edit_themselvesCB);
            Controls.Add(user_can_add_themselvesCB);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AP2024Settings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AP2024 Einstellungen";
            ((System.ComponentModel.ISupportInitialize)leave_entitlementNUD).EndInit();
            ((System.ComponentModel.ISupportInitialize)remaining_leaveNUD).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox user_can_add_themselvesCB;
        private CheckBox user_can_edit_themselvesCB;
        private Button button1;
        private TextBox departmentTB;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private NumericUpDown leave_entitlementNUD;
        private NumericUpDown remaining_leaveNUD;
        private Label label7;
        private Label label8;
        private Button button2;
    }
}