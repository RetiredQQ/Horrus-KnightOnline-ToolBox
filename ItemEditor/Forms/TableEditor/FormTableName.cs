using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ItemEditor.Forms.TableEditor
{
    public partial class FormTableName : Form
    {
        private TextBox textBoxTableName;

        private Button buttonOK;

        private Button buttonCancel;

        private Label labelTableName;

        private CheckBox checkBoxSpecifyColumns;

        private TextBox textBoxColumnNames;

        public string TableName
        {
            get
            {
                return this.textBoxTableName.Text;
            }
            set
            {
                this.textBoxTableName.Text = value;
            }
        }

        public bool UseColumnNames
        {
            get
            {
                return this.checkBoxSpecifyColumns.Checked;
            }
            set
            {
                this.checkBoxSpecifyColumns.Checked = value;
            }
        }

        public string ColumnNameString
        {
            get
            {
                return this.textBoxColumnNames.Text;
            }
            set
            {
                this.textBoxColumnNames.Text = value;
            }
        }

        public FormTableName()
        {
            this.InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            base.DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            base.DialogResult = DialogResult.Cancel;
        }

        private void checkBoxSpecifyColumns_CheckedChanged(object sender, EventArgs e)
        {
            this.textBoxColumnNames.Enabled = this.checkBoxSpecifyColumns.Checked;
        }
        private void InitializeComponent()
        {
            this.textBoxTableName = new TextBox();
            this.buttonOK = new Button();
            this.buttonCancel = new Button();
            this.labelTableName = new Label();
            this.checkBoxSpecifyColumns = new CheckBox();
            this.textBoxColumnNames = new TextBox();
            base.SuspendLayout();
            this.textBoxTableName.Location = new Point(86, 12);
            this.textBoxTableName.Name = "textBoxTableName";
            this.textBoxTableName.Size = new Size(187, 20);
            this.textBoxTableName.TabIndex = 0;
            this.buttonOK.Location = new Point(178, 70);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new Size(75, 29);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += this.buttonOK_Click;
            this.buttonCancel.Location = new Point(32, 70);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new Size(75, 29);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += this.buttonCancel_Click;
            this.labelTableName.AutoSize = true;
            this.labelTableName.Location = new Point(12, 15);
            this.labelTableName.Name = "labelTableName";
            this.labelTableName.Size = new Size(68, 13);
            this.labelTableName.TabIndex = 3;
            this.labelTableName.Text = "Table Name:";
            this.checkBoxSpecifyColumns.AutoSize = true;
            this.checkBoxSpecifyColumns.Location = new Point(12, 40);
            this.checkBoxSpecifyColumns.Name = "checkBoxSpecifyColumns";
            this.checkBoxSpecifyColumns.Size = new Size(69, 17);
            this.checkBoxSpecifyColumns.TabIndex = 4;
            this.checkBoxSpecifyColumns.Text = "Columns:";
            this.checkBoxSpecifyColumns.UseVisualStyleBackColor = true;
            this.checkBoxSpecifyColumns.CheckedChanged += this.checkBoxSpecifyColumns_CheckedChanged;
            this.textBoxColumnNames.Enabled = false;
            this.textBoxColumnNames.Location = new Point(87, 38);
            this.textBoxColumnNames.Name = "textBoxColumnNames";
            this.textBoxColumnNames.Size = new Size(186, 20);
            this.textBoxColumnNames.TabIndex = 5;
            this.textBoxColumnNames.Text = "Column1, Column2, Column3";
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(285, 113);
            base.ControlBox = false;
            base.Controls.Add(this.textBoxColumnNames);
            base.Controls.Add(this.checkBoxSpecifyColumns);
            base.Controls.Add(this.labelTableName);
            base.Controls.Add(this.buttonCancel);
            base.Controls.Add(this.buttonOK);
            base.Controls.Add(this.textBoxTableName);
            base.FormBorderStyle = FormBorderStyle.FixedSingle;
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "FormTableName";
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            this.Text = "Table Name";
            base.ResumeLayout(false);
            base.PerformLayout();
        }
    }
}
