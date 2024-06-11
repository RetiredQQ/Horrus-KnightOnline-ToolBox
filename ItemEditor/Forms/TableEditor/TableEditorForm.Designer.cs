namespace ItemEditor.Forms.TableEditor
{
    partial class TableEditorForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.exportToSQLInsertQueryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newRowAtCourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newColumnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.deketeSelectedColumnsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSelectedRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.pasteRowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripFileNametextbox = new System.Windows.Forms.ToolStripTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.IsSubString = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RowStateComboBox = new System.Windows.Forms.ComboBox();
            this.filterColumn = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.FillterOutButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogExportSql = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(800, 333);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.HandleDragDrop);
            this.dataGridView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.HandleDragEnter);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolStripFileNametextbox});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 31);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripMenuItem2,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem3,
            this.exportToSQLInsertQueryToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 27);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(263, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.saveAsToolStripMenuItem.Text = "Save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(263, 6);
            // 
            // exportToSQLInsertQueryToolStripMenuItem
            // 
            this.exportToSQLInsertQueryToolStripMenuItem.Name = "exportToSQLInsertQueryToolStripMenuItem";
            this.exportToSQLInsertQueryToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.exportToSQLInsertQueryToolStripMenuItem.Text = "&Export to SQL Insert Query";
            this.exportToSQLInsertQueryToolStripMenuItem.Click += new System.EventHandler(this.exportToSQLInsertQueryToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newRowAtCourToolStripMenuItem,
            this.newColumnToolStripMenuItem,
            this.toolStripMenuItem5,
            this.deketeSelectedColumnsToolStripMenuItem,
            this.deleteSelectedRowToolStripMenuItem,
            this.toolStripMenuItem1,
            this.pasteRowsToolStripMenuItem,
            this.copyRowToolStripMenuItem,
            this.toolStripMenuItem4,
            this.findToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 27);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // newRowAtCourToolStripMenuItem
            // 
            this.newRowAtCourToolStripMenuItem.Name = "newRowAtCourToolStripMenuItem";
            this.newRowAtCourToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.newRowAtCourToolStripMenuItem.Text = "New row at Cursor";
            this.newRowAtCourToolStripMenuItem.Click += new System.EventHandler(this.newRowAtCourToolStripMenuItem_Click);
            // 
            // newColumnToolStripMenuItem
            // 
            this.newColumnToolStripMenuItem.Name = "newColumnToolStripMenuItem";
            this.newColumnToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.newColumnToolStripMenuItem.Text = "New Column";
            this.newColumnToolStripMenuItem.Click += new System.EventHandler(this.newColumnToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(265, 6);
            // 
            // deketeSelectedColumnsToolStripMenuItem
            // 
            this.deketeSelectedColumnsToolStripMenuItem.Enabled = false;
            this.deketeSelectedColumnsToolStripMenuItem.Name = "deketeSelectedColumnsToolStripMenuItem";
            this.deketeSelectedColumnsToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.deketeSelectedColumnsToolStripMenuItem.Text = "Delete Selected Column(s)";
            this.deketeSelectedColumnsToolStripMenuItem.Click += new System.EventHandler(this.deleteSelectedColumnsToolStripMenuItem_Click);
            // 
            // deleteSelectedRowToolStripMenuItem
            // 
            this.deleteSelectedRowToolStripMenuItem.Name = "deleteSelectedRowToolStripMenuItem";
            this.deleteSelectedRowToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.deleteSelectedRowToolStripMenuItem.Text = "Delete Selected Row(s)";
            this.deleteSelectedRowToolStripMenuItem.Click += new System.EventHandler(this.deleteSelectedRowToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(265, 6);
            // 
            // pasteRowsToolStripMenuItem
            // 
            this.pasteRowsToolStripMenuItem.Name = "pasteRowsToolStripMenuItem";
            this.pasteRowsToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.pasteRowsToolStripMenuItem.Text = "Paste Row(s)";
            this.pasteRowsToolStripMenuItem.Click += new System.EventHandler(this.pasteRowsToolStripMenuItem_Click);
            // 
            // copyRowToolStripMenuItem
            // 
            this.copyRowToolStripMenuItem.Name = "copyRowToolStripMenuItem";
            this.copyRowToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.copyRowToolStripMenuItem.Text = "Copy Row(s)";
            this.copyRowToolStripMenuItem.Click += new System.EventHandler(this.copyRowToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(265, 6);
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.findToolStripMenuItem.Text = "Find";
            this.findToolStripMenuItem.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
            // 
            // toolStripFileNametextbox
            // 
            this.toolStripFileNametextbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toolStripFileNametextbox.Name = "toolStripFileNametextbox";
            this.toolStripFileNametextbox.ReadOnly = true;
            this.toolStripFileNametextbox.Size = new System.Drawing.Size(300, 27);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.IsSubString);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.RowStateComboBox);
            this.panel1.Controls.Add(this.filterColumn);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.textBoxFilter);
            this.panel1.Controls.Add(this.FillterOutButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 86);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Filter by column";
            // 
            // IsSubString
            // 
            this.IsSubString.AutoSize = true;
            this.IsSubString.Location = new System.Drawing.Point(364, 52);
            this.IsSubString.Name = "IsSubString";
            this.IsSubString.Size = new System.Drawing.Size(107, 24);
            this.IsSubString.TabIndex = 7;
            this.IsSubString.Text = "Is Substring";
            this.IsSubString.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Show Only (TODO):";
            // 
            // RowStateComboBox
            // 
            this.RowStateComboBox.Enabled = false;
            this.RowStateComboBox.FormattingEnabled = true;
            this.RowStateComboBox.Location = new System.Drawing.Point(166, 48);
            this.RowStateComboBox.Name = "RowStateComboBox";
            this.RowStateComboBox.Size = new System.Drawing.Size(151, 28);
            this.RowStateComboBox.TabIndex = 5;
            this.RowStateComboBox.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // filterColumn
            // 
            this.filterColumn.FormattingEnabled = true;
            this.filterColumn.Location = new System.Drawing.Point(133, 7);
            this.filterColumn.Name = "filterColumn";
            this.filterColumn.Size = new System.Drawing.Size(185, 28);
            this.filterColumn.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(495, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "Reset Filter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ResetDataGridFilter_Click);
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Location = new System.Drawing.Point(364, 10);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(125, 27);
            this.textBoxFilter.TabIndex = 1;
            // 
            // FillterOutButton
            // 
            this.FillterOutButton.Location = new System.Drawing.Point(495, 8);
            this.FillterOutButton.Name = "FillterOutButton";
            this.FillterOutButton.Size = new System.Drawing.Size(94, 29);
            this.FillterOutButton.TabIndex = 0;
            this.FillterOutButton.Text = "Filter Out";
            this.FillterOutButton.UseVisualStyleBackColor = true;
            this.FillterOutButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // TableEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TableEditorForm";
            this.Text = "TableEditorForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem newRowAtCourToolStripMenuItem;
        private ToolStripMenuItem newColumnToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem findToolStripMenuItem;
        private Panel panel1;
        private TextBox textBoxFilter;
        private Button FillterOutButton;
        private Button button2;
        private ComboBox filterColumn;
        private ComboBox RowStateComboBox;
        private Label label1;
        private CheckBox IsSubString;
        private ToolStripMenuItem openToolStripMenuItem;
        private Label label2;
        private OpenFileDialog openFileDialog;
        private ToolStripMenuItem exportToSQLInsertQueryToolStripMenuItem;
        private SaveFileDialog saveFileDialogExportSql;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem copyRowToolStripMenuItem;
        private ToolStripMenuItem pasteRowsToolStripMenuItem;
        private ToolStripMenuItem deketeSelectedColumnsToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem5;
        private ToolStripSeparator toolStripMenuItem4;
        private ToolStripMenuItem deleteSelectedRowToolStripMenuItem;
        public DataGridView dataGridView1;
        private ToolStripTextBox toolStripFileNametextbox;
    }
}