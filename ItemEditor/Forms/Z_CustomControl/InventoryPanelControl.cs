using DataAccessLayer.Models;
using ItemEditor.Extensions;
using ItemEditor.ExternalControl;
using ItemEditor.Properties;
using ItemEditor.Static;
using ItemEditor.StaticClasses;

namespace ItemEditor.CustomControls
{
    public partial class InventoryPanelControl : UserControl
    {
        #region Private fields and Properties
        Dictionary<int, CustomPictureBox> pictureBoxesDictionary { get; set; }
        List<UserItem> userItemsOriginal { get; set; } = new List<UserItem>();

        string workingUserName = string.Empty;
        int userCoins = 0;
        #endregion

        #region Constructor
        public InventoryPanelControl()
        {
            InitializeComponent();
            pictureBoxesDictionary = new Dictionary<int, CustomPictureBox>()
            {
                { 1, this.customPictureBox1 },
                { 2, this.customPictureBox2 },
                { 3, this.customPictureBox3 },
                { 4, this.customPictureBox4 },
                { 5, this.customPictureBox5 },
                { 6, this.customPictureBox6 },
                { 7, this.customPictureBox7 },
                { 8, this.customPictureBox8 },
                { 9, this.customPictureBox9 },
                { 10, this.customPictureBox10 },
                { 11, this.customPictureBox11 },
                { 12, this.customPictureBox12 },
                { 13, this.customPictureBox13 },
                { 14, this.customPictureBox14 },
                { 15, this.customPictureBox16 },
                { 16, this.customPictureBox17 },
                { 17, this.customPictureBox18 },
                { 18, this.customPictureBox19 },
                { 19, this.customPictureBox20 },
                { 20, this.customPictureBox21 },
                { 21, this.customPictureBox22 },
                { 22, this.customPictureBox23 },
                { 23, this.customPictureBox24 },
                { 24, this.customPictureBox25 },
                { 25, this.customPictureBox26 },
                { 26, this.customPictureBox27 },
                { 27, this.customPictureBox28 },
                { 28, this.customPictureBox29 },
                { 29, this.customPictureBox30 },
                { 30, this.customPictureBox31 },
                { 31, this.customPictureBox32 },
                { 32, this.customPictureBox33 },
                { 33, this.customPictureBox34 },
                { 34, this.customPictureBox35 },
                { 35, this.customPictureBox36 },
                { 36, this.customPictureBox37 },
                { 37, this.customPictureBox38 },
                { 38, this.customPictureBox39 },
                { 39, this.customPictureBox40 },
                { 40, this.customPictureBox41 },
                { 41, this.customPictureBox42 },
                { 42, this.customPictureBox43 },
            };
            InitalizePictureBoxProperties();
        }

        #region Private - Initialize Required objects

        private void InitalizePictureBoxProperties()
        {
            this.SetBackgroundImageLayout();

            foreach (var item in this.pictureBoxesDictionary)
            {
                item.Value.SlotID = item.Key;
            }

            foreach (var item in this.pictureBoxesDictionary)
            {
                item.Value.DragDrop += new DragEventHandler(this.pictureBoxGeneric_DragDrop);
                item.Value.DragEnter += new DragEventHandler(this.pictureBoxReuseable_DragEnter);
                item.Value.MouseEnter += new EventHandler(this.pictureBoxGeneric_InventoryItem_MouseEnter);
                item.Value.MouseMove += new MouseEventHandler(this.pictureBoxGeneric_InventoryItem_MouseMove);
                item.Value.DoubleClick += new EventHandler(this.changeStacableItemAmount_DoubleClick);
                item.Value.AllowDrop = true;
            }

            // AllowDrop property contain attribute [Browsable(false)]
            this.deleteItemPictureBox.AllowDrop = true;
        }

        private void SetBackgroundImageLayout()
        {
            foreach (var pictureBox in this.pictureBoxesDictionary)
            {
                pictureBox.Value.Anchor = AnchorStyles.None;
                pictureBox.Value.Size = new Size(68, 64);
                pictureBox.Value.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Value.BackColor = Color.Transparent;
            }
        }

        #endregion
       
        #endregion

        #region Public Load User Iventory Info

