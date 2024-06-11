using Newtonsoft.Json;
using ClassDefinitions.Models;
using System.Reflection;
using TableEditor.Encryption;

namespace TblEncodings
{
    public static class TableEditorStatic
    {
        //private static readonly object TableLock = new object();
        //public static Dictionary<string, KOTableFile> Tables = new Dictionary<string, KOTableFile>();

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
            //ReadCustomEncryptions();
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

        #region Table operation

        //public static void AddNewTable(KOTableFile table)
        //{
        //    lock (TableLock)
        //    {
        //        if (Tables.ContainsKey(table.FileInformation.FullName))
        //            //throw new Exception("The specified table is already open.");
        //            return;
        //        Tables[table.FullName] = table;
        //    }
        //}

        //public static KOTableFile GetTableByFullName(string tableName)
        //{
        //    lock (TableLock)
        //    {
        //        if (Tables.ContainsKey(tableName))
        //            return Tables[tableName];
        //    }
        //    return null;
        //}

        //public static void RemoveTableByFullName(string tableName)
        //{
        //    lock (TableLock)
        //    {
        //        KOTableFile tbl = GetTableByFullName(tableName);
        //        if (tbl != null)
        //        {
        //            Tables.Remove(tbl.FullName);
        //        }
        //        else
        //        {
        //            throw new Exception("The table with given name does not exist.");
        //        }
        //    }
        //}
        #endregion

        #region ReadCustomEncryptions

        //private static void ReadCustomEncryptions()
        //{
        //    // ShowInformation(null, AppDomain.CurrentDomain.BaseDirectory);
        //    if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\Encryption"))
        //        return;

        //    foreach (var file in Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory + "\\Encryption"))
        //    {
        //        var fi = new FileInfo(file);
        //        if (!fi.Exists || fi.Extension != ".xml" || fi.Name == "Sample.xml")
        //            continue;

        //        var doc = XDocument.Load(fi.FullName);
        //        string name = "no name", desc = "no desc";
        //        ushort vkey = 0x0816, ckey1 = 0x6081, ckey2 = 0x1608;
        //        if (doc.Root != null)
        //            foreach (var v in doc.Root.Elements())
        //            {

        //                if (v.Name == "Name")
        //                    name = v.Value;

        //                else if (v.Name == "Desc")
        //                    desc = v.Value;
        //                else if (v.Name == "VolatileKey")
        //                    vkey = Convert.ToUInt16(v.Value, 16);
        //                else if (v.Name == "CipherKey1")
        //                    ckey1 = Convert.ToUInt16(v.Value, 16);
        //                else if (v.Name == "CipherKey2")
        //                    ckey2 = Convert.ToUInt16(v.Value, 16);

        //            }

        //        EncryptionMethods.Add(new KOEncryptionStandartCustom(name, desc, vkey, ckey1, ckey2));
        //    }
        //}

        #endregion
    }
}
