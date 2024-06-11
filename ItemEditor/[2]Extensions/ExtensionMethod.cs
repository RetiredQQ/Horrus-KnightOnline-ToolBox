using ItemEditor.ExternalControl;
using System.Reflection;
using ClassDefinitions.Emum;

namespace ItemEditor.Extensions
{
    public static class ExtensionMethod
    {
        public static void DoubleBuffered(this Control control, bool setting)
        {
            Type dgvType = control.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(control, setting, null);
        }

        public static string RemoveWhitespces(this string text)
        {
            return text.Replace(" ", "");
        }

        public static bool IsNumericType(string type)
        {
            switch (type)
            {
                case "Byte":
                case "SByte":
                case "UInt16":
                case "UInt32":
                case "UInt64":
                case "Int16":
                case "Int32":
                case "Int64":
                case "Decimal":
                case "Double":
                case "Single":
                    return true;
                default:
                    return false;
            }
        }


        public static void SetAdditonalTextInItemInfoRichTextBox(this DisabledRichTextBox richTextBox, string text, Color color, Font selectionFont, HorizontalAlignment alignment = HorizontalAlignment.Left)
        {
            richTextBox.SelectionAlignment = alignment;
            richTextBox.SelectionFont = selectionFont;
            richTextBox.SelectionColor = color;
            richTextBox.SelectedText = text;
        }

        public static Color GetItemTypeColor(byte type)
        {
            var dupa = (ItemTypeEnum)type;
            var color = Color.White;

            switch (dupa)
            {
                case ItemTypeEnum.EventType:
                    color = Color.MediumOrchid;
                    break;
                case ItemTypeEnum.UbgradeItem:
                    color = Color.MediumOrchid;
                    break;
                case ItemTypeEnum.UniqueItem:
                    color = Color.Chartreuse;
                    break;
                case ItemTypeEnum.CraftItem:
                    color = Color.Chartreuse;
                    break;
                case ItemTypeEnum.RareItem:
                    color = Color.Yellow;
                    break;
                case ItemTypeEnum.MagicItem:
                    color = Color.RoyalBlue;
                    break;
                case ItemTypeEnum.NormalItem:
                    color = Color.Bisque;
                    break;
            }

            return color;
        }
    }
}
