using System.Text.Json.Serialization;

namespace BlazorWarbandManager.Models
{
    public class Item
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("cost")]
        public int Cost { get; set; }
    }

    class Weapon : Item
    {
    }
}