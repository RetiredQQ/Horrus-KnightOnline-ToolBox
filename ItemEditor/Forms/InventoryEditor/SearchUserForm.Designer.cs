namespace ItemEditor.Forms
{
    partial class SearchUserForm
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
            this.SearchUserPanel = new System.Windows.Forms.Panel();
            this.LoadCharacterInventoryButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CharacterNameTextBox = new System.Windows.Forms.TextBox();
            this.PlayersListView = new System.Windows.Forms.ListView();
            this.CharacterNameColumn = new System.Windows.Forms.ColumnHeader();
            this.CharacterLevelColumn = new System.Windows.Forms.ColumnHeader();
            this.ClanNameColumn = new System.Windows.Forms.ColumnHeader();
            this.ReloadCharactersButton = new System.Windows.Forms.Button();
            this.SearchUserPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchUserPanel
            // 
            this.SearchUserPanel.Controls.Add(this.ReloadCharactersButton);
            this.SearchUserPanel.Controls.Add(this.LoadCharacterInventoryButton);
            this.SearchUserPanel.Controls.Add(this.label1);
            this.SearchUserPanel.Controls.Add(this.CharacterNameTextBox);
            this.SearchUserPanel.Controls.Add(this.PlayersListView);
            this.SearchUserPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchUserPanel.Location = new System.Drawing.Point(0, 0);
            this.SearchUserPanel.Name = "SearchUserPanel";
            this.SearchUserPanel.Size = new System.Drawing.Size(572, 567);
            this.SearchUserPanel.TabIndex = 0;
            // 
            // LoadCharacterInventoryButton
            // 
            this.LoadCharacterInventoryButton.Location = new System.Drawing.Point(287, 79);
            this.LoadCharacterInventoryButton.Name = "LoadCharacterInventoryButton";
            this.LoadCharacterInventoryButton.Size = new System.Drawing.Size(94, 29);
            this.LoadCharacterInventoryButton.TabIndex = 3;
            this.LoadCharacterInventoryButton.Text = "Load";
            this.LoadCharacterInventoryButton.UseVisualStyleBackColor = true;
            this.LoadCharacterInventoryButton.Click += new System.EventHandler(this.LoadCharacterInventoryButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Character Name";
            // 
            // CharacterNameTextBox
            // 
            this.CharacterNameTextBox.Location = new System.Drawing.Point(43, 80);
            this.CharacterNameTextBox.Name = "CharacterNameTextBox";
            this.CharacterNameTextBox.Size = new System.Drawing.Size(181, 27);
            this.CharacterNameTextBox.TabIndex = 1;
            this.CharacterNameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PlayersListView
            // 
            this.PlayersListView.BackColor = System.Drawing.SystemColors.HighlightText;
            this.PlayersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CharacterNameColumn,
            this.CharacterLevelColumn,
            this.ClanNameColumn});
            this.PlayersListView.FullRowSelect = true;
            this.PlayersListView.GridLines = true;
            this.PlayersListView.Location = new System.Drawing.Point(43, 153);
            this.PlayersListView.MultiSelect = false;
            this.PlayersListView.Name = "PlayersListView";
            this.PlayersListView.Size = new System.Drawing.Size(457, 372);
            this.PlayersListView.TabIndex = 0;
            this.PlayersListView.UseCompatibleStateImageBehavior = false;
            this.PlayersListView.View = System.Windows.Forms.View.Details;
            // 
            // CharacterNameColumn
            // 
            this.CharacterNameColumn.Text = "Character Name";
            this.CharacterNameColumn.Width = 180;
            // 
            // CharacterLevelColumn
            // 
            this.CharacterLevelColumn.Text = "Level";
            this.CharacterLevelColumn.Width = 80;
            // 
            // ClanNameColumn
            // 
            this.ClanNameColumn.Text = "Clan";
            this.ClanNameColumn.Width = 180;
            // 
            // ReloadCharactersButton
            // 
            this.ReloadCharactersButton.Location = new System.Drawing.Point(406, 78);
            this.ReloadCharactersButton.Name = "ReloadCharactersButton";
            this.ReloadCharactersButton.Size = new System.Drawing.Size(94, 29);
            this.ReloadCharactersButton.TabIndex = 4;
            this.ReloadCharactersButton.Text = "Reload";
            this.ReloadCharactersButton.UseVisualStyleBackColor = true;
            this.ReloadCharactersButton.Click += new System.EventHandler(this.ReloadCharactersButton_Click);
            // 
            // SearchUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 567);
            this.Controls.Add(this.SearchUserPanel);
            this.Name = "SearchUserForm";
            this.Text = "SearchUserForm";
            this.SearchUserPanel.ResumeLayout(false);
            this.SearchUserPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel SearchUserPanel;
        private Label label1;
        private TextBox CharacterNameTextBox;
        private ListView PlayersListView;
        private ColumnHeader CharacterNameColumn;
        private ColumnHeader CharacterLevelColumn;
        private ColumnHeader ClanNameColumn;
        private Button LoadCharacterInventoryButton;
        private Button ReloadCharactersButton;
    }
}