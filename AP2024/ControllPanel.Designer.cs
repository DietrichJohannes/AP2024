namespace AP2024
{
    partial class ControllPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControllPanel));
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            label3 = new Label();
            button3 = new Button();
            label4 = new Label();
            button4 = new Button();
            label5 = new Label();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(201, 5);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 1;
            label1.Text = "Kalender neuladen";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 42);
            label2.Name = "label2";
            label2.Size = new Size(114, 15);
            label2.TabIndex = 3;
            label2.Text = "Wochenende färben";
            // 
            // button2
            // 
            button2.Location = new Point(201, 34);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Start";
            button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 100);
            label3.Name = "label3";
            label3.Size = new Size(162, 15);
            label3.TabIndex = 5;
            label3.Text = "Abwesenheitstypen neuladen";
            // 
            // button3
            // 
            button3.Location = new Point(201, 92);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 4;
            button3.Text = "Start";
            button3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 71);
            label4.Name = "label4";
            label4.Size = new Size(107, 15);
            label4.TabIndex = 7;
            label4.Text = "Feiertage neuladen";
            // 
            // button4
            // 
            button4.Location = new Point(201, 63);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 6;
            button4.Text = "Start";
            button4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 129);
            label5.Name = "label5";
            label5.Size = new Size(125, 15);
            label5.TabIndex = 9;
            label5.Text = "Programm Neustarten";
            // 
            // button5
            // 
            button5.Location = new Point(201, 121);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 8;
            button5.Text = "Start";
            button5.UseVisualStyleBackColor = true;
            // 
            // ControllPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(288, 166);
            Controls.Add(label5);
            Controls.Add(button5);
            Controls.Add(label4);
            Controls.Add(button4);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ControllPanel";
            Text = "Entwickler Steuerung";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Button button2;
        private Label label3;
        private Button button3;
        private Label label4;
        private Button button4;
        private Label label5;
        private Button button5;
    }
}