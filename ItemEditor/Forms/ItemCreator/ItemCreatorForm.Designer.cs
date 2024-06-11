namespace ItemEditor.Forms.ItemCreator
{
    partial class ItemCreatorForm
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ItemExtPathButton = new System.Windows.Forms.Button();
            this.ItemOrgPathButton = new System.Windows.Forms.Button();
            this.ItemOrgDialog = new System.Windows.Forms.OpenFileDialog();
            this.ItemExtDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.AutoScroll = true;
            this.MainPanel.AutoSize = true;
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(800, 450);
            this.MainPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ItemExtPathButton);
            this.panel1.Controls.Add(this.ItemOrgPathButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(157, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(349, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Fill Required Information To Continue";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 29);
            this.button1.TabIndex = 17;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "label1";
            // 
            // ItemExtPathButton
            // 
            this.ItemExtPathButton.Location = new System.Drawing.Point(157, 169);
            this.ItemExtPathButton.Name = "ItemExtPathButton";
            this.ItemExtPathButton.Size = new System.Drawing.Size(147, 29);
            this.ItemExtPathButton.TabIndex = 14;
            this.ItemExtPathButton.Text = "Set Item Ext Path";
            this.ItemExtPathButton.UseVisualStyleBackColor = true;
            this.ItemExtPathButton.Click += new System.EventHandler(this.ItemExtPathButton_Click);
            // 
            // ItemOrgPathButton
            // 
            this.ItemOrgPathButton.Location = new System.Drawing.Point(157, 116);
            this.ItemOrgPathButton.Name = "ItemOrgPathButton";
            this.ItemOrgPathButton.Size = new System.Drawing.Size(147, 29);
            this.ItemOrgPathButton.TabIndex = 13;
            this.ItemOrgPathButton.Text = "Set Item Org Path";
            this.ItemOrgPathButton.UseVisualStyleBackColor = true;
            this.ItemOrgPathButton.Click += new System.EventHandler(this.ItemOrgPathButton_Click);
            // 
            // ItemOrgDialog
            // 
            this.ItemOrgDialog.FileName = "ItemOrgDialog";
            // 
            // ItemExtDialog
            // 
            this.ItemExtDialog.FileName = "ItemExtDialog";
            // 
            // ItemCreatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MainPanel);
            this.Name = "ItemCreatorForm";
            this.Text = "ItemTableForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel MainPanel;
        private Panel panel1;
        private Label label4;
        private Button button1;
        private Label label2;
        private Label label1;
        private Button ItemExtPathButton;
        private Button ItemOrgPathButton;
        private OpenFileDialog ItemOrgDialog;
        private OpenFileDialog ItemExtDialog;
    }
}