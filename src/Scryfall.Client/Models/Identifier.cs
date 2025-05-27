using System.Text.Json.Serialization;

namespace Scryfall.Client.Models
{
    public class Identifier
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("mtgo_id")]
        public int MTGOId { get; set; }

        [JsonPropertyName("multiverse_id")]
        public int MultiverseId { get; set; }

        [JsonPropertyName("oracle_id")]
        public string OracleId { get; set; }

        [JsonPropertyName("illustration_id")]
        public string IllustrationId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("set")]
        public string Set { get; set; }

        [JsonPropertyName("collector_number")]
        public string CollectorNumber { get; set; }
    }
}
