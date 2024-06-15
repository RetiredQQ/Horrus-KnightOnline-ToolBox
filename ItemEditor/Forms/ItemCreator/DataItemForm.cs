using ClassDefinitions.Models;
using ItemEditor.Extensions;
using ItemEditor.Forms.TableEditor;
using ItemEditor.Static;
using System.Data;
using TblEncodings;

namespace ItemEditor.Forms.ItemCreator
{
    public partial class DataItemForm : Form
    {
        public DataItemForm()
        {
            InitializeComponent();

            ItemCreatorForm.TableEditorForm = new TableEditorForm();
            ItemCreatorForm.TableEditorForm.TopLevel = false;
            ItemCreatorForm.TableEditorForm.FormBorderStyle = FormBorderStyle.None;
            ItemCreatorForm.TableEditorForm.Dock = DockStyle.Fill;
            this.Controls.Add(ItemCreatorForm.TableEditorForm);
        }

        public void LoadIDataTblFile(string pathToTBLfile)
        {
            ItemCreatorForm.TableEditorForm.Show();
            ItemCreatorForm.TableEditorForm.BringToFront();
            ItemCreatorForm.TableEditorForm.OpenFile(pathToTBLfile);
            ItemCreatorForm.TableEditorForm.dataGridView1.DoubleBuffered(true);
        }

        public void LoadMultipleRowsIntoExtTable(string tableTableFile, string columNameTofilter)
        {
            try
            {
                var maxID = (ItemCreatorForm.TableEditorForm.dataGridView1.DataSource as DataTable).AsEnumerable().Max(row => Convert.ToInt32(row["ItemExtIndex"]));

                //foreach (Dictionary<string, Control> extEntry in ItemCreatorForm.extElementsToTableEnteries)
                Dictionary<string, Control> extEntry = ItemCreatorForm.extElementsToTableEnteries.First();
                //{
                    DataRow newRow = (ItemCreatorForm.TableEditorForm.dataGridView1.DataSource as DataTable).NewRow();
                    List<TableEditorModelBinding> itemTableHeaders = TableEditorStatic.ItemTableHeaders[tableTableFile];
                    foreach (var columnInItemOrg in itemTableHeaders)
                    {
                        try
                        {
                            if (columnInItemOrg.TableFileHeader.ToString().Equals("ItemExtIndex"))
                            {
                                newRow["ItemExtIndex"] = ++maxID;
                            }

                            if (columnInItemOrg.TableFileHeader.ToString().Equals("AtkInterval") && !string.IsNullOrEmpty(extEntry[$"Delay"].Text) && !extEntry[$"Delay"].Text.Equals("0"))
                            {
                                newRow["AtkInterval"] = 100;
                            }

                            string valueFromDbModel = extEntry[$"{columnInItemOrg.DatabaseColumnHeader}"].Text;

                            if (!string.IsNullOrEmpty(valueFromDbModel))
                            {
                                newRow[columnInItemOrg.TableFileHeader.ToString()] = valueFromDbModel;
                            }
                        }
                        catch (Exception)
                        {
                        }
                    }

                    (ItemCreatorForm.TableEditorForm.dataGridView1.DataSource as DataTable).Rows.Add(newRow);
                    (ItemCreatorForm.TableEditorForm.dataGridView1.DataSource as DataTable).AcceptChanges();

                    string textToFilter = extEntry["Num"].Text;
                    string rowFilter = $"[{columNameTofilter}] = '{textToFilter}'";
                    (ItemCreatorForm.TableEditorForm.dataGridView1.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
                //}
            }
            catch (Exception ee)
            {
            }
        }

        public void LoadValuesIntoNewRow(string tableTableFile, string columNameTofilter)
        {
            try
            {
                DataRow newRow = (ItemCreatorForm.TableEditorForm.dataGridView1.DataSource as DataTable).NewRow();
                int i = 0;
                List<TableEditorModelBinding> itemTableHeaders = TableEditorStatic.ItemTableHeaders[tableTableFile];
                foreach (var columnInItemOrg in itemTableHeaders)
                {
                    try
                    {
                        string valueFromDbModel = ItemCreatorForm.extElementsToTableEnteries.First()[$"{columnInItemOrg.DatabaseColumnHeader}"].Text;

                        if (!string.IsNullOrEmpty(valueFromDbModel))
                        {
                            newRow[columnInItemOrg.TableFileHeader.ToString()] = valueFromDbModel;
                        }
                    }
                    catch (Exception ee)
                    {
                    }
                    i++;
                }

                (ItemCreatorForm.TableEditorForm.dataGridView1.DataSource as DataTable).Rows.Add(newRow);
                (ItemCreatorForm.TableEditorForm.dataGridView1.DataSource as DataTable).AcceptChanges();

                string textToFilter = ItemCreatorForm.itemTableValues["Num"].Text;
                string rowFilter = $"[{columNameTofilter}] = '{textToFilter}'";
                (ItemCreatorForm.TableEditorForm.dataGridView1.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
            }
            catch (Exception ee)
            {
            }
        }

        private void LoadExtButton_Click(object sender, EventArgs e)
        {
            ItemCreatorForm.TableEditorForm.OpenFile(CoreServices.ConfigManager.Configuration.DataTableSettings.ItemExtTablePath);
            ItemCreatorForm.TableEditorForm.dataGridView1.DoubleBuffered(true);
            //LoadValuesIntoNewRow("item_ext", "baseitemID");
            LoadMultipleRowsIntoExtTable("item_ext", "baseitemID");
        }

        private void RestoreStartFormButton_Click(object sender, EventArgs e)
        {
            ItemCreatorForm.itemDatabaseFieldsForm.BringToFront();
        }
    }
}
