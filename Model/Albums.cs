using System.Text.Json.Serialization;

namespace BlazorWebAppTest.Model
{
    public class Albums
    {
        [JsonPropertyName("userId")]
        public int userId { get; set; }

        [JsonPropertyName("id")]
        public int id { get; set; }

        [JsonPropertyName("title")]
        public string? title { get; set; }
    }
}
