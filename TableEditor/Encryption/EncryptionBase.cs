using ClassDefinitions.Models.Encryption;
using System.Data;
using System.Diagnostics;
using System.Reflection;
using System.Text;

namespace TableEditor.Encryption
{
    public abstract class KOEncryptionBase
    {
        public static char[] SignatureOfAuthor = { 'E', 'D', 'I', 'T', 'E', 'D', 'W', 'I', 'T', 'H', 'P', 'E', 'N', 'T', 'A', 'G', 'R', 'A', 'M', 'T', 'B', 'L', 'E', 'D', 'I', 'T', 'O', 'R', 'H', 'T', 'T', 'P', 'S', ':', '\\', '\\', 'W', 'W', 'W', '.', 'K', 'O', 'D', 'E', 'V', 'E', 'L', 'O', 'P', 'E', 'R', 'S', '.', 'C', 'O', 'M' };


        public abstract String Name();
        public abstract String Description();
        public abstract void Decode(ref byte[] data);
        public abstract void Encode(FileStream plainStream);
        public void AfterEncode(FileStream plainStream)
        {
            foreach (byte t in SignatureOfAuthor)
                plainStream.WriteByte(t);

        }
        public abstract bool NewTableStructure();
        public int UnknownInteger { get; private set; }
        public byte UnknownByte { get; private set; }
        public byte[]? Padding = null;
 
        /* 
         * Decodes the given file, and returns byte array of decoded file. 
         */
        public byte[] DecodeFileIntoByteArray(string fileName)
        {/* Load the file */
            var buffer = File.ReadAllBytes(fileName);
            Decode(ref buffer);
            if (NewTableStructure())
            {
                Trace.WriteLine(string.Format("Integer : {0} , Byte {1}", BitConverter.ToInt32(buffer, 0), buffer[4]));
            }
            return buffer;
        }