        public void LoadUserInventoryInfo(string userName)
        {
            this.workingUserName = userName;
            this.userItemsOriginal = CoreServices.DatabaseManager.GetUserInventory(this.workingUserName);
            this.userCoins = CoreServices.DatabaseManager.GetUserCoins(this.workingUserName);
            this.CoinsAmountLabel.Text = $"{this.userCoins:N}";

            foreach (UserItem item in this.userItemsOriginal)
            {
                CustomPictureBox? picBox;

                if (this.pictureBoxesDictionary.TryGetValue(item.Slot, out picBox) && item.Num == 0)
                {
                    picBox.Image = null;
                    picBox.ItemRepresentation = null;
                }
                if (this.pictureBoxesDictionary.TryGetValue(item.Slot, out picBox) && item.Num != 0)
                {
                    picBox.Image = CoreServices.ImageHelper.GetItemJpgFile(item.Num);
                    picBox.OriginalIcon = (Image)picBox.Image.Clone();
                    picBox.ItemRepresentation = new UserItem(item.Slot, item.Num, item.StrName, item.MaxDuarbility, item.CurrentDuarbility, item.ItemCount, item.Countable/*, item.ItemFlag, item.ItemExpireTime, item.ItemSerial*/);

                    DrawIntoImage(picBox, picBox.ItemRepresentation.ItemCount.ToString());
                }
            }
        }

        #endregion

        #region Save User Iventory Info

        private void SaveChanges()
        {
            List<UserItem> userItemsUpdate = new List<UserItem>(userItemsOriginal);

            foreach (KeyValuePair<int, CustomPictureBox> item in pictureBoxesDictionary)
            {
                userItemsUpdate[item.Key - 1].Num = item.Value.ItemRepresentation?.Num ?? 0;
                userItemsUpdate[item.Key - 1].ItemCount = item.Value.ItemRepresentation?.ItemCount ?? 0;
                userItemsUpdate[item.Key - 1].MaxDuarbility = item.Value.ItemRepresentation?.MaxDuarbility ?? 0;
            }

            CoreServices.DatabaseManager.SaveChanges(this.workingUserName, userItemsUpdate, userCoins);
        }

        private void saveCharacterButton_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            SaveChanges();
            Cursor = Cursors.Arrow;
            MessageBox.Show("Save Sucesfully");
        }

        #endregion

