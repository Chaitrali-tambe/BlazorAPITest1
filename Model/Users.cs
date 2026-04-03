using System.Text.Json.Serialization;

namespace BlazorWebAppTest.Model
{
    public class Users
    {
        [JsonPropertyName("id")]
        public int id { get; set; }

        [JsonPropertyName("name")]
        public string? name { get; set; }

        [JsonPropertyName("username")]
        public string? username { get; set; }
    }
}
