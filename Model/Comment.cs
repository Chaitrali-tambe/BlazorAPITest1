using System.Text.Json.Serialization;

namespace BlazorWebAppTest.Model
{
    public class Comment
    {
        [JsonPropertyName("postId")]
        public int postId { get; set; }

        [JsonPropertyName("id")]
        public int id { get; set; }

        [JsonPropertyName("name")]
        public string? name { get; set; }

        [JsonPropertyName("email")]
        public string? email { get; set; }

        [JsonPropertyName("body")]
        public string? body { get; set; }
    }
}
