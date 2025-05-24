using System.Text.Json.Serialization;

namespace Scryfall.Client.Models;

class Catalog : BaseItem
{
    [JsonPropertyName("uri")]
    public Uri Uri { get; set; }

    [JsonPropertyName("total_values")]
    public int TotalValues { get; set; }

    [JsonPropertyName("data")]
    public string[] Data { get; set; }
}
