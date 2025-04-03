namespace AP2024
{
    partial class ViewManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewManager));
            viewList = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // viewList
            // 
            viewList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            viewList.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            viewList.Location = new Point(12, 12);
            viewList.Name = "viewList";
            viewList.Size = new Size(1029, 443);
            viewList.TabIndex = 0;
            viewList.UseCompatibleStateImageBehavior = false;
            viewList.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "View Name";
            columnHeader1.Width = 510;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "SuperView";
            columnHeader2.Width = 510;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(966, 461);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Löschen";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.Location = new Point(885, 461);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Bearbeiten";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button3.Location = new Point(885, 490);
            button3.Name = "button3";
            button3.Size = new Size(156, 23);
            button3.TabIndex = 3;
            button3.Text = "Neues View";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button4.Location = new Point(12, 461);
            button4.Name = "button4";
            button4.Size = new Size(156, 23);
            button4.TabIndex = 4;
            button4.Text = "SuperViews verwalten";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // ViewManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 526);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(viewList);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ViewManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "View Manager";
            FormClosing += ViewManager_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private ListView viewList;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
    }
}