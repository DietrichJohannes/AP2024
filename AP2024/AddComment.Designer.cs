namespace AP2024
{
    partial class AddComment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddComment));
            comment_richText = new RichTextBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // comment_richText
            // 
            comment_richText.Location = new Point(12, 25);
            comment_richText.Name = "comment_richText";
            comment_richText.Size = new Size(401, 177);
            comment_richText.TabIndex = 0;
            comment_richText.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 8);
            label1.Name = "label1";
            label1.Size = new Size(160, 15);
            label1.TabIndex = 1;
            label1.Text = "Kommentar zur Abwesenheit";
            // 
            // button1
            // 
            button1.Location = new Point(338, 208);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Speichern";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AddComment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 243);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(comment_richText);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AddComment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kommentar hinzufügen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox comment_richText;
        private Label label1;
        private Button button1;
    }
}