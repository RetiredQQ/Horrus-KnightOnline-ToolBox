using ItemEditor.Helper;
using ItemEditor.Static;
using System.Data;
using System.Text;
using TableEditor;

namespace ItemEditor.Forms.TableEditor
{
    public partial class TableEditorForm : Form
    {
        private KOTableFile koTableFile;

        private string FullFileName { get; set; }
            
        private DataTable KoDataTable 
        {   get 
            {
                return koTableFile.Table;
            } 
        }

        public TableEditorForm()
        {
            InitializeComponent();
            this.RowStateComboBox.DataSource = Enum.GetValues(typeof(DataViewRowState));
        }

        #region Drag 'n Drop

        private void HandleDragDrop(object sender, DragEventArgs e)
        {
            var data = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (data == null || data.Length == 0)
                return;

            foreach (var s in data)
            {
                OpenFile(s);
            }
        }

        private void HandleDragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        #endregion

        #region File Operation

        public void OpenFile(object ofileName)
        {
            this.filterColumn.Items.Clear();
            this.filterColumn.Text = String.Empty;
            this.filterColumn.SelectedIndex = -1;
            koTableFile = TableEditorHelper.DecodeTableFile(ofileName as string);

            if (koTableFile != null)
            {
                FullFileName = koTableFile.FullName;
                //TableEditorStatic.AddNewTable(koTableFile);
                TableEditorHelper.AddHeadersToDataGriedView(koTableFile, dataGridView1, filterColumn);
                this.toolStripFileNametextbox.Text = koTableFile.FullName;
            }
        }

        private bool SaveFile(string tableName)
        {
            //KOTableFile tbl = TableEditorStatic.GetTableByFullName(tableName);

            if (koTableFile == null)
            {
                MessageBox.Show("Error - No table to save");
                return true;
            }

            koTableFile.Table.AcceptChanges();
            koTableFile.Save(); // save   
            koTableFile.Altered = false;

            CoreServices.Logger.ShowWarning(LanguageManager.Get("Message_SaveSuccess"));
            return true;
        }

        #endregion

        #region Tool Srtip Operations

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.OpenFile(this.openFileDialog.FileName);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SaveFile(this.FullFileName);
        }

