using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ItemEditor.Forms.TableEditor
{
    public partial class FindAndReplaceForm : Form
    {
        private DataGridView dataGridView;

        private Label label1;

        private TextBox textBoxFindText;

        private Button buttonFind;

        private Button buttonCancel;

        private GroupBox groupBoxDirection;

        private RadioButton radioButtonDown;

        private RadioButton radioButtonUp;

        private CheckBox checkBoxMatchCase;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public FindAndReplaceForm(DataGridView view)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            this.dataGridView = view;
            this.InitializeComponent();
        }

        private void textBoxFindText_TextChanged(object sender, EventArgs e)
        {
            if (this.textBoxFindText.Text.Length > 0)
            {
                this.buttonFind.Enabled = true;
            }
            else
            {
                this.buttonFind.Enabled = false;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            base.DialogResult = DialogResult.Cancel;
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            int num = 0;
            int num2 = 0;
            bool flag = false;
            string text = this.textBoxFindText.Text;
            if (!this.checkBoxMatchCase.Checked)
            {
                text = text.ToLower();
            }
            num = this.dataGridView.CurrentCell.RowIndex;
            num2 = this.dataGridView.CurrentCell.ColumnIndex;
            num2 += ((!this.radioButtonUp.Checked) ? 1 : (-1));
            for (; num >= 0 && num < this.dataGridView.Rows.Count; num += ((!this.radioButtonUp.Checked) ? 1 : (-1)))
            {
                if (flag)
                {
                    break;
                }
                for (; num2 >= 0 && num2 < this.dataGridView.Columns.Count; num2 += ((!this.radioButtonUp.Checked) ? 1 : (-1)))
                {
                    if (flag)
                    {
                        break;
                    }
                    DataGridViewCell dataGridViewCell = this.dataGridView[num2, num];
                    if (dataGridViewCell.Value != null)
                    {
                        string text2 = dataGridViewCell.Value.ToString();
                        if (!this.checkBoxMatchCase.Checked)
                        {
                            text2 = text2.ToLower();
                        }
                        flag = (text2.IndexOf(text) >= 0);
                    }
                }
                num2 = (flag ? (num2 + (this.radioButtonUp.Checked ? 1 : (-1))) : (this.radioButtonUp.Checked ? (this.dataGridView.Columns.Count - 1) : 0));
            }
            if (flag)
            {
                num += (this.radioButtonUp.Checked ? 1 : (-1));
                this.dataGridView.CurrentCell = this.dataGridView[num2, num];
            }
            else if (this.radioButtonUp.Checked)
            {
                MessageBox.Show("Reached the beginning of the data");
            }
            else
            {
                MessageBox.Show("Reached the end of the data");
            }
        }

        private void textBoxFindText_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Return || e.KeyCode == Keys.Return) && this.textBoxFindText.Text.Length > 0)
            {
                e.Handled = true;
                this.buttonFind_Click(this.buttonFind, new EventArgs());
            }
            if (e.KeyCode == Keys.Escape)
            {
                base.DialogResult = DialogResult.Cancel;
                e.Handled = true;
            }
        }

        private void textBoxFindText_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void FormFind_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\r' && e.KeyChar != '\u001b')
            {
                return;
            }
            e.Handled = true;
        }

        private void FormFind_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Return || e.KeyCode == Keys.Return) && this.textBoxFindText.Text.Length > 0)
            {
                e.Handled = true;
                this.buttonFind_Click(this.buttonFind, new EventArgs());
            }
            if (e.KeyCode == Keys.Escape)
            {
                base.DialogResult = DialogResult.Cancel;
                e.Handled = true;
            }
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFindText = new System.Windows.Forms.TextBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxDirection = new System.Windows.Forms.GroupBox();
            this.radioButtonDown = new System.Windows.Forms.RadioButton();
            this.radioButtonUp = new System.Windows.Forms.RadioButton();
            this.checkBoxMatchCase = new System.Windows.Forms.CheckBox();
            this.groupBoxDirection.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find what:";
            // 
            // textBoxFindText
            // 
            this.textBoxFindText.Location = new System.Drawing.Point(99, 17);
            this.textBoxFindText.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFindText.Name = "textBoxFindText";
            this.textBoxFindText.Size = new System.Drawing.Size(263, 22);
            this.textBoxFindText.TabIndex = 1;
            this.textBoxFindText.TextChanged += new System.EventHandler(this.textBoxFindText_TextChanged);
            this.textBoxFindText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFindText_KeyDown);
            this.textBoxFindText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxFindText_KeyUp);
            // 
            // buttonFind
            // 
            this.buttonFind.Enabled = false;
            this.buttonFind.Location = new System.Drawing.Point(371, 15);
            this.buttonFind.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(91, 28);
            this.buttonFind.TabIndex = 2;
            this.buttonFind.Text = "Find Next";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(371, 50);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(91, 28);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // groupBoxDirection
            // 
            this.groupBoxDirection.Controls.Add(this.radioButtonDown);
            this.groupBoxDirection.Controls.Add(this.radioButtonUp);
            this.groupBoxDirection.Location = new System.Drawing.Point(215, 49);
            this.groupBoxDirection.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxDirection.Name = "groupBoxDirection";
            this.groupBoxDirection.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxDirection.Size = new System.Drawing.Size(148, 59);
            this.groupBoxDirection.TabIndex = 4;
            this.groupBoxDirection.TabStop = false;
            this.groupBoxDirection.Text = "Direction";
            // 
            // radioButtonDown
            // 
            this.radioButtonDown.AutoSize = true;
            this.radioButtonDown.Checked = true;
            this.radioButtonDown.Location = new System.Drawing.Point(69, 23);
            this.radioButtonDown.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonDown.Name = "radioButtonDown";
            this.radioButtonDown.Size = new System.Drawing.Size(64, 21);
            this.radioButtonDown.TabIndex = 1;
            this.radioButtonDown.TabStop = true;
            this.radioButtonDown.Text = "Down";
            this.radioButtonDown.UseVisualStyleBackColor = true;
            // 
            // radioButtonUp
            // 
            this.radioButtonUp.AutoSize = true;
            this.radioButtonUp.Location = new System.Drawing.Point(8, 23);
            this.radioButtonUp.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonUp.Name = "radioButtonUp";
            this.radioButtonUp.Size = new System.Drawing.Size(47, 21);
            this.radioButtonUp.TabIndex = 0;
            this.radioButtonUp.Text = "Up";
            this.radioButtonUp.UseVisualStyleBackColor = true;
            // 
            // checkBoxMatchCase
            // 
            this.checkBoxMatchCase.AutoSize = true;
            this.checkBoxMatchCase.Location = new System.Drawing.Point(16, 87);
            this.checkBoxMatchCase.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxMatchCase.Name = "checkBoxMatchCase";
            this.checkBoxMatchCase.Size = new System.Drawing.Size(104, 21);
            this.checkBoxMatchCase.TabIndex = 5;
            this.checkBoxMatchCase.Text = "Match Case";
            this.checkBoxMatchCase.UseVisualStyleBackColor = true;
            // 
            // FormFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 123);
            this.Controls.Add(this.checkBoxMatchCase);
            this.Controls.Add(this.groupBoxDirection);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.textBoxFindText);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFind";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Find";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormFind_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormFind_KeyPress);
            this.groupBoxDirection.ResumeLayout(false);
            this.groupBoxDirection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBoxFindText_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.V))
                (sender as TextBox).Paste();
        }
    }
}
