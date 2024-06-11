namespace ItemEditor.CustomControls
{
    partial class DbConnectionControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.InitialCatalogRtb = new System.Windows.Forms.RichTextBox();
            this.PasswordRtb = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UserIdRtb = new System.Windows.Forms.RichTextBox();
            this.DataSourceRtb = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Initial Catalog";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Password";
            // 
            // InitialCatalogRtb
            // 
            this.InitialCatalogRtb.Location = new System.Drawing.Point(139, 156);
            this.InitialCatalogRtb.Name = "InitialCatalogRtb";
            this.InitialCatalogRtb.Size = new System.Drawing.Size(126, 35);
            this.InitialCatalogRtb.TabIndex = 13;
            this.InitialCatalogRtb.Text = "KN_online";
            // 
            // PasswordRtb
            // 
            this.PasswordRtb.Location = new System.Drawing.Point(139, 115);
            this.PasswordRtb.Name = "PasswordRtb";
            this.PasswordRtb.Size = new System.Drawing.Size(126, 35);
            this.PasswordRtb.TabIndex = 12;
            this.PasswordRtb.Text = "knight";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "User Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Data Source";
            // 
            // UserIdRtb
            // 
            this.UserIdRtb.Location = new System.Drawing.Point(139, 74);
            this.UserIdRtb.Name = "UserIdRtb";
            this.UserIdRtb.Size = new System.Drawing.Size(126, 35);
            this.UserIdRtb.TabIndex = 9;
            this.UserIdRtb.Text = "knight";
            // 
            // DataSourceRtb
            // 
            this.DataSourceRtb.Location = new System.Drawing.Point(139, 33);
            this.DataSourceRtb.Name = "DataSourceRtb";
            this.DataSourceRtb.Size = new System.Drawing.Size(126, 35);
            this.DataSourceRtb.TabIndex = 8;
            this.DataSourceRtb.Text = "(local)";
            // 
            // DbConnectionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.InitialCatalogRtb);
            this.Controls.Add(this.PasswordRtb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserIdRtb);
            this.Controls.Add(this.DataSourceRtb);
            this.Name = "DbConnectionControl";
            this.Size = new System.Drawing.Size(317, 231);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private Label label4;
        public RichTextBox InitialCatalogRtb;
        public RichTextBox PasswordRtb;
        private Label label2;
        private Label label1;
        public RichTextBox UserIdRtb;
        public RichTextBox DataSourceRtb;
    }
}
