namespace AP2024
{
    partial class AddFlextime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFlextime));
            label1 = new Label();
            NUDFlextime = new NumericUpDown();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            checkBox1 = new CheckBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)NUDFlextime).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 65);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 0;
            label1.Text = "Meine Gleitzeit";
            // 
            // NUDFlextime
            // 
            NUDFlextime.DecimalPlaces = 2;
            NUDFlextime.Location = new Point(211, 65);
            NUDFlextime.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            NUDFlextime.Name = "NUDFlextime";
            NUDFlextime.Size = new Size(223, 23);
            NUDFlextime.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(211, 94);
            button1.Name = "button1";
            button1.Size = new Size(59, 30);
            button1.TabIndex = 2;
            button1.Text = "+1 h";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(211, 130);
            button2.Name = "button2";
            button2.Size = new Size(59, 30);
            button2.TabIndex = 3;
            button2.Text = "-1 h";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(276, 130);
            button3.Name = "button3";
            button3.Size = new Size(59, 30);
            button3.TabIndex = 5;
            button3.Text = "-0.1 h";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(276, 94);
            button4.Name = "button4";
            button4.Size = new Size(59, 30);
            button4.TabIndex = 4;
            button4.Text = "+0.1 h";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(341, 130);
            button5.Name = "button5";
            button5.Size = new Size(59, 30);
            button5.TabIndex = 7;
            button5.Text = "-0.01 h";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(341, 94);
            button6.Name = "button6";
            button6.Size = new Size(59, 30);
            button6.TabIndex = 6;
            button6.Text = "+0.01 h";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.Location = new Point(333, 215);
            button7.Name = "button7";
            button7.Size = new Size(101, 37);
            button7.TabIndex = 8;
            button7.Text = "Speichern";
            button7.TextImageRelation = TextImageRelation.ImageBeforeText;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(211, 25);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 9;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 24);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 10;
            label2.Text = "Gleitzeit verwenden";
            // 
            // AddFlextime
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 264);
            Controls.Add(label2);
            Controls.Add(checkBox1);
            Controls.Add(button7);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(NUDFlextime);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AddFlextime";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Meine Gleitzeit";
            ((System.ComponentModel.ISupportInitialize)NUDFlextime).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown NUDFlextime;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private CheckBox checkBox1;
        private Label label2;
    }
}