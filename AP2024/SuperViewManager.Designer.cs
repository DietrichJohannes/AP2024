namespace AP2024
{
    partial class SuperViewManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuperViewManager));
            superviewList = new ListView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            columnHeader1 = new ColumnHeader();
            SuspendLayout();
            // 
            // superviewList
            // 
            superviewList.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            superviewList.Location = new Point(12, 12);
            superviewList.Name = "superviewList";
            superviewList.Size = new Size(718, 268);
            superviewList.TabIndex = 0;
            superviewList.UseCompatibleStateImageBehavior = false;
            superviewList.View = View.Details;
            // 
            // button1
            // 
            button1.Location = new Point(655, 286);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Löschen";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(574, 286);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Bearbeiten";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(574, 315);
            button3.Name = "button3";
            button3.Size = new Size(156, 23);
            button3.TabIndex = 3;
            button3.Text = "Neues SuperView";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "SuperView Name";
            columnHeader1.Width = 710;
            // 
            // SuperViewManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(742, 350);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(superviewList);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SuperViewManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SuperView Manager";
            ResumeLayout(false);
        }

        #endregion

        private ListView superviewList;
        private Button button1;
        private Button button2;
        private Button button3;
        private ColumnHeader columnHeader1;
    }
}