        #region Inventory Item - Modify Player Coins

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            this.CoinsPicBox.BackgroundImage = Resources.Coin_image2;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.CoinsPicBox.BackgroundImage = Resources.Coin_image;
        }

        private void CoinsPicBox_Click(object sender, EventArgs e)
        {
            if (inputDialog1.ShowDialog(this) == DialogResult.OK)
            {
                if (Int32.TryParse(inputDialog1.Input.RemoveWhitespces(), out this.userCoins))
                {
                    this.CoinsAmountLabel.Text = $"{this.userCoins:N}";
                    inputDialog1.Input = string.Empty;
                }
            }
        }

        #endregion

        #region Inventory Item - Modify Stackable Item Amount

        private void changeStacableItemAmount_DoubleClick(object sender, EventArgs e)
        {
            CustomPictureBox? editedItem = sender as CustomPictureBox;

            if (editedItem != null && editedItem?.ItemRepresentation?.Countable == 1)
            {
                if (inputDialog1.ShowDialog(this) == DialogResult.OK)
                {
                    short newStackableAmount;
                    if (short.TryParse(inputDialog1.Input.RemoveWhitespces(), out newStackableAmount))
                    {
                        editedItem.ItemRepresentation.ItemCount = newStackableAmount;

                        RestoreOriginalIcon(editedItem);
                        DrawIntoImage(editedItem, newStackableAmount.ToString());
                        ItemInfoHelper.DisplayItemInfo(editedItem.ItemRepresentation.Num, this.ItemInfoRichTextBox, this.itemOverviewPicBox, editedItem.ItemRepresentation);
                        inputDialog1.Input = string.Empty;
                    }
                }
            }
        }

        #endregion

        #region Inventory Item - Delete

        private void deleteItem_DragDrop(object sender, DragEventArgs e)
        {
            CustomPictureBox? copiedItem = (e?.Data?.GetData(typeof(CustomPictureBox))) as CustomPictureBox;
            if (deleteItemPictureBox.IsDeleteItem && copiedItem?.Image != null)
            {
                DialogResult confirmResult = MessageBox.Show("Are you sure to delete this item?", "Delete Confirm", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    copiedItem.Image = null;
                    copiedItem.ItemRepresentation = null;
                    copiedItem.OriginalIcon = null;
                    ItemInfoRichTextBox.Clear();
                    itemOverviewPicBox.Image = null;
                }
            }
        }

        #endregion

        #region Inventory Item - Drag&Drop -> Create New Item, Drow Countable Amount

        private void pictureBoxGeneric_DragDrop(object sender, DragEventArgs e)
        {
            var pictureBox = sender as CustomPictureBox;
            var copiedItem = (e?.Data?.GetData(typeof(CustomPictureBox))) as CustomPictureBox;
            if (copiedItem?.Image != null && pictureBox.Image == null)
            {
                pictureBox.ItemRepresentation = new UserItem(copiedItem.ItemRepresentation);

                if (copiedItem.IsCreateNewItem && copiedItem.OriginalIcon == null)
                {
                    pictureBox.Image = (Image)copiedItem.Image.Clone();
                    pictureBox.OriginalIcon = (Image)copiedItem.Image.Clone();

                    if (copiedItem.IsCreateNewItem && pictureBox.ItemRepresentation.Countable == 1)
                    {
                        if (inputDialog2.ShowDialog(this) == DialogResult.OK)
                        {
                            short createItemCountableItemAmout;
                            if (Int16.TryParse(inputDialog2.Input, out createItemCountableItemAmout))
                            {
                                pictureBox.ItemRepresentation.ItemCount = createItemCountableItemAmout;
                            }
                        }
                    }
                }

                if (!copiedItem.IsCreateNewItem)
                {
                    pictureBox.Image = (Image)copiedItem.OriginalIcon.Clone();
                    pictureBox.OriginalIcon = (Image)copiedItem.OriginalIcon.Clone();

                    DrawIntoImage(pictureBox, pictureBox.ItemRepresentation.ItemCount.ToString());

                    copiedItem.Image = null;
                    copiedItem.ItemRepresentation = null;
                }
            }
        }

        #endregion

        #region MouseMove - Display Inventory Item Info and Inventory Item Move

        private void pictureBoxGeneric_InventoryItem_MouseEnter(object sender, EventArgs e)
        {
            var pictureBox = sender as CustomPictureBox;
            if (pictureBox.ItemRepresentation != null)
            {
                ItemInfoHelper.DisplayItemInfo(pictureBox.ItemRepresentation.Num, this.ItemInfoRichTextBox, this.itemOverviewPicBox, pictureBox.ItemRepresentation);
            }
        }

        private void pictureBoxGeneric_InventoryItem_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var pictureBox = sender as CustomPictureBox;
                pictureBox.DoDragDrop(pictureBox, DragDropEffects.Move);
            }
        }

        #endregion

        #region Countable Item - Draw Amount On Item Icon

        public void CleanIventoryItem(bool forceClean = false)
        {
            foreach (var item in pictureBoxesDictionary)
            {
                if (forceClean)
                {
                    item.Value.ItemRepresentation = null;
                }

                if (item.Value.ItemRepresentation != null)
                {
                    DrawIntoImage(item.Value, item.Value.ItemRepresentation.ItemCount.ToString());
                }
            }
        }

        private void DrawIntoImage(CustomPictureBox pictureBox1, string text)
        {
            if (pictureBox1.ItemRepresentation.Countable == 1 && pictureBox1.ItemRepresentation.ItemCount > 1)
            {
                using (Graphics graphics = Graphics.FromImage(pictureBox1.Image))
                {
                    using (Font myFont = new Font("Arial", 11))
                    {
                        graphics.DrawString($"{text}", myFont, Brushes.AntiqueWhite, new Point(2, 41));
                    }
                }
                // when done with all drawing you can enforce the display update by calling:
                pictureBox1.Refresh();
            }
        }

        private void RestoreOriginalIcon(CustomPictureBox pictureBox1)
        {
            if (pictureBox1.OriginalIcon != null)
            {
                pictureBox1.Image = null;
                pictureBox1.Image = (Image)pictureBox1.OriginalIcon.Clone();
            }
        }

        #endregion

        private void pictureBoxReuseable_DragEnter(object sender, DragEventArgs e)
        {
            var itemElement = e?.Data?.GetData(typeof(CustomPictureBox)) as CustomPictureBox;
            if (itemElement?.Image != null)
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CoreServices.searchUserForm.Show();
            CoreServices.TableEditorForm.BringToFront();
        }
    }
}
