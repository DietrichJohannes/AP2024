namespace AP2024
{
    partial class UserAddThemselves
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAddThemselves));
            firstNameText = new TextBox();
            lastNameText = new TextBox();
            CBViews = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            windows_user = new TextBox();
            remaining_leave = new TextBox();
            leave_entitlement = new TextBox();
            SuspendLayout();
            // 
            // firstNameText
            // 
            firstNameText.Location = new Point(155, 12);
            firstNameText.Name = "firstNameText";
            firstNameText.Size = new Size(258, 23);
            firstNameText.TabIndex = 0;
            // 
            // lastNameText
            // 
            lastNameText.Location = new Point(155, 41);
            lastNameText.Name = "lastNameText";
            lastNameText.Size = new Size(258, 23);
            lastNameText.TabIndex = 1;
            // 
            // CBViews
            // 
            CBViews.DropDownStyle = ComboBoxStyle.DropDownList;
            CBViews.FormattingEnabled = true;
            CBViews.Location = new Point(155, 70);
            CBViews.Name = "CBViews";
            CBViews.Size = new Size(258, 23);
            CBViews.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 20);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 6;
            label4.Text = "Vorname";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 49);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 7;
            label5.Text = "Nachname";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 78);
            label6.Name = "label6";
            label6.Size = new Size(32, 15);
            label6.TabIndex = 8;
            label6.Text = "View";
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(320, 195);
            button1.Name = "button1";
            button1.Size = new Size(93, 37);
            button1.TabIndex = 9;
            button1.Text = "OK";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 104);
            label7.Name = "label7";
            label7.Size = new Size(105, 15);
            label7.TabIndex = 10;
            label7.Text = "Windows Benutzer";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 133);
            label8.Name = "label8";
            label8.Size = new Size(67, 15);
            label8.TabIndex = 11;
            label8.Text = "Rest Urlaub";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 162);
            label9.Name = "label9";
            label9.Size = new Size(67, 15);
            label9.TabIndex = 12;
            label9.Text = "Tarif Urlaub";
            // 
            // windows_user
            // 
            windows_user.Location = new Point(155, 96);
            windows_user.Name = "windows_user";
            windows_user.ReadOnly = true;
            windows_user.Size = new Size(258, 23);
            windows_user.TabIndex = 13;
            // 
            // remaining_leave
            // 
            remaining_leave.Location = new Point(155, 125);
            remaining_leave.Name = "remaining_leave";
            remaining_leave.ReadOnly = true;
            remaining_leave.Size = new Size(258, 23);
            remaining_leave.TabIndex = 14;
            // 
            // leave_entitlement
            // 
            leave_entitlement.Location = new Point(155, 154);
            leave_entitlement.Name = "leave_entitlement";
            leave_entitlement.ReadOnly = true;
            leave_entitlement.Size = new Size(258, 23);
            leave_entitlement.TabIndex = 15;
            // 
            // UserAddThemselves
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 244);
            Controls.Add(leave_entitlement);
            Controls.Add(remaining_leave);
            Controls.Add(windows_user);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(CBViews);
            Controls.Add(lastNameText);
            Controls.Add(firstNameText);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(441, 283);
            Name = "UserAddThemselves";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Automatische Personen Erfassung";
            FormClosing += UserAddThemselves_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox firstNameText;
        private TextBox lastNameText;
        private ComboBox CBViews;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox windows_user;
        private TextBox remaining_leave;
        private TextBox leave_entitlement;
    }
}