namespace ItemEditor.Forms.ItemCreator
{
    partial class DataItemForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LoadExtButton = new System.Windows.Forms.Button();
            this.RestoreStartFormButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RestoreStartFormButton);
            this.panel1.Controls.Add(this.LoadExtButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 63);
            this.panel1.TabIndex = 0;
            // 
            // LoadExtButton
            // 
            this.LoadExtButton.Location = new System.Drawing.Point(22, 21);
            this.LoadExtButton.Name = "LoadExtButton";
            this.LoadExtButton.Size = new System.Drawing.Size(131, 29);
            this.LoadExtButton.TabIndex = 0;
            this.LoadExtButton.Text = "Load Ext Table";
            this.LoadExtButton.UseVisualStyleBackColor = true;
            this.LoadExtButton.Click += new System.EventHandler(this.LoadExtButton_Click);
            // 
            // RestoreStartFormButton
            // 
            this.RestoreStartFormButton.Location = new System.Drawing.Point(207, 21);
            this.RestoreStartFormButton.Name = "RestoreStartFormButton";
            this.RestoreStartFormButton.Size = new System.Drawing.Size(139, 29);
            this.RestoreStartFormButton.TabIndex = 1;
            this.RestoreStartFormButton.Text = "Go To Start Page";
            this.RestoreStartFormButton.UseVisualStyleBackColor = true;
            this.RestoreStartFormButton.Click += new System.EventHandler(this.RestoreStartFormButton_Click);
            // 
            // DataItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "DataItemForm";
            this.Text = "Table Editor - Data item";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button LoadExtButton;
        private Button RestoreStartFormButton;
    }
}