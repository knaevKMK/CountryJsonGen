using System.Text.Json.Serialization;

namespace Models.SubModes
{
    public class Name
    {
        [JsonPropertyName("common")]
        public string Common { get; set; }

        [JsonPropertyName("official")]
        public string Official { get; set; }
    }
}
