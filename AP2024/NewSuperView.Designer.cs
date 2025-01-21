namespace AP2024
{
    partial class NewSuperView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewSuperView));
            superViewNameText = new TextBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // superViewNameText
            // 
            superViewNameText.Location = new Point(174, 12);
            superViewNameText.Name = "superViewNameText";
            superViewNameText.Size = new Size(263, 23);
            superViewNameText.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 1;
            label1.Text = "SuperView Name";
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
            // NewSuperView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 150);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(superViewNameText);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "NewSuperView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Neues SuperView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox superViewNameText;
        private Label label1;
        private Button button1;
    }
}