        private void newColumnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColumnCreationForm columnCreationOptionsForm = new ColumnCreationForm();
            if (columnCreationOptionsForm.ShowDialog() == DialogResult.OK)
            {
                Type dataType = typeof(int);
                object? defaultValue = null;
                string typeString = "";
                switch (columnCreationOptionsForm.DataTypeIndex)
                {
                    case 0:
                        dataType = typeof(float);
                        defaultValue = Convert.ToSingle(columnCreationOptionsForm.DataDefaultValue);
                        typeString = "Float";
                        break;
                    case 1:
                        dataType = typeof(string);
                        defaultValue = columnCreationOptionsForm.DataDefaultValue;
                        typeString = "String";
                        break;
                    case 2:
                        dataType = typeof(uint);
                        defaultValue = Convert.ToUInt32(columnCreationOptionsForm.DataDefaultValue);
                        typeString = "UInt32";
                        break;
                    case 3:
                        dataType = typeof(int);
                        defaultValue = Convert.ToInt32(columnCreationOptionsForm.DataDefaultValue);
                        typeString = "Int32";
                        break;
                    case 4:
                        dataType = typeof(short);
                        typeString = "Int16";
                        defaultValue = Convert.ToInt16(columnCreationOptionsForm.DataDefaultValue);
                        break;
                    case 5:
                        dataType = typeof(byte);
                        defaultValue = Convert.ToByte(columnCreationOptionsForm.DataDefaultValue, 10);
                        typeString = "Byte";
                        break;
                    case 6:
                        dataType = typeof(sbyte);
                        defaultValue = Convert.ToSByte(columnCreationOptionsForm.DataDefaultValue, 10);
                        typeString = "SByte";
                        break;
                }
                int columnCount = KoDataTable.Columns.Count;
                DataColumn newColumn = new DataColumn(columnCount.ToString() + " - New - " + typeString, dataType);
                newColumn.DefaultValue = defaultValue;
                KoDataTable.Columns.Add(newColumn);
                KoDataTable.AcceptChanges();
            }
        }

        private void newRowAtCourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable theTable = KoDataTable;

            int currentIndex = dataGridView1.CurrentCell.RowIndex;
            DataRow newRow = theTable.NewRow();
            for (int column = 0; column < theTable.Columns.Count; column++)
            {
                newRow[column] = theTable.Columns[column].DefaultValue;
            }
            theTable.Rows.InsertAt(newRow, currentIndex);
            theTable.AcceptChanges();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveAsForm encSelect = new SaveAsForm(koTableFile))
            {
                encSelect.ShowDialog();
            }
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.FullFileName == "" || !File.Exists(this.FullFileName) || KoDataTable == null)
            {
                MessageBox.Show("Error - No table to search");
            }
            else
            {
                if (KoDataTable == null)
                {
                    MessageBox.Show("Error - Main table is null.");
                }
                else
                {
                    new FindAndReplaceForm(this.dataGridView1).ShowDialog();
                }
            }
        }

        private void exportToSQLInsertQueryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.FullFileName == "" || !File.Exists(this.FullFileName) || KoDataTable == null)
            {
                MessageBox.Show("Error - No table to export");
            }
            else
            {
                DataTable dataTable = KoDataTable;
                if (dataTable == null)
                {
                    MessageBox.Show("Error - Main table is null.");
                }
                else if (this.saveFileDialogExportSql.ShowDialog() == DialogResult.OK)
                {
                    using (FormTableName formTableName = new FormTableName())
                    {
                        formTableName.TableName = FullFileName.Substring(FullFileName.LastIndexOf('\\') + 1, FullFileName.LastIndexOf('.') - FullFileName.LastIndexOf('\\') - 1);
                        if (formTableName.ShowDialog() == DialogResult.OK)
                        {
                            using (StreamWriter streamWriter = new StreamWriter(this.saveFileDialogExportSql.FileName, false, Encoding.Unicode))
                            {
                                foreach (DataRow row in dataTable.Rows)
                                {
                                    streamWriter.Write("INSERT INTO " + formTableName.TableName);
                                    if (formTableName.UseColumnNames)
                                    {
                                        streamWriter.Write(" ( " + formTableName.ColumnNameString + " )");
                                    }
                                    streamWriter.Write(" VALUES ( ");
                                    foreach (DataColumn column in dataTable.Columns)
                                    {
                                        string fullName;
                                        if ((fullName = column.DataType.FullName) != null && fullName == "System.String")
                                        {
                                            string text = row[column].ToString();
                                            text = text.Replace("'", "''");
                                            streamWriter.Write("'" + text + "'");
                                        }
                                        else
                                        {
                                            streamWriter.Write(row[column].ToString());
                                        }
                                        if (column.Ordinal != dataTable.Columns.Count - 1)
                                        {
                                            streamWriter.Write(", ");
                                        }
                                    }
                                    streamWriter.WriteLine(" );");
                                }
                                streamWriter.Close();
                            }
                        }
                    }
                }
            }
        }

        private void copyRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow[] array = new DataGridViewRow[this.dataGridView1.SelectedRows.Count];
            this.dataGridView1.SelectedRows.CopyTo(array, 0);
            object[][] array2 = new object[array.Length][];
            for (int i = 0; i < array.Length; i++)
            {
                array2[i] = new object[this.dataGridView1.ColumnCount];
            }
            for (int j = 0; j < array.Length; j++)
            {
                DataRowView dataRowView = array[j].DataBoundItem as DataRowView;
                if (dataRowView != null)
                {
                    Array.Copy(dataRowView.Row.ItemArray, array2[j], array2[j].Length);
                }
            }
            Clipboard.SetDataObject(array2);
        }

        private void pasteRowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.FullFileName == "" || !File.Exists(this.FullFileName) || KoDataTable == null)
            {
                MessageBox.Show("Error - No table to export");
            }
            else
            {
                if (KoDataTable == null)
                {
                    MessageBox.Show("Error - Main table is null.");
                }
                else
                {
                    IDataObject dataObject = Clipboard.GetDataObject();
                    if (dataObject.GetDataPresent(typeof(object[][])))
                    {
                        object[][] array = (object[][])dataObject.GetData(typeof(object[][]));
                        if (array != null)
                        {
                            object[][] array2 = array;
                            foreach (object[] values in array2)
                            {
                                KoDataTable.Rows.Add(values);
                            }
                        }
                    }
                    else if (dataObject.GetDataPresent(typeof(string)))
                    {
                        string text = (string)dataObject.GetData(typeof(string));
                        if (text.Length > 0 && text[0] == '\t')
                        {
                            text = text.Substring(1);
                        }
                        string[] array3 = text.Split(new string[5]
                        {
                            "\r\n\t",
                            "\n\t",
                            "\t",
                            "\r\n",
                            "\n"
                        }, StringSplitOptions.None);
                        if (array3.Length > 1)
                        {
                            if (this.dataGridView1.SelectedCells.Count > 1)
                            {
                                int columnIndex = this.dataGridView1.SelectedCells[0].ColumnIndex;
                                int rowIndex = this.dataGridView1.SelectedCells[0].RowIndex;
                                int columnIndex2 = this.dataGridView1.SelectedCells[0].ColumnIndex;
                                int rowIndex2 = this.dataGridView1.SelectedCells[0].RowIndex;
                                int num = 0;
                                int num2 = 0;
                                for (int j = 0; j < this.dataGridView1.SelectedCells.Count; j++)
                                {
                                    if (this.dataGridView1.SelectedCells[j].RowIndex < rowIndex)
                                    {
                                        rowIndex = this.dataGridView1.SelectedCells[j].RowIndex;
                                    }
                                    if (this.dataGridView1.SelectedCells[j].RowIndex > rowIndex2)
                                    {
                                        rowIndex2 = this.dataGridView1.SelectedCells[j].RowIndex;
                                    }
                                    if (this.dataGridView1.SelectedCells[j].ColumnIndex < columnIndex)
                                    {
                                        columnIndex = this.dataGridView1.SelectedCells[j].ColumnIndex;
                                    }
                                    if (this.dataGridView1.SelectedCells[j].ColumnIndex > columnIndex2)
                                    {
                                        columnIndex2 = this.dataGridView1.SelectedCells[j].ColumnIndex;
                                    }
                                }
                                num = columnIndex2 - columnIndex + 1;
                                num2 = rowIndex2 - rowIndex + 1;
                                for (int k = 0; k < num2 && k * num < array3.Length; k++)
                                {
                                    for (int l = 0; l < num && l + k * num < array3.Length; l++)
                                    {
                                        try
                                        {
                                            switch (KoDataTable.Columns[l + columnIndex].DataType.FullName)
                                            {
                                                case "System.Single":
                                                    KoDataTable.Rows[rowIndex + k][columnIndex + l] = float.Parse(array3[l + k * num]);
                                                    break;
                                                case "System.String":
                                                    KoDataTable.Rows[rowIndex + k][columnIndex + l] = array3[l + k * num];
                                                    break;
                                                case "System.UInt32":
                                                    KoDataTable.Rows[rowIndex + k][columnIndex + l] = uint.Parse(array3[l + k * num]);
                                                    break;
                                                case "System.Int32":
                                                    KoDataTable.Rows[rowIndex + k][columnIndex + l] = int.Parse(array3[l + k * num]);
                                                    break;
                                                case "System.Int16":
                                                    KoDataTable.Rows[rowIndex + k][columnIndex + l] = short.Parse(array3[l + k * num]);
                                                    break;
                                                case "System.Byte":
                                                    KoDataTable.Rows[rowIndex + k][columnIndex + l] = byte.Parse(array3[l + k * num]);
                                                    break;
                                                case "System.SByte":
                                                    KoDataTable.Rows[rowIndex + k][columnIndex + l] = sbyte.Parse(array3[l + k * num]);
                                                    break;
                                                default:
                                                    KoDataTable.Rows[rowIndex + k][columnIndex + l] = int.Parse(array3[l + k * num]);
                                                    break;
                                            }
                                        }
                                        catch (Exception)
                                        {
                                        }
                                    }
                                }
                            }
                            else
                            {
                                int num3 = (array3.Length + KoDataTable.Columns.Count - 1) / KoDataTable.Columns.Count;
                                string[][] array4 = new string[num3][];
                                for (int m = 0; m < num3 && m * KoDataTable.Columns.Count < array3.Length; m++)
                                {
                                    array4[m] = new string[KoDataTable.Columns.Count];
                                    for (int n = 0; n < KoDataTable.Columns.Count && m * KoDataTable.Columns.Count + n < array3.Length; n++)
                                    {
                                        array4[m][n] = array3[m * KoDataTable.Columns.Count + n];
                                    }
                                }
                                string[][] array5 = array4;
                                foreach (string[] array6 in array5)
                                {
                                    object[] array7 = new object[array6.Length];
                                    for (int num5 = 0; num5 < array6.Length; num5++)
                                    {
                                        try
                                        {
                                            switch (KoDataTable.Columns[num5].DataType.FullName)
                                            {
                                                case "System.Single":
                                                    array7[num5] = float.Parse(array6[num5]);
                                                    break;
                                                case "System.String":
                                                    array7[num5] = array6[num5];
                                                    break;
                                                case "System.UInt32":
                                                    array7[num5] = uint.Parse(array6[num5]);
                                                    break;
                                                case "System.Int32":
                                                    array7[num5] = int.Parse(array6[num5]);
                                                    break;
                                                case "System.Int16":
                                                    array7[num5] = short.Parse(array6[num5]);
                                                    break;
                                                case "System.Byte":
                                                    array7[num5] = byte.Parse(array6[num5]);
                                                    break;
                                                case "System.SByte":
                                                    array7[num5] = sbyte.Parse(array6[num5]);
                                                    break;
                                                default:
                                                    array7[num5] = int.Parse(array6[num5]);
                                                    break;
                                            }
                                        }
                                        catch (Exception)
                                        {
                                        }
                                    }
                                    KoDataTable.Rows.Add(array7);
                                }
                            }
                        }
                        else if (this.dataGridView1.SelectedCells.Count > 0)
                        {
                            try
                            {
                                switch (KoDataTable.Columns[this.dataGridView1.SelectedCells[0].ColumnIndex].DataType.FullName)
                                {
                                    case "System.Single":
                                        KoDataTable.Rows[this.dataGridView1.SelectedCells[0].RowIndex][this.dataGridView1.SelectedCells[0].ColumnIndex] = float.Parse(array3[0]);
                                        break;
                                    case "System.String":
                                        KoDataTable.Rows[this.dataGridView1.SelectedCells[0].RowIndex][this.dataGridView1.SelectedCells[0].ColumnIndex] = array3[0];
                                        break;
                                    case "System.UInt32":
                                        KoDataTable.Rows[this.dataGridView1.SelectedCells[0].RowIndex][this.dataGridView1.SelectedCells[0].ColumnIndex] = uint.Parse(array3[0]);
                                        break;
                                    case "System.Int32":
                                        KoDataTable.Rows[this.dataGridView1.SelectedCells[0].RowIndex][this.dataGridView1.SelectedCells[0].ColumnIndex] = int.Parse(array3[0]);
                                        break;
                                    case "System.Int16":
                                        KoDataTable.Rows[this.dataGridView1.SelectedCells[0].RowIndex][this.dataGridView1.SelectedCells[0].ColumnIndex] = short.Parse(array3[0]);
                                        break;
                                    case "System.Byte":
                                        KoDataTable.Rows[this.dataGridView1.SelectedCells[0].RowIndex][this.dataGridView1.SelectedCells[0].ColumnIndex] = byte.Parse(array3[0]);
                                        break;
                                    case "System.SByte":
                                        KoDataTable.Rows[this.dataGridView1.SelectedCells[0].RowIndex][this.dataGridView1.SelectedCells[0].ColumnIndex] = sbyte.Parse(array3[0]);
                                        break;
                                    default:
                                        KoDataTable.Rows[this.dataGridView1.SelectedCells[0].RowIndex][this.dataGridView1.SelectedCells[0].ColumnIndex] = int.Parse(array3[0]);
                                        break;
                                }
                            }
                            catch (Exception)
                            {
                            }
                        }
                        else
                        {
                            try
                            {
                                KoDataTable.Rows.Add(array3[0]);
                            }
                            catch (Exception)
                            {
                            }
                        }
                    }
                }
            }
        }

        private void deleteSelectedColumnsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedCells.Count > 0)
            {
                DataTable dataTable = KoDataTable;
                DataSet dataSet = new DataSet("tableDataSet");
                List<int> list = new List<int>();
                foreach (DataGridViewCell selectedCell in this.dataGridView1.SelectedCells)
                {
                    list.Add(selectedCell.ColumnIndex);
                }
                DataTable dataTable2 = new DataTable("tableDataTable");
                foreach (DataColumn column in dataTable.Columns)
                {
                    if (!list.Contains(column.Ordinal))
                    {
                        dataTable2.Columns.Add(column.ColumnName, column.DataType);
                    }
                }
                foreach (DataRow row in dataTable.Rows)
                {
                    List<object> list2 = new List<object>();
                    for (int i = 0; i < dataTable.Columns.Count; i++)
                    {
                        if (!list.Contains(i))
                        {
                            list2.Add(row[i]);
                        }
                    }
                    dataTable2.Rows.Add(list2.ToArray());
                }
                this.dataGridView1.SuspendLayout();
                dataSet.Tables.Add(dataTable2);
                this.dataGridView1.DataSource = null;
                this.dataGridView1.DataMember = null;
                dataTable.Dispose();
                dataTable = null;
                KoDataTable.Clear();
                KoDataTable.Dispose();
                koTableFile.Table = dataTable;
                //this.currentTableDataSet.Tables.Remove("tableDataTable");
                //this.currentTableDataSet.Tables.Clear();
                //this.currentTableDataSet.Dispose();
                //this.currentTableDataSet = dataSet;
                this.dataGridView1.DataSource = dataSet;
                this.dataGridView1.DataMember = "tableDataTable";
                this.dataGridView1.ResumeLayout();
            }
        }

        private void deleteSelectedRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (var r in dataGridView1.SelectedRows.Cast<DataGridViewRow>().Where(r => !r.IsNewRow))
                {
                    dataGridView1.Rows.Remove(r);
                }

                koTableFile.Table.AcceptChanges();
            }
        }

        #endregion


        private void button1_Click(object sender, EventArgs e)
        {
            ApplyFilterOnGridView();
        }

        /// <summary>
        /// https://learn.microsoft.com/pl-pl/dotnet/api/system.data.dataview.rowfilter?view=net-8.0
        /// </summary>
        public void ApplyFilterOnGridView()
        {
            if (this.filterColumn.SelectedIndex == -1)
            {
                MessageBox.Show("Please select column to filter or use \'Edit->Find\'");
                return;
            }

            bool isStringValue = (dataGridView1.DataSource as DataTable).Columns[this.filterColumn.SelectedItem.ToString()].DataType.IsEquivalentTo(typeof(string));
            string filterOperator = "";
            switch (isStringValue, IsSubString.Checked)
            {
                case (false, false):
                //filterOperator = $" > '%{textBoxFilter.Text}%'";
                case (false, true):
                case (true, false):
                    filterOperator = $"= '{textBoxFilter.Text}'";
                    break;
                case (true, true):
                    filterOperator = $"Like '%{textBoxFilter.Text}%'";
                    break;
            }

            string rowFilter = string.Format("[{0}] {1}", this.filterColumn.SelectedItem.ToString(), filterOperator);
            try
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
            }
            catch (EvaluateException exception) when (exception.Message.Contains("Cannot perform '=' operation on System.UInt32 and System.String."))
            {
                CoreServices.Logger.ShowWarning($"Selected Column: {filterColumn.SelectedItem}\n Exception: {exception.Message}");
            }
        }

        private void ResetDataGridFilter_Click(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.Sort = String.Empty;
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = String.Empty;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataViewRowState status;
            if (dataGridView1.DataSource is null)
            {
                return;
            }
            if (Enum.TryParse(RowStateComboBox.SelectedValue.ToString(), out status))
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowStateFilter = status;
            }
        }
    }
}
