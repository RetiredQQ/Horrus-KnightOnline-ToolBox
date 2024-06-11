namespace ItemEditor.Forms.TableEditor
{
    partial class SaveAsForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.cbEncryptionList = new System.Windows.Forms.ComboBox();
            this.lblMethod = new System.Windows.Forms.Label();
            this.meDescription = new ItemEditor.ExternalControl.DisabledRichTextBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(43, 163);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save as";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbEncryptionList
            // 
            this.cbEncryptionList.FormattingEnabled = true;
            this.cbEncryptionList.Location = new System.Drawing.Point(151, 31);
            this.cbEncryptionList.Name = "cbEncryptionList";
            this.cbEncryptionList.Size = new System.Drawing.Size(151, 28);
            this.cbEncryptionList.TabIndex = 1;
            this.cbEncryptionList.SelectedIndexChanged += new System.EventHandler(this.cbEncryptionList_SelectedIndexChanged);
            // 
            // lblMethod
            // 
            this.lblMethod.AutoSize = true;
            this.lblMethod.Location = new System.Drawing.Point(42, 34);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(72, 20);
            this.lblMethod.TabIndex = 2;
            this.lblMethod.Text = "Method : ";
            // 
            // meDescription
            // 
            this.meDescription.Location = new System.Drawing.Point(42, 83);
            this.meDescription.Name = "meDescription";
            this.meDescription.Size = new System.Drawing.Size(269, 55);
            this.meDescription.TabIndex = 4;
            this.meDescription.Text = "";
            // 
            // SaveAsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 238);
            this.Controls.Add(this.meDescription);
            this.Controls.Add(this.lblMethod);
            this.Controls.Add(this.cbEncryptionList);
            this.Controls.Add(this.btnSave);
            this.Name = "SaveAsForm";
            this.Text = "SaveAsForm";
            this.Load += new System.EventHandler(this.SaveAsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSave;
        private ComboBox cbEncryptionList;
        private Label lblMethod;
        private ExternalControl.DisabledRichTextBox meDescription;
    }
}