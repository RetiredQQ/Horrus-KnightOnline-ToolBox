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

        public void LoadValuesIntoNewRow(string tableTableFile, string columNameTofilter)
        {
            try
            {
                DataRow newRow = (ItemCreatorForm.TableEditorForm.dataGridView1.DataSource as DataTable).NewRow();
                int i = 0;
                List<TableEditorModelBinding> dd = TableEditorStatic.ItemTableHeaders[tableTableFile];
                foreach (var columnInItemOrg in dd)
                {
                    try
                    {
                        string gghh = ItemCreatorForm.itemTableValues[$"{columnInItemOrg.DatabaseColumnHeader}"].Text;

                        if (!string.IsNullOrEmpty(gghh))
                        {
                            newRow[columnInItemOrg.TableFileHeader.ToString()] = gghh;
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
            LoadValuesIntoNewRow("item_ext", "baseitemID");  
        }
    }
}
