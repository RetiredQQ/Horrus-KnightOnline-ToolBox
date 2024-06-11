using System.Drawing;

namespace ClassDefinitions.Models.InventoryEditor
{
    public class ItemInfoModel
    {
        public ItemInfoModel(string displayName, Color color)
        {
            DisplayName = displayName;
            Color = color;
        }

        public string DisplayName { get; set; }

        public Color Color { get; set; }
    }
}
