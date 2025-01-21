namespace AP2024
{
    partial class NewEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewEmployee));
            button1 = new Button();
            firstNameText = new TextBox();
            lastNameText = new TextBox();
            windowsUserText = new TextBox();
            viewCB = new ComboBox();
            leaveEntitlementNUD = new NumericUpDown();
            remainingLeaveNUD = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)leaveEntitlementNUD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)remainingLeaveNUD).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(424, 205);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Speichern";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // firstNameText
            // 
            firstNameText.Location = new Point(220, 12);
            firstNameText.Name = "firstNameText";
            firstNameText.Size = new Size(279, 23);
            firstNameText.TabIndex = 1;
            // 
            // lastNameText
            // 
            lastNameText.Location = new Point(220, 41);
            lastNameText.Name = "lastNameText";
            lastNameText.Size = new Size(279, 23);
            lastNameText.TabIndex = 2;
            // 
            // windowsUserText
            // 
            windowsUserText.Location = new Point(220, 70);
            windowsUserText.Name = "windowsUserText";
            windowsUserText.Size = new Size(279, 23);
            windowsUserText.TabIndex = 3;
            // 
            // viewCB
            // 
            viewCB.FormattingEnabled = true;
            viewCB.Location = new Point(220, 99);
            viewCB.Name = "viewCB";
            viewCB.Size = new Size(279, 23);
            viewCB.TabIndex = 4;
            // 
            // leaveEntitlementNUD
            // 
            leaveEntitlementNUD.Location = new Point(220, 157);
            leaveEntitlementNUD.Name = "leaveEntitlementNUD";
            leaveEntitlementNUD.Size = new Size(279, 23);
            leaveEntitlementNUD.TabIndex = 5;
            leaveEntitlementNUD.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // remainingLeaveNUD
            // 
            remainingLeaveNUD.Location = new Point(220, 128);
            remainingLeaveNUD.Name = "remainingLeaveNUD";
            remainingLeaveNUD.Size = new Size(279, 23);
            remainingLeaveNUD.TabIndex = 6;
            remainingLeaveNUD.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 7;
            label1.Text = "Vorname";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 49);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 8;
            label2.Text = "Nachname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 78);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 9;
            label3.Text = "Windows User";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 165);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 10;
            label4.Text = "Tarifurlaub";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 107);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 11;
            label5.Text = "View";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 136);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 12;
            label6.Text = "Resturlaub";
            // 
            // NewEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 240);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(remainingLeaveNUD);
            Controls.Add(leaveEntitlementNUD);
            Controls.Add(viewCB);
            Controls.Add(windowsUserText);
            Controls.Add(lastNameText);
            Controls.Add(firstNameText);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "NewEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Neuer Mitarbeiter";
            ((System.ComponentModel.ISupportInitialize)leaveEntitlementNUD).EndInit();
            ((System.ComponentModel.ISupportInitialize)remainingLeaveNUD).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox firstNameText;
        private TextBox lastNameText;
        private TextBox windowsUserText;
        private ComboBox viewCB;
        private NumericUpDown leaveEntitlementNUD;
        private NumericUpDown remainingLeaveNUD;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}