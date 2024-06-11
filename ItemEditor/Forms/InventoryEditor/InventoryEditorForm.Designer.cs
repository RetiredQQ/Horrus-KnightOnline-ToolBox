using BrightIdeasSoftware;
using ItemEditor.ExternalControl;
using System.Windows.Forms;

namespace ItemEditor.Forms
{
    partial class InventoryEditorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryEditorForm));
            this.pictureBoxGeneric = new ItemEditor.ExternalControl.CustomPictureBox();
            this.searchParamName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.objectListView1 = new BrightIdeasSoftware.ObjectListView();
            this.strName = new BrightIdeasSoftware.OLVColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.CopyItemID = new System.Windows.Forms.Button();
            this.SearchInfoItemRichTextBox = new ItemEditor.ExternalControl.DisabledRichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.searchParamItemKind = new ItemEditor.ExternalControl.CustomComboBox();
            this.searchParamIndicatorItemID = new System.Windows.Forms.RadioButton();
            this.searchParamItemID = new System.Windows.Forms.TextBox();
            this.searchParamIndicatorName = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.searchParamIndicatorElementalPoison = new System.Windows.Forms.CheckBox();
            this.searchParamElementalPoison = new System.Windows.Forms.NumericUpDown();
            this.searchParamElementalLighting = new System.Windows.Forms.NumericUpDown();
            this.searchParamIndicatorElementalLighting = new System.Windows.Forms.CheckBox();
            this.searchParamElementalIce = new System.Windows.Forms.NumericUpDown();
            this.searchParamIndicatorElementalIce = new System.Windows.Forms.CheckBox();
            this.searchParamElementalFire = new System.Windows.Forms.NumericUpDown();
            this.searchParamIndicatorElementalFire = new System.Windows.Forms.CheckBox();
            this.searchParamDeffence = new System.Windows.Forms.NumericUpDown();
            this.searchParamIndicatorDeffence = new System.Windows.Forms.CheckBox();
            this.searchParamAttack = new System.Windows.Forms.NumericUpDown();
            this.searchParamIndicatorAttack = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.searchParamItemLevel = new System.Windows.Forms.NumericUpDown();
            this.searchParamIndicatorBonusMp = new System.Windows.Forms.CheckBox();
            this.searchParamBonusMp = new System.Windows.Forms.NumericUpDown();
            this.searchParamBonusInt = new System.Windows.Forms.NumericUpDown();
            this.searchParamIndicatorBonusInt = new System.Windows.Forms.CheckBox();
            this.searchParamIndicatorBonusDex = new System.Windows.Forms.CheckBox();
            this.searchParamBonusDex = new System.Windows.Forms.NumericUpDown();
            this.searchParamBonusHp = new System.Windows.Forms.NumericUpDown();
            this.searchParamIndicatorBonusHp = new System.Windows.Forms.CheckBox();
            this.searchParamIndicatorBonusStr = new System.Windows.Forms.CheckBox();
            this.searchParamBonusStr = new System.Windows.Forms.NumericUpDown();
            this.searchParamIndicatorItemLevel = new System.Windows.Forms.CheckBox();
            this.searchParamItemType = new ItemEditor.ExternalControl.CustomComboBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.inputDialog2 = new Ookii.Dialogs.WinForms.InputDialog(this.components);
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.inventoryPanelControl1 = new ItemEditor.CustomControls.InventoryPanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGeneric)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).BeginInit();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchParamElementalPoison)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchParamElementalLighting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchParamElementalIce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchParamElementalFire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchParamDeffence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchParamAttack)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchParamItemLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchParamBonusMp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchParamBonusInt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchParamBonusDex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchParamBonusHp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchParamBonusStr)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxGeneric
            // 
            this.pictureBoxGeneric.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxGeneric.BackgroundImage")));
            this.pictureBoxGeneric.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxGeneric.IsCreateNewItem = true;
            this.pictureBoxGeneric.IsDeleteItem = false;
            this.pictureBoxGeneric.ItemRepresentation = null;
            this.pictureBoxGeneric.Location = new System.Drawing.Point(36, 3);
            this.pictureBoxGeneric.Name = "pictureBoxGeneric";
            this.pictureBoxGeneric.OriginalIcon = null;
            this.pictureBoxGeneric.Size = new System.Drawing.Size(75, 75);
            this.pictureBoxGeneric.SlotID = 0;
            this.pictureBoxGeneric.TabIndex = 28;
            this.pictureBoxGeneric.TabStop = false;
            this.pictureBoxGeneric.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxGeneric_MouseMove);
            // 
            // searchParamName
            // 
            this.searchParamName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchParamName.Location = new System.Drawing.Point(128, 31);
            this.searchParamName.Name = "searchParamName";
            this.searchParamName.Size = new System.Drawing.Size(119, 27);
            this.searchParamName.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.objectListView1);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.searchParamItemKind);
            this.panel2.Controls.Add(this.searchParamIndicatorItemID);
            this.panel2.Controls.Add(this.searchParamItemID);
            this.panel2.Controls.Add(this.searchParamIndicatorName);
            this.panel2.Controls.Add(this.tableLayoutPanel6);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tableLayoutPanel4);
            this.panel2.Controls.Add(this.searchParamItemType);
            this.panel2.Controls.Add(this.SearchButton);
            this.panel2.Controls.Add(this.searchParamName);
            this.panel2.Location = new System.Drawing.Point(687, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(603, 839);
            this.panel2.TabIndex = 32;
            // 
            // objectListView1
            // 
            this.objectListView1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.objectListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.objectListView1.CellEditUseWholeCell = false;
            this.objectListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.strName});
            this.objectListView1.FullRowSelect = true;
            this.objectListView1.GridLines = true;
            this.objectListView1.Location = new System.Drawing.Point(33, 427);
            this.objectListView1.MultiSelect = false;
            this.objectListView1.Name = "objectListView1";
            this.objectListView1.ShowGroups = false;
            this.objectListView1.Size = new System.Drawing.Size(263, 355);
            this.objectListView1.TabIndex = 60;
            this.objectListView1.View = System.Windows.Forms.View.Details;
            this.objectListView1.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.ObjectListView1_ItemDrag);
            this.objectListView1.SelectedIndexChanged += new System.EventHandler(this.objectListView1_SelectedIndexChanged);
            // 
            // strName
            // 
            this.strName.AspectName = "strName";
            this.strName.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.strName.IsEditable = false;
            this.strName.Sortable = false;
            this.strName.Text = "Item Name";
            this.strName.Width = 263;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.CopyItemID);
            this.panel5.Controls.Add(this.SearchInfoItemRichTextBox);
            this.panel5.Controls.Add(this.pictureBoxGeneric);
            this.panel5.Location = new System.Drawing.Point(324, 414);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(254, 368);
            this.panel5.TabIndex = 59;
            // 
            // CopyItemID
            // 
            this.CopyItemID.Location = new System.Drawing.Point(139, 33);
            this.CopyItemID.Name = "CopyItemID";
            this.CopyItemID.Size = new System.Drawing.Size(89, 36);
            this.CopyItemID.TabIndex = 34;
            this.CopyItemID.Text = "Copy ID";
            this.CopyItemID.UseVisualStyleBackColor = true;
            this.CopyItemID.Click += new System.EventHandler(this.CopyItemNum_Click);
            // 
            // SearchInfoItemRichTextBox
            // 
            this.SearchInfoItemRichTextBox.BackColor = System.Drawing.Color.Black;
            this.SearchInfoItemRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchInfoItemRichTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SearchInfoItemRichTextBox.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SearchInfoItemRichTextBox.ForeColor = System.Drawing.Color.MediumOrchid;
            this.SearchInfoItemRichTextBox.Location = new System.Drawing.Point(0, 91);
            this.SearchInfoItemRichTextBox.Name = "SearchInfoItemRichTextBox";
            this.SearchInfoItemRichTextBox.Size = new System.Drawing.Size(254, 277);
            this.SearchInfoItemRichTextBox.TabIndex = 33;
            this.SearchInfoItemRichTextBox.TabStop = false;
            this.SearchInfoItemRichTextBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label3.Location = new System.Drawing.Point(311, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 57;
            this.label3.Text = "Item Kind";
            this.label3.Visible = false;
            // 
            // searchParamItemKind
            // 
            this.searchParamItemKind.BackColor = System.Drawing.Color.White;
            this.searchParamItemKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchParamItemKind.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchParamItemKind.FormattingEnabled = true;
            this.searchParamItemKind.Items.AddRange(new object[] {
            "Everything",
            "Ubgrade Item",
            "Unique Item",
            "Craft Item",
            "RareI tem",
            "Magic Item",
            "Normal Item",
            "Event Type"});
            this.searchParamItemKind.Location = new System.Drawing.Point(400, 64);
            this.searchParamItemKind.Name = "searchParamItemKind";
            this.searchParamItemKind.Size = new System.Drawing.Size(133, 26);
            this.searchParamItemKind.TabIndex = 56;
            this.searchParamItemKind.Visible = false;
            // 
            // searchParamIndicatorItemID
            // 
            this.searchParamIndicatorItemID.AutoSize = true;
            this.searchParamIndicatorItemID.BackColor = System.Drawing.Color.Transparent;
            this.searchParamIndicatorItemID.ForeColor = System.Drawing.Color.NavajoWhite;
            this.searchParamIndicatorItemID.Location = new System.Drawing.Point(43, 63);
            this.searchParamIndicatorItemID.Name = "searchParamIndicatorItemID";
            this.searchParamIndicatorItemID.Size = new System.Drawing.Size(77, 24);
            this.searchParamIndicatorItemID.TabIndex = 55;
            this.searchParamIndicatorItemID.TabStop = true;
            this.searchParamIndicatorItemID.Text = "Item Id";
            this.searchParamIndicatorItemID.UseVisualStyleBackColor = false;
            // 
            // searchParamItemID
            // 
            this.searchParamItemID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchParamItemID.Location = new System.Drawing.Point(128, 63);
            this.searchParamItemID.Name = "searchParamItemID";
            this.searchParamItemID.Size = new System.Drawing.Size(119, 27);
            this.searchParamItemID.TabIndex = 54;
            // 
            // searchParamIndicatorName
            // 
            this.searchParamIndicatorName.AutoSize = true;
            this.searchParamIndicatorName.BackColor = System.Drawing.Color.Transparent;
            this.searchParamIndicatorName.ForeColor = System.Drawing.Color.NavajoWhite;
            this.searchParamIndicatorName.Location = new System.Drawing.Point(43, 31);
            this.searchParamIndicatorName.Name = "searchParamIndicatorName";
            this.searchParamIndicatorName.Size = new System.Drawing.Size(70, 24);
            this.searchParamIndicatorName.TabIndex = 53;
            this.searchParamIndicatorName.TabStop = true;
            this.searchParamIndicatorName.Text = "Name";
            this.searchParamIndicatorName.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel6.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.searchParamIndicatorElementalPoison, 0, 5);
            this.tableLayoutPanel6.Controls.Add(this.searchParamElementalPoison, 0, 5);
            this.tableLayoutPanel6.Controls.Add(this.searchParamElementalLighting, 1, 4);
            this.tableLayoutPanel6.Controls.Add(this.searchParamIndicatorElementalLighting, 0, 4);
            this.tableLayoutPanel6.Controls.Add(this.searchParamElementalIce, 1, 3);
            this.tableLayoutPanel6.Controls.Add(this.searchParamIndicatorElementalIce, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.searchParamElementalFire, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.searchParamIndicatorElementalFire, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.searchParamDeffence, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.searchParamIndicatorDeffence, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.searchParamAttack, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.searchParamIndicatorAttack, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(324, 113);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 6;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(209, 223);
            this.tableLayoutPanel6.TabIndex = 52;
            // 
            // searchParamIndicatorElementalPoison
            // 
            this.searchParamIndicatorElementalPoison.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.searchParamIndicatorElementalPoison.AutoSize = true;
            this.searchParamIndicatorElementalPoison.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchParamIndicatorElementalPoison.ForeColor = System.Drawing.Color.NavajoWhite;
            this.searchParamIndicatorElementalPoison.Location = new System.Drawing.Point(4, 193);
            this.searchParamIndicatorElementalPoison.Name = "searchParamIndicatorElementalPoison";
            this.searchParamIndicatorElementalPoison.Size = new System.Drawing.Size(107, 22);
            this.searchParamIndicatorElementalPoison.TabIndex = 62;
            this.searchParamIndicatorElementalPoison.Text = "Poison Dmg";
            this.searchParamIndicatorElementalPoison.UseVisualStyleBackColor = true;
            // 
            // searchParamElementalPoison
            // 
            this.searchParamElementalPoison.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.searchParamElementalPoison.Location = new System.Drawing.Point(118, 190);
            this.searchParamElementalPoison.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.searchParamElementalPoison.Name = "searchParamElementalPoison";
            this.searchParamElementalPoison.Size = new System.Drawing.Size(87, 27);
            this.searchParamElementalPoison.TabIndex = 61;
            // 
            // searchParamElementalLighting
            // 
            this.searchParamElementalLighting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.searchParamElementalLighting.Location = new System.Drawing.Point(118, 153);
            this.searchParamElementalLighting.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.searchParamElementalLighting.Name = "searchParamElementalLighting";
            this.searchParamElementalLighting.Size = new System.Drawing.Size(87, 27);
            this.searchParamElementalLighting.TabIndex = 60;
            // 
            // searchParamIndicatorElementalLighting
            // 
            this.searchParamIndicatorElementalLighting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.searchParamIndicatorElementalLighting.AutoSize = true;
            this.searchParamIndicatorElementalLighting.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchParamIndicatorElementalLighting.ForeColor = System.Drawing.Color.NavajoWhite;
            this.searchParamIndicatorElementalLighting.Location = new System.Drawing.Point(4, 156);
            this.searchParamIndicatorElementalLighting.Name = "searchParamIndicatorElementalLighting";
            this.searchParamIndicatorElementalLighting.Size = new System.Drawing.Size(107, 22);
            this.searchParamIndicatorElementalLighting.TabIndex = 59;
            this.searchParamIndicatorElementalLighting.Text = "Light Dmg";
            this.searchParamIndicatorElementalLighting.UseVisualStyleBackColor = true;
            // 
            // searchParamElementalIce
            // 
            this.searchParamElementalIce.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.searchParamElementalIce.Location = new System.Drawing.Point(118, 116);
            this.searchParamElementalIce.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.searchParamElementalIce.Name = "searchParamElementalIce";
            this.searchParamElementalIce.Size = new System.Drawing.Size(87, 27);
            this.searchParamElementalIce.TabIndex = 58;
            // 
            // searchParamIndicatorElementalIce
            // 
            this.searchParamIndicatorElementalIce.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.searchParamIndicatorElementalIce.AutoSize = true;
            this.searchParamIndicatorElementalIce.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchParamIndicatorElementalIce.ForeColor = System.Drawing.Color.NavajoWhite;
            this.searchParamIndicatorElementalIce.Location = new System.Drawing.Point(4, 119);
            this.searchParamIndicatorElementalIce.Name = "searchParamIndicatorElementalIce";
            this.searchParamIndicatorElementalIce.Size = new System.Drawing.Size(107, 22);
            this.searchParamIndicatorElementalIce.TabIndex = 57;
            this.searchParamIndicatorElementalIce.Text = "Ice Dmg";
            this.searchParamIndicatorElementalIce.UseVisualStyleBackColor = true;
            // 
            // searchParamElementalFire
            // 
            this.searchParamElementalFire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.searchParamElementalFire.Location = new System.Drawing.Point(118, 79);
            this.searchParamElementalFire.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.searchParamElementalFire.Name = "searchParamElementalFire";
            this.searchParamElementalFire.Size = new System.Drawing.Size(87, 27);
            this.searchParamElementalFire.TabIndex = 56;
            // 
            // searchParamIndicatorElementalFire
            // 
            this.searchParamIndicatorElementalFire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.searchParamIndicatorElementalFire.AutoSize = true;
            this.searchParamIndicatorElementalFire.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchParamIndicatorElementalFire.ForeColor = System.Drawing.Color.NavajoWhite;
            this.searchParamIndicatorElementalFire.Location = new System.Drawing.Point(4, 82);
            this.searchParamIndicatorElementalFire.Name = "searchParamIndicatorElementalFire";
            this.searchParamIndicatorElementalFire.Size = new System.Drawing.Size(107, 22);
            this.searchParamIndicatorElementalFire.TabIndex = 55;
            this.searchParamIndicatorElementalFire.Text = "Fire Dmg";
            this.searchParamIndicatorElementalFire.UseVisualStyleBackColor = true;
            // 
            // searchParamDeffence
            // 
            this.searchParamDeffence.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.searchParamDeffence.Location = new System.Drawing.Point(118, 42);
            this.searchParamDeffence.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.searchParamDeffence.Name = "searchParamDeffence";
            this.searchParamDeffence.Size = new System.Drawing.Size(87, 27);
            this.searchParamDeffence.TabIndex = 54;
            // 
            // searchParamIndicatorDeffence
            // 
            this.searchParamIndicatorDeffence.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.searchParamIndicatorDeffence.AutoSize = true;
            this.searchParamIndicatorDeffence.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchParamIndicatorDeffence.ForeColor = System.Drawing.Color.NavajoWhite;
            this.searchParamIndicatorDeffence.Location = new System.Drawing.Point(4, 45);
            this.searchParamIndicatorDeffence.Name = "searchParamIndicatorDeffence";
            this.searchParamIndicatorDeffence.Size = new System.Drawing.Size(107, 22);
            this.searchParamIndicatorDeffence.TabIndex = 53;
            this.searchParamIndicatorDeffence.Text = "Deffence";
            this.searchParamIndicatorDeffence.UseVisualStyleBackColor = true;
            // 
            // searchParamAttack
            // 
            this.searchParamAttack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.searchParamAttack.Location = new System.Drawing.Point(118, 5);
            this.searchParamAttack.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.searchParamAttack.Name = "searchParamAttack";
            this.searchParamAttack.Size = new System.Drawing.Size(87, 27);
            this.searchParamAttack.TabIndex = 52;
            // 
            // searchParamIndicatorAttack
            // 
            this.searchParamIndicatorAttack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.searchParamIndicatorAttack.AutoSize = true;
            this.searchParamIndicatorAttack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.searchParamIndicatorAttack.FlatAppearance.BorderSize = 2;
            this.searchParamIndicatorAttack.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.searchParamIndicatorAttack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.searchParamIndicatorAttack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.searchParamIndicatorAttack.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchParamIndicatorAttack.ForeColor = System.Drawing.Color.NavajoWhite;
            this.searchParamIndicatorAttack.Location = new System.Drawing.Point(4, 8);
            this.searchParamIndicatorAttack.Name = "searchParamIndicatorAttack";
            this.searchParamIndicatorAttack.Size = new System.Drawing.Size(107, 22);
            this.searchParamIndicatorAttack.TabIndex = 51;
            this.searchParamIndicatorAttack.Text = "Attack";
            this.searchParamIndicatorAttack.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label1.Location = new System.Drawing.Point(311, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 51;
            this.label1.Text = "Item Type";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.searchParamItemLevel, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.searchParamIndicatorBonusMp, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.searchParamBonusMp, 1, 5);
            this.tableLayoutPanel4.Controls.Add(this.searchParamBonusInt, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.searchParamIndicatorBonusInt, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.searchParamIndicatorBonusDex, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.searchParamBonusDex, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.searchParamBonusHp, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.searchParamIndicatorBonusHp, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.searchParamIndicatorBonusStr, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.searchParamBonusStr, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.searchParamIndicatorItemLevel, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(43, 107);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 6;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(209, 223);
            this.tableLayoutPanel4.TabIndex = 50;
            // 
            // searchParamItemLevel
            // 
            this.searchParamItemLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.searchParamItemLevel.Location = new System.Drawing.Point(112, 5);
            this.searchParamItemLevel.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.searchParamItemLevel.Name = "searchParamItemLevel";
            this.searchParamItemLevel.Size = new System.Drawing.Size(93, 27);
            this.searchParamItemLevel.TabIndex = 57;
            // 
            // searchParamIndicatorBonusMp
            // 
            this.searchParamIndicatorBonusMp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.searchParamIndicatorBonusMp.AutoSize = true;
            this.searchParamIndicatorBonusMp.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchParamIndicatorBonusMp.ForeColor = System.Drawing.Color.NavajoWhite;
            this.searchParamIndicatorBonusMp.Location = new System.Drawing.Point(4, 193);
            this.searchParamIndicatorBonusMp.Name = "searchParamIndicatorBonusMp";
            this.searchParamIndicatorBonusMp.Size = new System.Drawing.Size(101, 22);
            this.searchParamIndicatorBonusMp.TabIndex = 59;
            this.searchParamIndicatorBonusMp.Text = "Mp Bonus";
            this.searchParamIndicatorBonusMp.UseVisualStyleBackColor = true;
            // 
            // searchParamBonusMp
            // 
            this.searchParamBonusMp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.searchParamBonusMp.Location = new System.Drawing.Point(112, 190);
            this.searchParamBonusMp.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.searchParamBonusMp.Name = "searchParamBonusMp";
            this.searchParamBonusMp.Size = new System.Drawing.Size(93, 27);
            this.searchParamBonusMp.TabIndex = 60;
            // 
            // searchParamBonusInt
            // 
            this.searchParamBonusInt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.searchParamBonusInt.Location = new System.Drawing.Point(112, 153);
            this.searchParamBonusInt.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.searchParamBonusInt.Name = "searchParamBonusInt";
            this.searchParamBonusInt.Size = new System.Drawing.Size(93, 27);
            this.searchParamBonusInt.TabIndex = 58;
            // 
            // searchParamIndicatorBonusInt
            // 
            this.searchParamIndicatorBonusInt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.searchParamIndicatorBonusInt.AutoSize = true;
            this.searchParamIndicatorBonusInt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchParamIndicatorBonusInt.ForeColor = System.Drawing.Color.NavajoWhite;
            this.searchParamIndicatorBonusInt.Location = new System.Drawing.Point(4, 156);
            this.searchParamIndicatorBonusInt.Name = "searchParamIndicatorBonusInt";
            this.searchParamIndicatorBonusInt.Size = new System.Drawing.Size(101, 22);
            this.searchParamIndicatorBonusInt.TabIndex = 57;
            this.searchParamIndicatorBonusInt.Text = "Int Bonus";
            this.searchParamIndicatorBonusInt.UseVisualStyleBackColor = true;
            // 
            // searchParamIndicatorBonusDex
            // 
            this.searchParamIndicatorBonusDex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.searchParamIndicatorBonusDex.AutoSize = true;
            this.searchParamIndicatorBonusDex.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchParamIndicatorBonusDex.ForeColor = System.Drawing.Color.NavajoWhite;
            this.searchParamIndicatorBonusDex.Location = new System.Drawing.Point(4, 119);
            this.searchParamIndicatorBonusDex.Name = "searchParamIndicatorBonusDex";
            this.searchParamIndicatorBonusDex.Size = new System.Drawing.Size(101, 22);
            this.searchParamIndicatorBonusDex.TabIndex = 55;
            this.searchParamIndicatorBonusDex.Text = "Dex Bonus";
            this.searchParamIndicatorBonusDex.UseVisualStyleBackColor = true;
            // 
            // searchParamBonusDex
            // 
            this.searchParamBonusDex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.searchParamBonusDex.Location = new System.Drawing.Point(112, 116);
            this.searchParamBonusDex.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.searchParamBonusDex.Name = "searchParamBonusDex";
            this.searchParamBonusDex.Size = new System.Drawing.Size(93, 27);
            this.searchParamBonusDex.TabIndex = 56;
            // 
            // searchParamBonusHp
            // 
            this.searchParamBonusHp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.searchParamBonusHp.Location = new System.Drawing.Point(112, 79);
            this.searchParamBonusHp.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.searchParamBonusHp.Name = "searchParamBonusHp";
            this.searchParamBonusHp.Size = new System.Drawing.Size(93, 27);
            this.searchParamBonusHp.TabIndex = 54;
            // 
            // searchParamIndicatorBonusHp
            // 
            this.searchParamIndicatorBonusHp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.searchParamIndicatorBonusHp.AutoSize = true;
            this.searchParamIndicatorBonusHp.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchParamIndicatorBonusHp.ForeColor = System.Drawing.Color.NavajoWhite;
            this.searchParamIndicatorBonusHp.Location = new System.Drawing.Point(4, 82);
            this.searchParamIndicatorBonusHp.Name = "searchParamIndicatorBonusHp";
            this.searchParamIndicatorBonusHp.Size = new System.Drawing.Size(101, 22);
            this.searchParamIndicatorBonusHp.TabIndex = 53;
            this.searchParamIndicatorBonusHp.Text = "Hp Bonus";
            this.searchParamIndicatorBonusHp.UseVisualStyleBackColor = true;
            // 
            // searchParamIndicatorBonusStr
            // 
            this.searchParamIndicatorBonusStr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.searchParamIndicatorBonusStr.AutoSize = true;
            this.searchParamIndicatorBonusStr.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.searchParamIndicatorBonusStr.FlatAppearance.BorderSize = 2;
            this.searchParamIndicatorBonusStr.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.searchParamIndicatorBonusStr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.searchParamIndicatorBonusStr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.searchParamIndicatorBonusStr.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchParamIndicatorBonusStr.ForeColor = System.Drawing.Color.NavajoWhite;
            this.searchParamIndicatorBonusStr.Location = new System.Drawing.Point(4, 45);
            this.searchParamIndicatorBonusStr.Name = "searchParamIndicatorBonusStr";
            this.searchParamIndicatorBonusStr.Size = new System.Drawing.Size(101, 22);
            this.searchParamIndicatorBonusStr.TabIndex = 51;
            this.searchParamIndicatorBonusStr.Text = "Str Bonus";
            this.searchParamIndicatorBonusStr.UseVisualStyleBackColor = true;
            // 
            // searchParamBonusStr
            // 
            this.searchParamBonusStr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.searchParamBonusStr.Location = new System.Drawing.Point(112, 42);
            this.searchParamBonusStr.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.searchParamBonusStr.Name = "searchParamBonusStr";
            this.searchParamBonusStr.Size = new System.Drawing.Size(93, 27);
            this.searchParamBonusStr.TabIndex = 52;
            // 
            // searchParamIndicatorItemLevel
            // 
            this.searchParamIndicatorItemLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.searchParamIndicatorItemLevel.AutoSize = true;
            this.searchParamIndicatorItemLevel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.searchParamIndicatorItemLevel.FlatAppearance.BorderSize = 2;
            this.searchParamIndicatorItemLevel.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.searchParamIndicatorItemLevel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.searchParamIndicatorItemLevel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.searchParamIndicatorItemLevel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchParamIndicatorItemLevel.ForeColor = System.Drawing.Color.NavajoWhite;
            this.searchParamIndicatorItemLevel.Location = new System.Drawing.Point(4, 8);
            this.searchParamIndicatorItemLevel.Name = "searchParamIndicatorItemLevel";
            this.searchParamIndicatorItemLevel.Size = new System.Drawing.Size(101, 22);
            this.searchParamIndicatorItemLevel.TabIndex = 56;
            this.searchParamIndicatorItemLevel.Text = "Item Level";
            this.searchParamIndicatorItemLevel.UseVisualStyleBackColor = true;
            // 
            // searchParamItemType
            // 
            this.searchParamItemType.BackColor = System.Drawing.Color.White;
            this.searchParamItemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchParamItemType.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchParamItemType.FormattingEnabled = true;
            this.searchParamItemType.Items.AddRange(new object[] {
            "Everything",
            "Ubgrade Item",
            "Unique Item",
            "Craft Item",
            "RareI tem",
            "Magic Item",
            "Normal Item",
            "Event Type"});
            this.searchParamItemType.Location = new System.Drawing.Point(400, 25);
            this.searchParamItemType.Name = "searchParamItemType";
            this.searchParamItemType.Size = new System.Drawing.Size(133, 26);
            this.searchParamItemType.TabIndex = 34;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.DimGray;
            this.SearchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchButton.BackgroundImage")));
            this.SearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchButton.ForeColor = System.Drawing.Color.NavajoWhite;
            this.SearchButton.Location = new System.Drawing.Point(43, 346);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(209, 46);
            this.SearchButton.TabIndex = 32;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.ForeColor = System.Drawing.Color.NavajoWhite;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 41);
            this.button1.TabIndex = 33;
            this.button1.Text = "LoadUserItems";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.LoadUserInfoButton_Click);
            // 
            // inputDialog2
            // 
            this.inputDialog2.MainInstruction = "Item Count\r\n";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.numericUpDown1, 1, 4);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 5;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown1.Location = new System.Drawing.Point(3, 83);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(194, 27);
            this.numericUpDown1.TabIndex = 60;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.Location = new System.Drawing.Point(3, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 94);
            this.checkBox1.TabIndex = 59;
            this.checkBox1.Text = "Mp Bonus";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // inventoryPanelControl1
            // 
            this.inventoryPanelControl1.BackColor = System.Drawing.Color.Transparent;
            this.inventoryPanelControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventoryPanelControl1.Location = new System.Drawing.Point(12, 59);
            this.inventoryPanelControl1.Name = "inventoryPanelControl1";
            this.inventoryPanelControl1.Size = new System.Drawing.Size(657, 844);
            this.inventoryPanelControl1.TabIndex = 35;
            // 
            // InventoryEditorForm
            // 
            this.AcceptButton = this.SearchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1467, 1001);
            this.Controls.Add(this.inventoryPanelControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "InventoryEditorForm";
            this.Text = "InventoryEditorForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGeneric)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchParamElementalPoison)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchParamElementalLighting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchParamElementalIce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchParamElementalFire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchParamDeffence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchParamAttack)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchParamItemLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchParamBonusMp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchParamBonusInt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchParamBonusDex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchParamBonusHp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchParamBonusStr)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CustomPictureBox pictureBoxGeneric;
        private TextBox searchParamName;
        private Panel panel2;
        private Button SearchButton;
        private Button button1;
        private Ookii.Dialogs.WinForms.InputDialog inputDialog2;
        private CustomComboBox searchParamItemType;
        private TableLayoutPanel tableLayoutPanel4;
        private NumericUpDown searchParamBonusMp;
        private CheckBox searchParamIndicatorBonusMp;
        private NumericUpDown searchParamBonusInt;
        private CheckBox searchParamIndicatorBonusInt;
        private NumericUpDown searchParamBonusDex;
        private CheckBox searchParamIndicatorBonusDex;
        private NumericUpDown searchParamBonusHp;
        private CheckBox searchParamIndicatorBonusHp;
        private NumericUpDown searchParamBonusStr;
        private CheckBox searchParamIndicatorBonusStr;
        private Label label3;
        private CustomComboBox searchParamItemKind;
        private RadioButton searchParamIndicatorItemID;
        private TextBox searchParamItemID;
        private RadioButton searchParamIndicatorName;
        private TableLayoutPanel tableLayoutPanel6;
        private CheckBox searchParamIndicatorElementalPoison;
        private NumericUpDown searchParamElementalPoison;
        private NumericUpDown searchParamElementalLighting;
        private CheckBox searchParamIndicatorElementalLighting;
        private NumericUpDown searchParamElementalIce;
        private CheckBox searchParamIndicatorElementalIce;
        private NumericUpDown searchParamElementalFire;
        private CheckBox searchParamIndicatorElementalFire;
        private NumericUpDown searchParamDeffence;
        private CheckBox searchParamIndicatorDeffence;
        private NumericUpDown searchParamAttack;
        private CheckBox searchParamIndicatorAttack;
        private Label label1;
        private NumericUpDown searchParamItemLevel;
        private CheckBox searchParamIndicatorItemLevel;
        private TableLayoutPanel tableLayoutPanel5;
        private NumericUpDown numericUpDown1;
        private CheckBox checkBox1;
        private Panel panel5;
        private DisabledRichTextBox SearchInfoItemRichTextBox;
        private BrightIdeasSoftware.ObjectListView objectListView1;
        private BrightIdeasSoftware.OLVColumn strName;
        private CustomControls.InventoryPanelControl inventoryPanelControl1;
        private Button CopyItemID;
    }
}