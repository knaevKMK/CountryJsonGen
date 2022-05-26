namespace Models
{
    using Models.SubModes;
    using System.Text.Json.Serialization;
    public class Temp
    {
        [JsonPropertyName("name")]
        public Name Name { get; set; }
        //[JsonPropertyName("common")]
        //public string Cname { get; set; }
        [JsonPropertyName("altSpellings")]
        public string[] IsoCode { get; set; }
        //[JsonPropertyName("flagUrl")]
        //public string FlagUrl { get; set; }
        [JsonPropertyName("flag")]
        public string FlagSymbol { get; set; }
    }
}
