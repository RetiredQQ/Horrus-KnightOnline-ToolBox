namespace ItemEditor.Forms.TableEditor
{
    public class ColumnCreationForm : Form
    {
        private ComboBox comboBoxDataTypes;
        private Label label1;
        private Button buttonOK;
        private Button buttonCancel;
        private TextBox textBoxDefaultValue;
        private Label label2;
        /// <summary>
        /// Required designer variable.
        /// </summary>

        public ColumnCreationForm()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxDataTypes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxDefaultValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxDataTypes
            // 
            this.comboBoxDataTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDataTypes.Items.AddRange(new object[] {
            "Float",
            "String",
            "UInt32",
            "Int32",
            "Int16",
            "Byte",
            "SByte"});
            this.comboBoxDataTypes.Location = new System.Drawing.Point(156, 12);
            this.comboBoxDataTypes.Name = "comboBoxDataTypes";
            this.comboBoxDataTypes.Size = new System.Drawing.Size(202, 28);
            this.comboBoxDataTypes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data Type:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(212, 123);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(136, 49);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK";
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(22, 123);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(134, 49);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxDefaultValue
            // 
            this.textBoxDefaultValue.Location = new System.Drawing.Point(156, 61);
            this.textBoxDefaultValue.Name = "textBoxDefaultValue";
            this.textBoxDefaultValue.Size = new System.Drawing.Size(202, 27);
            this.textBoxDefaultValue.TabIndex = 4;
            this.textBoxDefaultValue.Text = "0";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 38);
            this.label2.TabIndex = 5;
            this.label2.Text = "Default Value:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ColumnCreationForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 20);
            this.ClientSize = new System.Drawing.Size(387, 192);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDefaultValue);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxDataTypes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ColumnCreationForm";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Column Properties";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ColumnCreationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private void ColumnCreationForm_Load(object sender, EventArgs e)
        {
            comboBoxDataTypes.SelectedIndex = 3;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }

        public int DataTypeIndex
        {
            get
            {
                return comboBoxDataTypes.SelectedIndex;
            }
        }

        public string DataDefaultValue
        {
            get
            {
                return textBoxDefaultValue.Text;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Hide();
        }
    }
}
