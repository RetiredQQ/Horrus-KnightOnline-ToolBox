using Newtonsoft.Json;

namespace ClassDefinitions.Models
{
    public class TableEditorHeaders
    {
    }

    public class TableEditorModelBinding
    {
        [JsonProperty("TableFileHeader")]
        public string TableFileHeader { get; set; }

        [JsonProperty("DatabaseColumnHeader")]
        public string DatabaseColumnHeader { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }

        [JsonProperty("AdditionalData")]
        public string AdditionalData { get; set; }
    }
}
