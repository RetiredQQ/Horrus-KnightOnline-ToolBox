using DataAccessLayer;
using ItemEditor.Static;
using System.Data;
using System.Text;

namespace ItemEditor.Forms.ItemCreator
{
    public partial class ItemDatabaseFieldsForm : Form
    {
        ItemCreatorForm parent;
        List<string> insertIntoDbQueryies = new List<string>();

        public ItemDatabaseFieldsForm(ItemCreatorForm itemTableForm)
        {
            InitializeComponent();
            this.parent = itemTableForm;
        }

        public void CreateControlForItemDbTable()
        {
            string connectionString = DatabaseOperationBase.connectionString;
            string tableName = "ITEM";
            DataTable DataTable = CoreServices.DatabaseManager.GetTableSchema(connectionString, tableName);
            CreateControlForColumns(DataTable);
        }

        /// <summary>
        /// Dynamiclly creates a label plus input Control for each column in Database Item table
        /// </summary>
        /// <param name="schemaTable">Database Item table - Schema</param>
        private void CreateControlForColumns(DataTable schemaTable)
        {
            int indexInForm = 0;
            int yPos = 20;
            int xPos = 20;
            foreach (DataRow row in schemaTable.Rows)
            {
                string columnName = row["COLUMN_NAME"].ToString();
                string dataType = row["DATA_TYPE"].ToString();

                if (indexInForm != 0 && indexInForm % 20 == 0)
                {
                    xPos = xPos + 400;
                    yPos = 20;
                }

                // Create Label
                Label label = new Label();
                label.Text = columnName;
                label.Location = new Point(xPos, yPos);
                label.AutoSize = true;
                this.DatabaseItemPanel.Controls.Add(label);

                // Create appropriate control based on data type
                Control control = null;

                if ((dataType.Equals("varchar", StringComparison.OrdinalIgnoreCase) || dataType.Equals("char", StringComparison.OrdinalIgnoreCase)) && !columnName.Equals("ItemPlusID", StringComparison.OrdinalIgnoreCase))
                {
                    control = new TextBox();
                }
                else
                {
                    control = new NumericUpDown()
                    {
                        Minimum = int.MinValue,
                        Maximum = int.MaxValue,
                        Increment = 0,
                    };
                    //control.Enter += dbConnectionControl_Enter;
                }

                control.Name = "input_" + columnName;
                control.Location = new Point(xPos + 150, yPos);
                //control.DoubleBuffered(false);

                this.DatabaseItemPanel.Controls.Add(control);

                yPos += 30;
                indexInForm++;

                ItemCreatorForm.itemTableValues.Add(columnName, control);
            }
        }

        /// <summary>
        /// Clears text from focused control
        /// </summary>
        private void dbConnectionControl_Enter(object sender, EventArgs e)
        {
            (sender as NumericUpDown).Text = string.Empty;
        }

        private void ContinueToItemOrgButton_Click(object sender, EventArgs e)
        {
            parent.LoadItemTblForm(this.isExtOnly.Checked);
        }

        /// <summary>
        /// Build and triggerQuery for insert statement into dbo.ITEM table 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExecuteInsertIntoItemTableDb_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(richTextBox1.Text))
            {
                MessageBox.Show("Please click \'Prepare Query\' first");
                return;
            }

            try
            {
                foreach (var item in insertIntoDbQueryies)
                {
                    var result = CoreServices.DatabaseManager.InsertIntoItems(item);
                    if (result != 1)
                    {
                        CoreServices.Logger.ShowError($"DB error when inserting new row, error code {result}");
                    }
                }

                MessageBox.Show($"Sucesfull Insert into db:{Environment.NewLine}{richTextBox1.Text}");
            }
            catch (Exception exception)
            {
                CoreServices.Logger.ShowError($"DB error exception : {exception}");
            }
        }

        private void PrepareDbInsertButton_Click(object sender, EventArgs e)
        {
            if (!IsMultipleInsertCheckbox.Checked)
            {
                this.richTextBox1.Clear();
                this.insertIntoDbQueryies.Clear();
            }

            StringBuilder insertIntoBuilder = new StringBuilder();

            foreach (var item in ItemCreatorForm.itemTableValues)
            {
                if (item.Value.GetType().FullName.Equals("System.Windows.Forms.TextBox"))
                {
                    insertIntoBuilder.Append($",\'{item.Value.Text}\'");
                }
                else
                {
                    insertIntoBuilder.Append($",{item.Value.Text}");
                }
            }

            string insert = $"INSERT INTO [dbo].[ITEM] VALUES ({insertIntoBuilder.ToString().Remove(0, 1)})";
            this.insertIntoDbQueryies.Add(insert);
            ItemCreatorForm.extElementsToTableEnteries.Add(ItemCreatorForm.itemTableValues);
            richTextBox1.AppendText(insert);
            richTextBox1.AppendText(Environment.NewLine);
        }
    }
}
