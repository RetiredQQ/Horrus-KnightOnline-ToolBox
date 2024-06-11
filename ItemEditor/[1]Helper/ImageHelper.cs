using ItemEditor.Properties;
using ItemEditor.Static;
using ClassDefinitions.Models.InventoryEditor;
using System.Reflection;
using System.Text.Json;

namespace ItemEditor.StaticClasses
{
    public class ImageHelper
    {
        public List<ItemIconModel>? ItemIconTblJson;

        public Size DefaultSize = new Size(64,64);

        public Image GetItemJpgFile(int num, Size imageSize)
        {
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), $@"Resources\itemicons\{num.ToString().Substring(0, 6)}00.jpg");

            if (File.Exists(path))
            {
                return new Bitmap(new Bitmap(path), new Size(64, 64));
            }

            if (ItemIconTblJson != null)
            {
                int? iconID = ItemIconTblJson.FirstOrDefault(x => x.Num.Equals(num))?.ItemIconID2;

                if (iconID != null && iconID != 0)
                {
                    path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), $@"Resources\itemicons\{iconID}.jpg");

                    if (File.Exists(path))
                    {
                        return new Bitmap(new Bitmap(path), imageSize);
                    }
                }
            }

            return new Bitmap(Resources._0, imageSize);
        }

        public Image GetItemJpgFile(int num)
        {
            return GetItemJpgFile(num, DefaultSize);
        }

        /// <summary>
        /// Custom Logic specific for my own purpose
        /// Used to load addiotnal json file with IconID to ItemNum mapping
        /// </summary>
        public void Load1098IconReferences()
        {
            // Determine the path to the file
            string relativePath = "Resources\\Json\\csvjson.json"; // Adjust the path if needed
            string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);

            try
            {
                CoreServices.ImageHelper.ItemIconTblJson = JsonSerializer.Deserialize<List<ItemIconModel>>(File.ReadAllText(fullPath));
            }
            catch (Exception ItemIconLoadingError)
            {
                MessageBox.Show($"ItemIconLoadingError: {ItemIconLoadingError}");
                CoreServices.Logger.LogException(ItemIconLoadingError);
            }
        }
    }
}
