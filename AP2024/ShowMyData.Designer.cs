namespace AP2024
{
    partial class ShowMyData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowMyData));
            label1 = new Label();
            label2 = new Label();
            first_name = new TextBox();
            last_name = new TextBox();
            windows_user = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            remaining_leav = new TextBox();
            leave_entitlement = new TextBox();
            sick_days = new TextBox();
            label6 = new Label();
            button1 = new Button();
            edit_button = new Button();
            disclaimer1 = new Label();
            disclaimer5 = new Label();
            disclaimer4 = new Label();
            disclaimer3 = new Label();
            disclaimer2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Vorname";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 49);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 1;
            label2.Text = "Nachname";
            // 
            // first_name
            // 
            first_name.Location = new Point(155, 12);
            first_name.Name = "first_name";
            first_name.ReadOnly = true;
            first_name.Size = new Size(258, 23);
            first_name.TabIndex = 2;
            // 
            // last_name
            // 
            last_name.Location = new Point(155, 41);
            last_name.Name = "last_name";
            last_name.ReadOnly = true;
            last_name.Size = new Size(258, 23);
            last_name.TabIndex = 3;
            // 
            // windows_user
            // 
            windows_user.Location = new Point(155, 70);
            windows_user.Name = "windows_user";
            windows_user.ReadOnly = true;
            windows_user.Size = new Size(258, 23);
            windows_user.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 78);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 5;
            label3.Text = "Windowsbenutzer";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 107);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 6;
            label4.Text = "Resturlaub";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 136);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 7;
            label5.Text = "Tarifurlaub";
            // 
            // remaining_leav
            // 
            remaining_leav.Location = new Point(155, 99);
            remaining_leav.Name = "remaining_leav";
            remaining_leav.ReadOnly = true;
            remaining_leav.Size = new Size(258, 23);
            remaining_leav.TabIndex = 8;
            // 
            // leave_entitlement
            // 
            leave_entitlement.Location = new Point(155, 128);
            leave_entitlement.Name = "leave_entitlement";
            leave_entitlement.ReadOnly = true;
            leave_entitlement.Size = new Size(258, 23);
            leave_entitlement.TabIndex = 9;
            // 
            // sick_days
            // 
            sick_days.Location = new Point(155, 157);
            sick_days.Name = "sick_days";
            sick_days.ReadOnly = true;
            sick_days.Size = new Size(258, 23);
            sick_days.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 165);
            label6.Name = "label6";
            label6.Size = new Size(85, 15);
            label6.TabIndex = 11;
            label6.Text = "Krankheitstage";
            // 
            // button1
            // 
            button1.Location = new Point(257, 211);
            button1.Name = "button1";
            button1.Size = new Size(156, 23);
            button1.TabIndex = 12;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // edit_button
            // 
            edit_button.Enabled = false;
            edit_button.Location = new Point(95, 211);
            edit_button.Name = "edit_button";
            edit_button.Size = new Size(156, 23);
            edit_button.TabIndex = 13;
            edit_button.Text = "Bearbeiten";
            edit_button.UseVisualStyleBackColor = true;
            edit_button.Click += edit_button_Click;
            // 
            // disclaimer1
            // 
            disclaimer1.AutoSize = true;
            disclaimer1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            disclaimer1.ForeColor = Color.Red;
            disclaimer1.Location = new Point(95, 193);
            disclaimer1.Name = "disclaimer1";
            disclaimer1.Size = new Size(292, 15);
            disclaimer1.TabIndex = 14;
            disclaimer1.Text = "*  Nur der ZeitAdmin kann diese Werte Bearbeiten!";
            disclaimer1.Visible = false;
            // 
            // disclaimer5
            // 
            disclaimer5.AutoSize = true;
            disclaimer5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            disclaimer5.ForeColor = Color.Red;
            disclaimer5.Location = new Point(132, 73);
            disclaimer5.Name = "disclaimer5";
            disclaimer5.Size = new Size(17, 21);
            disclaimer5.TabIndex = 15;
            disclaimer5.Text = "*";
            disclaimer5.Visible = false;
            // 
            // disclaimer4
            // 
            disclaimer4.AutoSize = true;
            disclaimer4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            disclaimer4.ForeColor = Color.Red;
            disclaimer4.Location = new Point(132, 102);
            disclaimer4.Name = "disclaimer4";
            disclaimer4.Size = new Size(17, 21);
            disclaimer4.TabIndex = 16;
            disclaimer4.Text = "*";
            disclaimer4.Visible = false;
            // 
            // disclaimer3
            // 
            disclaimer3.AutoSize = true;
            disclaimer3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            disclaimer3.ForeColor = Color.Red;
            disclaimer3.Location = new Point(132, 130);
            disclaimer3.Name = "disclaimer3";
            disclaimer3.Size = new Size(17, 21);
            disclaimer3.TabIndex = 17;
            disclaimer3.Text = "*";
            disclaimer3.Visible = false;
            // 
            // disclaimer2
            // 
            disclaimer2.AutoSize = true;
            disclaimer2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            disclaimer2.ForeColor = Color.Red;
            disclaimer2.Location = new Point(132, 157);
            disclaimer2.Name = "disclaimer2";
            disclaimer2.Size = new Size(17, 21);
            disclaimer2.TabIndex = 18;
            disclaimer2.Text = "*";
            disclaimer2.Visible = false;
            // 
            // ShowMyData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 246);
            Controls.Add(disclaimer2);
            Controls.Add(disclaimer3);
            Controls.Add(disclaimer4);
            Controls.Add(disclaimer5);
            Controls.Add(disclaimer1);
            Controls.Add(edit_button);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(sick_days);
            Controls.Add(leave_entitlement);
            Controls.Add(remaining_leav);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(windows_user);
            Controls.Add(last_name);
            Controls.Add(first_name);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ShowMyData";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Meine Daten";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox first_name;
        private TextBox last_name;
        private TextBox windows_user;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox remaining_leav;
        private TextBox leave_entitlement;
        private TextBox sick_days;
        private Label label6;
        private Button button1;
        private Button edit_button;
        private Label disclaimer1;
        private Label disclaimer5;
        private Label disclaimer4;
        private Label disclaimer3;
        private Label disclaimer2;
    }
}