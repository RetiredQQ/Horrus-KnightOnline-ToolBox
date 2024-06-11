namespace ItemEditor.Forms.ItemCreator
{
    partial class ItemDatabaseFieldsForm
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
            this.DatabaseItemPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.isExtOnly = new System.Windows.Forms.CheckBox();
            this.PrepareDbInsertButton = new System.Windows.Forms.Button();
            this.InsertIntoDbButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.ContinueToItemOrgButton = new System.Windows.Forms.Button();
            this.DatabaseItemPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DatabaseItemPanel
            // 
            this.DatabaseItemPanel.AutoScroll = true;
            this.DatabaseItemPanel.Controls.Add(this.panel2);
            this.DatabaseItemPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DatabaseItemPanel.Location = new System.Drawing.Point(0, 0);
            this.DatabaseItemPanel.MinimumSize = new System.Drawing.Size(0, 500);
            this.DatabaseItemPanel.Name = "DatabaseItemPanel";
            this.DatabaseItemPanel.Size = new System.Drawing.Size(779, 500);
            this.DatabaseItemPanel.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 470);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(779, 30);
            this.panel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.isExtOnly);
            this.panel1.Controls.Add(this.PrepareDbInsertButton);
            this.panel1.Controls.Add(this.InsertIntoDbButton);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.ContinueToItemOrgButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 500);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 291);
            this.panel1.TabIndex = 1;
            // 
            // isExtOnly
            // 
            this.isExtOnly.AutoSize = true;
            this.isExtOnly.Location = new System.Drawing.Point(616, 18);
            this.isExtOnly.Name = "isExtOnly";
            this.isExtOnly.Size = new System.Drawing.Size(102, 24);
            this.isExtOnly.TabIndex = 4;
            this.isExtOnly.Text = "Is EXT only";
            this.isExtOnly.UseVisualStyleBackColor = true;
            // 
            // PrepareDbInsertButton
            // 
            this.PrepareDbInsertButton.Location = new System.Drawing.Point(12, 15);
            this.PrepareDbInsertButton.Name = "PrepareDbInsertButton";
            this.PrepareDbInsertButton.Size = new System.Drawing.Size(127, 29);
            this.PrepareDbInsertButton.TabIndex = 3;
            this.PrepareDbInsertButton.Text = "Prepare DB Insert";
            this.PrepareDbInsertButton.UseVisualStyleBackColor = true;
            this.PrepareDbInsertButton.Click += new System.EventHandler(this.PrepareDbInsertButton_Click);
            // 
            // InsertIntoDbButton
            // 
            this.InsertIntoDbButton.Location = new System.Drawing.Point(405, 13);
            this.InsertIntoDbButton.Name = "InsertIntoDbButton";
            this.InsertIntoDbButton.Size = new System.Drawing.Size(127, 29);
            this.InsertIntoDbButton.TabIndex = 2;
            this.InsertIntoDbButton.Text = "Insert Into DB";
            this.InsertIntoDbButton.UseVisualStyleBackColor = true;
            this.InsertIntoDbButton.Click += new System.EventHandler(this.ExecuteInsertIntoItemTableDb_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 54);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(520, 160);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.WordWrap = false;
            // 
            // ContinueToItemOrgButton
            // 
            this.ContinueToItemOrgButton.Location = new System.Drawing.Point(616, 174);
            this.ContinueToItemOrgButton.Name = "ContinueToItemOrgButton";
            this.ContinueToItemOrgButton.Size = new System.Drawing.Size(127, 29);
            this.ContinueToItemOrgButton.TabIndex = 0;
            this.ContinueToItemOrgButton.Text = "Next";
            this.ContinueToItemOrgButton.UseVisualStyleBackColor = true;
            this.ContinueToItemOrgButton.Click += new System.EventHandler(this.ContinueToItemOrgButton_Click);
            // 
            // ItemDatabaseFieldsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 771);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DatabaseItemPanel);
            this.Name = "ItemDatabaseFieldsForm";
            this.Text = "ItemDatabaseFieldsForm";
            this.DatabaseItemPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel DatabaseItemPanel;
        private Panel panel1;
        private Button ContinueToItemOrgButton;
        private Button InsertIntoDbButton;
        private RichTextBox richTextBox1;
        private Button PrepareDbInsertButton;
        private CheckBox isExtOnly;
        private Panel panel2;
    }
}