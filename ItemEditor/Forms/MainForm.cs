using DataAccessLayer;
using ItemEditor.Extensions;
using ItemEditor.Forms.ItemCreator;
using ItemEditor.Static;
using ClassDefinitions.Models.Configuration;
using System.Data.SqlClient;
using System.Reflection;
using System.Security.AccessControl;

namespace ItemEditor.Forms
{
    public partial class MainForm : Form
    {
        private bool IneventoryEditorIsToggle = true;

        public MainForm()
        {
            InitializeComponent();

            // Create Side Panel Forms
            CoreServices.searchUserForm.TopLevel = false;
            CoreServices.searchUserForm.FormBorderStyle = FormBorderStyle.None;
            CoreServices.searchUserForm.Dock = DockStyle.Fill;
            this.CenterPanel.Controls.Add(CoreServices.searchUserForm);

            CoreServices.inventoryEditorForm.TopLevel = false;
            CoreServices.inventoryEditorForm.FormBorderStyle = FormBorderStyle.None;
            CoreServices.inventoryEditorForm.Dock = DockStyle.Fill;
            this.CenterPanel.Controls.Add(CoreServices.inventoryEditorForm);

            CoreServices.TableEditorForm.TopLevel = false;
            CoreServices.TableEditorForm.FormBorderStyle = FormBorderStyle.None;
            CoreServices.TableEditorForm.Dock = DockStyle.Fill;
            this.CenterPanel.Controls.Add(CoreServices.TableEditorForm);

            // table Editor - GridView Performance optimalization
            CoreServices.TableEditorForm.dataGridView1.DoubleBuffered(true);

            //inventoryEditorForm.AutoScroll = true;
            //this.CenterPanel.Controls.Clear();

            // Load DB Default Config settings
            CoreServices.ConfigManager.Load();
            this.dbConnectionControl.DataSourceRtb.Text = CoreServices.ConfigManager.Configuration.DbName;
            this.dbConnectionControl.UserIdRtb.Text = CoreServices.ConfigManager.Configuration.UserName;
            this.dbConnectionControl.PasswordRtb.Text = CoreServices.ConfigManager.Configuration.Password;
            this.dbConnectionControl.InitialCatalogRtb.Text = CoreServices.ConfigManager.Configuration.CatalogName;
            this.V1098.Checked = CoreServices.ConfigManager.Configuration.Is1098Version;
        }

        private void InventoryPanelOptionToggle_Click(object sender, EventArgs e)
        {
            if (IneventoryEditorIsToggle)
            {
                this.PlayerInventoryBtn.Visible = true;
                this.PlayerInnHonestBtn.Visible = true;
            }
            else
            {
                this.PlayerInventoryBtn.Visible = false;
                this.PlayerInnHonestBtn.Visible = false;
                this.PlayerInventoryBtn.BackColor = Color.Transparent;
            }

            this.IneventoryEditorIsToggle = !this.IneventoryEditorIsToggle;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (V1098.Checked)
            {
                CoreServices.ImageHelper.Load1098IconReferences();
                CoreServices.DatabaseManager = new DatabaseOperationManagerV1098();
            }

            CoreServices.DatabaseManager.CreateConnectionString(
                this.dbConnectionControl.DataSourceRtb.Text,
                this.dbConnectionControl.UserIdRtb.Text,
                this.dbConnectionControl.PasswordRtb.Text,
                this.dbConnectionControl.InitialCatalogRtb.Text
                );

            (bool result, SqlException? error) connectionResult = CoreServices.DatabaseManager.IsServerConnected();

            if (!connectionResult.result)
            {
                MessageBox.Show($"Connection error: {connectionResult.error}");
                CoreServices.Logger.LogException(connectionResult.error);
            }
            else
            {
                var requiredSqlObjects = new Dictionary<string, string>
                {
                    { "[dbo].[_HorrusTB_EncodeStrItem]", "P" },
                    { "[dbo].[_HorrusTB_DecodeStrItem]", "P" },
                };

                foreach (var item in requiredSqlObjects)
                {
                    if (CoreServices.DatabaseManager.VerifyIfRequiredProceduresExists(item.Key, item.Value) == 0)
                    {
                        MessageBox.Show($"Missing SQL object. Please trigger manully from existing folder SqlProcedures. Proc:{item.Key}");
                    }
                }

                CoreServices.searchUserForm.InitializeCharacterInfo();
                CoreServices.searchUserForm.Show();
                CoreServices.searchUserForm.BringToFront();
                this.SaveSucsesfullDbConnectionInfo();
            }
        }
        private void SidePanelOptionButton_MouseHover(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.ForeColor = Color.White;
        }

        private void SidePanelOptionButton_MouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.ForeColor = Color.Bisque;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CoreServices.searchUserForm.Show();
            CoreServices.searchUserForm.BringToFront();
        }

        private void SaveSucsesfullDbConnectionInfo()
        {
            CoreServices.ConfigManager.Configuration.DbName = this.dbConnectionControl.DataSourceRtb.Text;
            CoreServices.ConfigManager.Configuration.UserName = this.dbConnectionControl.UserIdRtb.Text;
            CoreServices.ConfigManager.Configuration.Password = this.dbConnectionControl.PasswordRtb.Text;
            CoreServices.ConfigManager.Configuration.CatalogName = this.dbConnectionControl.InitialCatalogRtb.Text;
            CoreServices.ConfigManager.Configuration.Is1098Version = this.V1098.Checked;
            CoreServices.ConfigManager.Save();
        }

        private void SelectTableEditorForm_Click(object sender, EventArgs e)
        {
            CoreServices.TableEditorForm.Show();
            CoreServices.TableEditorForm.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (CoreServices.ItemCreatorForm == null)
            {
                CoreServices.ItemCreatorForm = new ItemCreatorForm();
                CoreServices.ItemCreatorForm.TopLevel = false;
                CoreServices.ItemCreatorForm.FormBorderStyle = FormBorderStyle.None;
                CoreServices.ItemCreatorForm.Dock = DockStyle.Fill;
                this.CenterPanel.Controls.Add(CoreServices.ItemCreatorForm);
                //CoreServices.ItemTableForm.CreateControlForItemDbTable();
            }

            CoreServices.ItemCreatorForm.Show();
            CoreServices.ItemCreatorForm.BringToFront();
        }

        private void PlayerInventoryBtn_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            CoreServices.inventoryEditorForm.Show();
            CoreServices.inventoryEditorForm.BringToFront();
            Cursor = Cursors.Arrow;
        }
    }
}
