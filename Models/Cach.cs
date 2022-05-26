namespace Models
{
    using System.Text.Json.Serialization;
    public class Cach
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
