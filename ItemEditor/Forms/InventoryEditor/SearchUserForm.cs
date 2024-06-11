using ItemEditor.Static;
using ItemEditor.Extensions;
using System.Data;
using static DataAccessLayer.DatabaseOperationBase;
using DataAccessLayer;

namespace ItemEditor.Forms
{
    public partial class SearchUserForm : Form
    {
        List<CharacterInfo> AllCharactersInfo = new List<CharacterInfo>();
        List<ListViewItem> characterInfoListViewItems = new List<ListViewItem>();

        public SearchUserForm()
        {
            InitializeComponent();
        }

        public void InitializeCharacterInfo()
        {
            PlayersListView.Items.Clear(); // clear list items before adding 
            characterInfoListViewItems.Clear();
            AllCharactersInfo = new List<CharacterInfo>();
            AllCharactersInfo = CoreServices.DatabaseManager.GetAllCharacterInfo();

            foreach (var characterInfo in AllCharactersInfo)
            {
                characterInfoListViewItems.Add(new ListViewItem(new string[] {
                    characterInfo.Name,
                    characterInfo.Level.ToString(),
                    characterInfo.ClanName }
                ));
            }

            PlayersListView.Items.AddRange(characterInfoListViewItems.ToArray());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            PlayersListView.Items.Clear(); // clear list items before adding 
            PlayersListView.Items.AddRange(characterInfoListViewItems.Where(index => index.Text.ToLower().Contains(CharacterNameTextBox.Text.ToLower())).ToArray());
        }

        private void LoadCharacterInventoryButton_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            if (this.PlayersListView.SelectedItems.Count != 0 )
            {
                StaticValues.PlayerName = this.PlayersListView.SelectedItems[0].Text.RemoveWhitespces();
                CoreServices.inventoryEditorForm.LoadUserInfo();
                CoreServices.inventoryEditorForm.Show();
                CoreServices.inventoryEditorForm.BringToFront();
            }

            Cursor = Cursors.Arrow;
        }

        private void ReloadCharactersButton_Click(object sender, EventArgs e)
        {
            this.InitializeCharacterInfo();
        }
    }
}
