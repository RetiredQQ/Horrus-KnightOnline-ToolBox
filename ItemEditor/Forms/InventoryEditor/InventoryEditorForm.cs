using ItemEditor.Static;
using ItemEditor.ExternalControl;
using ItemEditor.Extensions;
using ItemEditor.StaticClasses;
using DataAccessLayer.Models;
using ClassDefinitions.Emum;

namespace ItemEditor.Forms
{
    public partial class InventoryEditorForm : Form
    {
        List<ItemDAO> itemDAOs = new List<ItemDAO> {};

        public InventoryEditorForm()
        {
            InitializeComponent();
            searchParamItemType.SelectedText = "Everything";
            searchParamItemType.SelectedItem = "Everything";
        }

        #region LoadUserInfo

        public void LoadUserInfo()
        {
            Cursor = Cursors.WaitCursor;
            this.inventoryPanelControl1.CleanIventoryItem(true);
            this.inventoryPanelControl1.LoadUserInventoryInfo(StaticValues.PlayerName);
            Cursor = Cursors.Arrow;
        }

        private void LoadUserInfoButton_Click(object sender, EventArgs e)
        {
            LoadUserInfo();
        }

        #endregion

        #region SearchButton

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                itemDAOs = CoreServices.DatabaseManager.SearchItemsTableWithConstrains(GetItemSqlWhereCondition());
                this.objectListView1.SetObjects(itemDAOs);
                this.objectListView1.Refresh();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Error: {exception}");
                CoreServices.Logger.LogException(exception);
            }
        }

        #endregion

        #region SearchItemInfo TextBox

        private void objectListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (objectListView1.SelectedIndex != -1)
            {
                ItemDAO infoItem = itemDAOs[objectListView1.SelectedIndex];
                this.pictureBoxGeneric.ItemRepresentation = new UserItem(0, infoItem.Num, infoItem.strName, infoItem.Duration, infoItem.Duration, 1, infoItem.Countable/*, null, null, null*/);
                //this.pictureBoxGeneric.OriginalIcon = 
                ItemInfoHelper.DisplayItemInfo(infoItem.Num, this.SearchInfoItemRichTextBox, pictureBoxGeneric);
                this.pictureBoxGeneric.Image = CoreServices.ImageHelper.GetItemJpgFile(infoItem.Num, this.pictureBoxGeneric.Size);
            }
        }

        #endregion

        #region Create New item - MouseMove
        private void pictureBoxGeneric_MouseMove(object sender, MouseEventArgs e)
        {
            var pictureBox = sender as CustomPictureBox;

            if (e.Button == MouseButtons.Left && pictureBox.ItemRepresentation != null)
            {
                pictureBox.DoDragDrop(pictureBox, DragDropEffects.Move);
                this.inventoryPanelControl1.CleanIventoryItem();
            }
        }

        private void ObjectListView1_ItemDrag(object? sender, ItemDragEventArgs e)
        {
            pictureBoxGeneric_MouseMove(this.pictureBoxGeneric, new MouseEventArgs(e.Button, 0, 0, 0, 0));
        }

        #endregion


        private string GetItemSqlWhereCondition()
        {
            string EqualOrGreaterThen = ">=";
            string serachPramsQuery = $"WHERE strName like '%' ";

            if (searchParamIndicatorName.Checked)
                serachPramsQuery = $"WHERE LOWER([strName]) LIKE LOWER('%{this.searchParamName.Text}%')";
            if (searchParamIndicatorItemID.Checked)
                serachPramsQuery += $" AND [Num] = {this.searchParamItemID.Text}";

            if (!searchParamItemType.SelectedItem.ToString().Equals("Everything", StringComparison.OrdinalIgnoreCase))
            {
                Enum.TryParse(searchParamItemType.SelectedItem.ToString().RemoveWhitespces(), out ItemTypeEnum cast);
                serachPramsQuery += $" AND [ItemType] = {(byte)cast}";
            }

            if (searchParamIndicatorItemLevel.Checked)
                serachPramsQuery += String.Format(" AND [Num] like '%{0}' ", this.searchParamItemLevel.Value == 10 ? 0 : this.searchParamItemLevel.Value);
            if (searchParamIndicatorBonusStr.Checked)
                serachPramsQuery += $" AND [StrB] {EqualOrGreaterThen} {this.searchParamBonusStr.Value}";
            if (searchParamIndicatorBonusHp.Checked)
                serachPramsQuery += $" AND [StaB] {EqualOrGreaterThen} {this.searchParamBonusHp.Value}";
            if (searchParamIndicatorBonusDex.Checked)
                serachPramsQuery += $" AND [DexB] {EqualOrGreaterThen} {this.searchParamBonusDex.Value}";
            if (searchParamIndicatorBonusInt.Checked)
                serachPramsQuery += $" AND [IntelB] {EqualOrGreaterThen} {this.searchParamBonusInt.Value}";
            if (searchParamIndicatorBonusMp.Checked)
                serachPramsQuery += $" AND [ChaB] {EqualOrGreaterThen} {this.searchParamBonusMp.Value}";
            if (searchParamIndicatorAttack.Checked)
                serachPramsQuery += $" AND [Damage] {EqualOrGreaterThen} {this.searchParamAttack.Value}";
            if (searchParamIndicatorDeffence.Checked)
                serachPramsQuery += $" AND [Ac] {EqualOrGreaterThen} {this.searchParamDeffence.Value}";
            if (searchParamIndicatorElementalFire.Checked)
                serachPramsQuery += $" AND [FireDamage] {EqualOrGreaterThen} {this.searchParamElementalFire.Value}";
            if (searchParamIndicatorElementalIce.Checked)
                serachPramsQuery += $" AND [IceDamage] {EqualOrGreaterThen} {this.searchParamElementalIce.Value}";
            if (searchParamIndicatorElementalLighting.Checked)
                serachPramsQuery += $" AND [LightningDamage] {EqualOrGreaterThen} {this.searchParamElementalLighting.Value}";
            if (searchParamIndicatorElementalPoison.Checked)
                serachPramsQuery += $" AND [PoisonDamage] {EqualOrGreaterThen} {this.searchParamElementalPoison.Value}";

            return serachPramsQuery;
        }

        private void CopyItemNum_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(pictureBoxGeneric.ItemRepresentation.Num.ToString());
        }
    }
}