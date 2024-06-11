using ItemEditor.Forms.TableEditor;
using ItemEditor.Static;

namespace ItemEditor.Forms.ItemCreator
{
    public partial class ItemCreatorForm : Form
    {
        public static TableEditorForm TableEditorForm;
        public static Dictionary<string, Control> itemTableValues = new Dictionary<string, Control>();
        ItemDatabaseFieldsForm itemDatabaseFieldsForm;
        DataItemForm dataItemForm;

        public ItemCreatorForm()
        {
            InitializeComponent();
            this.label1.Text = CoreServices.ConfigManager.Configuration?.DataTableSettings?.ItemOrgTablePath;
            this.label2.Text = CoreServices.ConfigManager.Configuration?.DataTableSettings?.ItemExtTablePath;

            itemDatabaseFieldsForm = new ItemDatabaseFieldsForm(this);
            dataItemForm = new DataItemForm();

            // itemDatabaseFieldsForm
            itemDatabaseFieldsForm.TopLevel = false;
            itemDatabaseFieldsForm.FormBorderStyle = FormBorderStyle.None;
            itemDatabaseFieldsForm.Dock = DockStyle.Fill;
            this.MainPanel.Controls.Add(itemDatabaseFieldsForm);

            //itemOrgForm
            dataItemForm.TopLevel = false;
            dataItemForm.FormBorderStyle = FormBorderStyle.None;
            dataItemForm.Dock = DockStyle.Fill;
            this.MainPanel.Controls.Add(dataItemForm);
        }

        #region Private methods

        #endregion

        public void LoadItemDataTableForm() 
        {
            panel1.Hide();

            if (!CoreServices.DatabaseManager.IsServerConnected().Item1)
            {
                MessageBox.Show("Database is not connected!");
                return;
            }

            itemDatabaseFieldsForm.CreateControlForItemDbTable();
            itemDatabaseFieldsForm.Show();
            itemDatabaseFieldsForm.BringToFront();
        }

        public void LoadItemTblForm(bool isExtOnly)
        {
            if (isExtOnly)
            {
                dataItemForm.LoadIDataTblFile(CoreServices.ConfigManager.Configuration.DataTableSettings.ItemExtTablePath);
                dataItemForm.LoadValuesIntoNewRow("item_ext", "baseitemID");
            }
            else
            {
                dataItemForm.LoadIDataTblFile(CoreServices.ConfigManager.Configuration.DataTableSettings.ItemOrgTablePath);
                dataItemForm.LoadValuesIntoNewRow("item_org", "num");
            }

            dataItemForm.Show();
            dataItemForm.BringToFront();
        }

        private void ItemOrgPathButton_Click(object sender, EventArgs e)
        {
            // Display the openFile dialog.
            DialogResult result = ItemExtDialog.ShowDialog();

            // OK button was pressed.
            if (result == DialogResult.OK)
            {
                CoreServices.ConfigManager.Configuration.DataTableSettings.ItemOrgTablePath = ItemExtDialog.FileName;
                CoreServices.ConfigManager.Save();
                this.label1.Text = CoreServices.ConfigManager.Configuration.DataTableSettings.ItemOrgTablePath;
            }
        }

        private void ItemExtPathButton_Click(object sender, EventArgs e)
        {
            // Display the openFile dialog.
            DialogResult result = ItemOrgDialog.ShowDialog();

            // OK button was pressed.
            if (result == DialogResult.OK)
            {
                CoreServices.ConfigManager.Configuration.DataTableSettings.ItemExtTablePath = ItemOrgDialog.FileName;
                CoreServices.ConfigManager.Save();
                this.label2.Text = CoreServices.ConfigManager.Configuration.DataTableSettings.ItemExtTablePath;
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CoreServices.ConfigManager.Configuration.DataTableSettings.ItemExtTablePath))
            {
                MessageBox.Show("Fill Path for \'Item Org Table!\'");
            }
            if (string.IsNullOrEmpty(CoreServices.ConfigManager.Configuration.DataTableSettings.ItemOrgTablePath))
            {
                MessageBox.Show("Fill Path for \'Item EXT Table!\'");
            }

            LoadItemDataTableForm();
        }
    }
}
