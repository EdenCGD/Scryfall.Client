using System.Text.Json.Serialization;

namespace Scryfall.Client.Models;

public abstract class BaseItem
{
    [JsonPropertyName("object")]
    public string ObjectType { get; set; }
}
