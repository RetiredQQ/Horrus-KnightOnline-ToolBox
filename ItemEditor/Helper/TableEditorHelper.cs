using ItemEditor.Static;
using System.Data;
using TableEditor;
using TblEncodings;
using ClassDefinitions.Models.Encryption;

namespace ItemEditor.Helper
{
    public class TableEditorHelper
    {
        public static KOTableFile DecodeTableFile(string fileName)
        {
            var fileInfo = new FileInfo(fileName);
            if (!fileInfo.Exists)
            {
                CoreServices.Logger.ShowWarning(string.Format(LanguageManager.Get("Message_FileOpenError"), fileName));
                return null;
            }

            foreach (var encryptionMethod in TableEditorStatic.EncryptionMethods)
            {
                DataTable table = encryptionMethod.GetDataTableFromFile(fileName, fileInfo.Name);
                if (table == null)
                    continue;
                else
                {
                    return new KOTableFile(fileInfo, table, encryptionMethod);
                }
            }

            CoreServices.Logger.ShowWarning(string.Format(LanguageManager.Get("Message_FileEncryptionError"), fileInfo.Name));
            return null;
        }

        /// <summary>
        /// Add headers to the DataGridView
        /// </summary>
        public static void AddHeadersToDataGriedView(KOTableFile newTable, DataGridView dataGridView1, ComboBox filterColumn)
        {
            List<string> ColumnNames = new List<string>();
            
            try
            {
                foreach (var tableHeaders in TableEditorStatic.ItemTableHeaders.Where(v => newTable.Name.ToLowerInvariant().Contains(v.Key)))
                {
                    for (var index = 0; index < newTable.Table.Columns.Count; index++)
                    {
                        if (index < tableHeaders.Value.Count)
                        {
                            newTable.Table.Columns[index].Caption = string.Format("{0}\n{1}\n{2}",
                                tableHeaders.Value[index],
                                index,
                                ColumnTypes.GetColumnTypeNameFromFullName(newTable.Table.Columns[index].DataType.FullName));

                            var columnNameTemp = tableHeaders.Value.ElementAt(index).TableFileHeader.Equals("Unknown") ? $"Unknown{index}" : tableHeaders.Value.ElementAt(index).TableFileHeader;
                            newTable.Table.Columns[index].ColumnName = columnNameTemp;
                            ColumnNames.Add(columnNameTemp);
                        }
                        else
                        {
                            newTable.Table.Columns[index].ColumnName = $"ColumName{index}";
                            ColumnNames.Add(newTable.Table.Columns[index].ColumnName);
                        }
                    }
                }

                if (ColumnNames.ToArray().Length == 0)
                {
                    for (int i = 0; i < newTable.Table.Columns.Count; i++)
                    {
                        newTable.Table.Columns[i].ColumnName = $"ColumName{i}";
                        ColumnNames.Add(newTable.Table.Columns[i].ColumnName);
                    }
                }

                filterColumn.Items.AddRange(ColumnNames.ToArray());
                dataGridView1.DataSource = newTable.Table;
            }
            catch (Exception exception)
            {
                CoreServices.Logger.ShowError(exception.Message);
            }
        }
    }
}
