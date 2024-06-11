using DataAccessLayer.Models;
using ItemEditor.Static;
using ItemEditor.Extensions;
using ItemEditor.ExternalControl;
using System.Reflection;
using ClassDefinitions.Emum;

namespace ItemEditor.StaticClasses
{
    public class ItemInfoHelper
    {
        public static ItemDAO? DisplayItemInfo(int num, DisabledRichTextBox richTextBox, PictureBox displayIconPicBox, UserItem? userItem = null)
        {
            ItemDAO itemInfo = CoreServices.DatabaseManager.GetItemByNumId(num);
            if (itemInfo == null) return null;

            richTextBox.Clear();
            richTextBox.SetAdditonalTextInItemInfoRichTextBox(itemInfo.strName.TrimEnd() + Environment.NewLine, ExtensionMethod.GetItemTypeColor(itemInfo.ItemType)
                , new Font("Tahoma", 10.0F, FontStyle.Bold, GraphicsUnit.Point), HorizontalAlignment.Center);

            ItemTypeEnum itemType = (ItemTypeEnum)itemInfo.ItemType;
            richTextBox.SetAdditonalTextInItemInfoRichTextBox($"{itemType}{Environment.NewLine}" + Environment.NewLine, ExtensionMethod.GetItemTypeColor(itemInfo.ItemType)
                , new Font("Tahoma", 9.0F, FontStyle.Regular, GraphicsUnit.Point), HorizontalAlignment.Center);

            foreach (var propertyInfo in itemInfo.GetType().GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public))
            {
                if (StaticValues.Skipable.Contains(propertyInfo.Name) && ExtensionMethod.IsNumericType(propertyInfo.FieldType.Name))
                {
                    var propertyValue = propertyInfo.GetValue(itemInfo);
                    
                    if (Int32.Parse(propertyValue.ToString()) > 0)
                    {
                        var text = $"{StaticValues.ItemDictionary[propertyInfo.Name].DisplayName} : {propertyValue}{Environment.NewLine}";

                        if (propertyInfo.Name.Equals("Countable") && (byte)propertyValue == 1)
                        {
                            text = $"ItemCount : {userItem?.ItemCount} {Environment.NewLine}";
                            richTextBox.SetAdditonalTextInItemInfoRichTextBox(text, StaticValues.ItemDictionary[propertyInfo.Name].Color, StaticValues.ItemCountInfoFont);
                        }
                        else
                        {
                            richTextBox.SetAdditonalTextInItemInfoRichTextBox(text, StaticValues.ItemDictionary[propertyInfo.Name].Color, StaticValues.ItemInfoFont);
                        }
                    }
                }
            }

            richTextBox.SetAdditonalTextInItemInfoRichTextBox($"Item ID : {itemInfo.Num}" + Environment.NewLine, Color.RoyalBlue, StaticValues.ItemInfoFont);

            if (displayIconPicBox != null)
            {
                displayIconPicBox.Image = CoreServices.ImageHelper.GetItemJpgFile(num);
            }

            return itemInfo;
        }
    }
}
