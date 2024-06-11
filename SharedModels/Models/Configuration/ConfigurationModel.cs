namespace ClassDefinitions.Models.Configuration
{
    public class ConfigurationModel
    {
        public string? DbName { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? CatalogName { get; set; }
        public bool Is1098Version { get; set; }
        public ItemCreatorDataTableSettings DataTableSettings { get; set; }
    }

    public class ItemCreatorDataTableSettings
    {
        public string DataFolderPath { get; set; }
        public string ItemExtTablePath { get; set; }
        public string ItemOrgTablePath { get; set; }
    }
}
