namespace AP2024
{
    partial class NewView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewView));
            viewNameText = new TextBox();
            superViewCB = new ComboBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // viewNameText
            // 
            viewNameText.Location = new Point(174, 12);
            viewNameText.Name = "viewNameText";
            viewNameText.Size = new Size(263, 23);
            viewNameText.TabIndex = 0;
            // 
            // superViewCB
            // 
            superViewCB.FormattingEnabled = true;
            superViewCB.Location = new Point(174, 41);
            superViewCB.Name = "superViewCB";
            superViewCB.Size = new Size(263, 23);
            superViewCB.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(362, 115);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Speichern";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 3;
            label1.Text = "View Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 49);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 4;
            label2.Text = "SuperView";
            // 
            // button2
            // 
            button2.Location = new Point(174, 115);
            button2.Name = "button2";
            button2.Size = new Size(120, 23);
            button2.TabIndex = 5;
            button2.Text = "Neues SuperView";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // NewView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 150);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(superViewCB);
            Controls.Add(viewNameText);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "NewView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Neues View";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox viewNameText;
        private ComboBox superViewCB;
        private Button button1;
        private Label label1;
        private Label label2;
        private Button button2;
    }
}