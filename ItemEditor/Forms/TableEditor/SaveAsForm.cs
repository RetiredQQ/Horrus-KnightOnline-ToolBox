using ItemEditor.Static;
using System.Data;
using TableEditor;
using TblEncodings;

namespace ItemEditor.Forms.TableEditor
{
    public partial class SaveAsForm : Form
    {
        private readonly KOTableFile kOTableFile;

        public SaveAsForm(KOTableFile koTableFile)
        {
            InitializeComponent();
            this.kOTableFile = koTableFile;
        }

        private void SaveAsForm_Load(object sender, EventArgs e)
        {
            foreach (var v in TableEditorStatic.EncryptionMethods)
            {
                cbEncryptionList.Items.Add(v.Name());
            }
        }

        private void cbEncryptionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var v in TableEditorStatic.EncryptionMethods.Where(v => string.Compare(v.Name(), cbEncryptionList.Text, StringComparison.Ordinal) == 0))
            {
                meDescription.Text = v.Description();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog())
            {
                sfd.Title = @"Select path and enter filename";
                sfd.Filter = @"Knight OnLine data tables |*.tbl";
                sfd.OverwritePrompt = true;
                if (DialogResult.OK == sfd.ShowDialog())
                {
                    if (this.kOTableFile == null)
                    {
                        CoreServices.Logger.ShowError(LanguageManager.Get("Message_FileNotOpen"));
                        Close();
                        return;
                    }

                    foreach (var v in TableEditorStatic.EncryptionMethods.Where(v => string.Compare(v.Name(), cbEncryptionList.Text, StringComparison.Ordinal) == 0))
                    {
                        this.kOTableFile.SetEncryption(v);
                    }
                    this.kOTableFile.SaveAs(sfd.FileName);
                    CoreServices.Logger.ShowInformation(LanguageManager.Get("Message_Done"));
                    Close();
                    // tePath.Text = sfd.FileName;
                }
            }
        }
    }
}
