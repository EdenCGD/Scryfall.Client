using System.Text.Json.Serialization;

namespace Scryfall.Client.Models
{
    public class Ruling : BaseItem
    {
        [JsonPropertyName("oracle_id")]
        public string OracleId { get; set; }

        [JsonPropertyName("source")]
        public string Source { get; set; }

        [JsonPropertyName("published_at")]
        public DateTime Published { get; set; }

        [JsonPropertyName("comment")]
        public string Comment { get; set; }
    }
}
