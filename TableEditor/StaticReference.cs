using Newtonsoft.Json;
using ClassDefinitions.Models;
using System.Reflection;
using TableEditor.Encryption;

namespace TblEncodings
{
    public static class TableEditorStatic
    {
        public static readonly Dictionary<string, List<TableEditorModelBinding>> ItemTableHeaders;

        public static readonly List<KOEncryptionBase> EncryptionMethods = new List<KOEncryptionBase>
        {
            new KOEncryptionStandart(),
            new KOEncryptionChaosExpansion(),
            new KOEncryptionNoEncryption(),
            new KOEncryptionForgottenFrontiers()
        };

        static TableEditorStatic()
        {
            ItemTableHeaders = LoadTableEditorBinding();
        }

        #region Known table headers

        /// <summary>
        /// Table definition mapping object
        /// </summary>
        private static Dictionary<string, List<TableEditorModelBinding>> LoadTableEditorBinding()
        {
            var itemTableToDatabaseBinding = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), $@"Resources\Json\ItemTableHeadersBinding.json");
            var json = File.ReadAllText(itemTableToDatabaseBinding);
            var itemTableHeaders = JsonConvert.DeserializeObject<Dictionary<string, List<TableEditorModelBinding>>>(json);
            return itemTableHeaders;
        }

        public static void SerializeToJsonFile(Dictionary<string, List<TableEditorModelBinding>> dictionary, string filePath)
        {
            var json = JsonConvert.SerializeObject(filePath, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        #endregion
    }
}
