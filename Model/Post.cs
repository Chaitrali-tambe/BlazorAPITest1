using System.IO;
using System.Net;
using System.Reflection.Emit;
using System.Text.Json.Serialization;
using System.Xml.Linq;

namespace BlazorWebAppTest.Model
{
    public class Post
    {
        [JsonPropertyName("userId")]
        public int userId { get; set; }

        [JsonPropertyName("id")]
        public int id { get; set; }

        [JsonPropertyName("title")]
        public string? title { get; set; }

        [JsonPropertyName("body")]
        public string? body { get; set; }
    }

}