        private  DataTable GetTableFromDecodedBytes(byte[] fileData, string tableName)
        {
            using (var ms = new MemoryStream(fileData))
            {
                using (var br = new BinaryReader(ms))
                {
                    #region Read column information

                    if (NewTableStructure())
                    {
                        UnknownInteger = br.ReadInt32();
                        UnknownByte = br.ReadByte();
                    }

                    var columnCount = br.ReadInt32();
                    if (columnCount <= 0)
                        throw new Exception("Invalid column count value. Probably the specified table is corrupt.");
                    var columnData = new int[columnCount];
                    var _temporaryTable = new DataTable(tableName);

                    for (var i = 0; i < columnCount; i++)
                    {
                        var columnType = br.ReadInt32();
                        columnData[i] = columnType;
                        string columnHeader = "";
                        Type _columnType = typeof(void);

                        #region Determine column type
                        switch (columnType)
                        {
                            case ColumnTypes.SignedByte:
                                _columnType = typeof(sbyte);
                                columnHeader += "(signed byte)";
                                break;case ColumnTypes.UnsignedByte:
                                _columnType = typeof(byte);
                                columnHeader += "(unsigned byte)";
                                break;
                            case ColumnTypes.SignedShort:
                                _columnType = typeof(short);
                                columnHeader += "(signed short)";
                                break;
                            case ColumnTypes.UnsignedShort:
                                _columnType = typeof(ushort);
                                columnHeader += "(unsigned short)";
                                break;
                            case ColumnTypes.SignedInteger:
                                _columnType = typeof(int);
                                columnHeader += "(signed integer)";
                                break;
                            case ColumnTypes.UnsignedInteger:
                                _columnType = typeof(uint);
                                columnHeader += "(unsigned integer)";
                                break;
                            case ColumnTypes.String:
                                _columnType = typeof(string);
                                columnHeader += "(string)";
                                break;
                            case ColumnTypes.Float:
                                _columnType = typeof(float);
                                columnHeader += "(float)";
                                break;
                            case ColumnTypes.Double:
                                _columnType = typeof (double);
                                columnHeader += "(double)";
                                break;
                            case ColumnTypes.SignedLong:
                                _columnType = typeof (Int64);
                                columnHeader += "(signed long)";
                                break;
                            case ColumnTypes.UnsignedLong:
                                _columnType = typeof (UInt64);
                                columnHeader += "(unsigned long)";
                                break;
                            default:
                                throw new Exception($"Invalid column type ({columnType})");
                        }
                        #endregion

                        var columnTitle = $"[{i}]\n{columnHeader}";
                        var temporaryColumn = new DataColumn(columnTitle, _columnType)
                        {
                            DefaultValue = GetDefault(_columnType),
                            Caption = columnTitle,
                        };

                        _temporaryTable.Columns.Add(temporaryColumn);

                    }

                    #endregion

                    #region Read value information

                    var rowCount = br.ReadInt32();
                    if (rowCount <= 0)
                        throw new Exception("Invalid row count value. Probably the specified table is corrupt.");

                    for (var i = 0; i < rowCount; i++)
                    {
                        DataRow _temporaryRow = _temporaryTable.NewRow();
                        for (var j = 0; j < columnCount; j++)
                        {
                            switch (columnData[j])
                            {
                                case ColumnTypes.SignedByte:
                                    _temporaryRow[j] = br.ReadSByte();
                                    break;
                                case ColumnTypes.UnsignedByte:
                                    _temporaryRow[j] = br.ReadByte();
                                    break;
                                case ColumnTypes.SignedShort:
                                    _temporaryRow[j] = br.ReadInt16();
                                    break;
                                case ColumnTypes.UnsignedShort:
                                    _temporaryRow[j] = br.ReadUInt16();
                                    break;
                                case ColumnTypes.SignedInteger:
                                    _temporaryRow[j] = br.ReadInt32();
                                    break;
                                case ColumnTypes.UnsignedInteger:
                                    _temporaryRow[j] = br.ReadUInt32();
                                    break;
                                case ColumnTypes.String:
                                    /* string */
                                    var strlen = br.ReadInt32();
                                    if (strlen > 0)
                                    {
                                        var chArray = Encoding.GetEncoding("EUC-KR").GetChars(br.ReadBytes(strlen));
                                        _temporaryRow[j] = new string(chArray);
                                    }

                                    break;
                                case ColumnTypes.Float:
                                    _temporaryRow[j] = br.ReadSingle();
                                    break;
                                case ColumnTypes.Double:
                                    _temporaryRow[j] = br.ReadDouble();
                                    break;
                                case ColumnTypes.SignedLong:
                                    _temporaryRow[j] = br.ReadInt64();
                                    break;
                                case ColumnTypes.UnsignedLong:
                                    _temporaryRow[j] = br.ReadUInt64();
                                    break;
                                default:
                                    throw new Exception(string.Format("Invalid column type ({0})", columnData[j]));
                            }
                        }
                        _temporaryTable.Rows.Add(_temporaryRow);}

                    #endregion
                   // Trace.Assert(ms.Length - 1 == ms.Position, "Did not read all the data!");
                    
                    return _temporaryTable;
                }
            }
        }

        private object GetDefault(Type type)
        {
            // If no Type was supplied, if the Type was a reference type, or if the Type was a System.Void, return null
            if (type == null || !type.IsValueType || type == typeof(void))
                return null;

            // If the supplied Type has generic parameters, its default value cannot be determined
            if (type.ContainsGenericParameters)
                throw new ArgumentException(
                    "{" + MethodBase.GetCurrentMethod() + "} Error:\n\nThe supplied value type <" + type +
                    "> contains generic parameters, so the default value cannot be retrieved");

            // If the Type is a primitive type, or if it is another publicly-visible value type (i.e. struct/enum), return a 
            //  default instance of the value type
            if (type.IsPrimitive || !type.IsNotPublic)
            {
                try
                {
                    return Activator.CreateInstance(type);
                }
                catch (Exception e)
                {
                    throw new ArgumentException(
                        "{" + MethodBase.GetCurrentMethod() + "} Error:\n\nThe Activator.CreateInstance method could not " +
                        "create a default instance of the supplied value type <" + type +
                        "> (Inner Exception message: \"" + e.Message + "\")", e);
                }
            }

            // Fail with exception
            throw new ArgumentException("{" + MethodBase.GetCurrentMethod() + "} Error:\n\nThe supplied value type <" + type +
                "> is not a publicly-visible type, so the default value cannot be retrieved");
        }

        public DataTable GetDataTableFromFile(string fileName, string tableName)
        {
            try
            {
                return GetTableFromDecodedBytes(DecodeFileIntoByteArray(fileName), tableName);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
