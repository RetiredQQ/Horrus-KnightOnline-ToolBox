using System.Diagnostics;

namespace ClassDefinitions.Models.Encryption
{
    /* Base encryption class */
    public static class ColumnTypes
    {
        public const int SignedByte = 1;
        public const int UnsignedByte = 2;
        public const int SignedShort = 3;
        public const int UnsignedShort = 4;
        public const int SignedInteger = 5;
        public const int UnsignedInteger = 6;
        public const int String = 7;
        public const int Float = 8;
        public const int Double = 9;
        public const int SignedLong = 10;
        public const int UnsignedLong = 11;

        public static string GetColumnTypeNameFromFullName(string name)
        {
            switch (name)
            {
                case "System.UInt64":
                    return "(unsigned long)";
                case "System.Int64":
                    return "(signed long)";
                case "System.Double":
                    return "(double)";
                case "System.Single":
                    return "(float)";
                case "System.UInt32":
                    return "(unsigned integer)";
                case "System.Int32":
                    return "(signed integer)";
                case "System.UInt16":
                    return "(unsigned short)";
                case "System.Int16":
                    return "(signed short)";
                case "System.SByte":
                    return "(signed byte)";
                case "System.Byte":
                    return "(unsigned byte)";
                case "System.String":
                    return "(string)";
                default:
                    return "(unknown)";
            }
        }

        public static int GetColumnTypeFromFullName(string name)
        {
            switch (name)
            {
                case "System.UInt64":
                    return UnsignedLong;
                case "System.Int64":
                   return SignedLong;
                case "System.Double":
                    return Double;
                case "System.Single":
                    return Float;
                case "System.UInt32":
                    return UnsignedInteger;
                case "System.Int32":
                    return SignedInteger;
                case "System.UInt16":
                    return UnsignedShort;
                case "System.Int16":
                    return SignedShort;
                case "System.SByte":
                    return SignedByte;
                case "System.Byte":
                    return UnsignedByte;
                case "System.String":
                    return String;
                default:
                    Trace.Assert(false, "GetColumnTypeFromFullName() - Unknown type.");
                    return -1;
            }
        }
    }
}
