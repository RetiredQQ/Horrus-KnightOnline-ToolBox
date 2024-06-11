using DataAccessLayer.Interfaces;
using DataAccessLayer;
using ItemEditor.Forms;
using ItemEditor.StaticClasses;
using ItemEditor.Helper;
using ItemEditor.Forms.TableEditor;
using ClassDefinitions.Models.Configuration;
using ItemEditor.Forms.ItemCreator;

namespace ItemEditor.Static
{
    public class CoreServices
    {
        #region Side Panel Forms

        public static InventoryEditorForm inventoryEditorForm = new InventoryEditorForm();
        public static SearchUserForm searchUserForm = new SearchUserForm();
        public static TableEditorForm TableEditorForm = new TableEditorForm();
        public static ItemCreatorForm ItemCreatorForm;

        #endregion

        public static LogFileHelper Logger = new LogFileHelper();

        public static ConfigManager ConfigManager = new ConfigManager();

        public static ImageHelper ImageHelper = new ImageHelper();

        public static IDatabaseOperationManager DatabaseManager = new DatabaseOperationManagerV1298();
    }
}
