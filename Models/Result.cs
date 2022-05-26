using System.Text.Json.Serialization;

namespace Models
{
    public class Result
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("dialCode")]
        public string DialCode { get; set; }
        [JsonPropertyName("isoCode")]
        public string IsoCode { get; set; }
        [JsonPropertyName("flagUrl")]
        public string FlagUrl { get; set; }
        [JsonPropertyName("flagSymbol")]
        public string FlagSymbol { get; set; }

    }
}
