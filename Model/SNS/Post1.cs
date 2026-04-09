using System.IO;
using System.Net;
using System.Reflection.Emit;
using System.Text.Json.Serialization;
using System.Xml.Linq;

namespace BlazorWebAppTest.Model
{
    public class Post1
    {
        [JsonPropertyName("userId")]
        public int userId { get; set; }

        [JsonPropertyName("id")]
        public int id { get; set; }

        [JsonPropertyName("title")]
        public string? title { get; set; }

        [JsonPropertyName("body")]
        public string? body { get; set; }

        [JsonPropertyName("tags")]
        public string[]? tags { get; set; }

        [JsonPropertyName("reactions")]
        public SNS_Post_reactions? Reactions { get; set; }
        public int? likes => Reactions?.likes;
        public int? dislikes => Reactions?.dislikes;

        [JsonPropertyName("views")]
        public int views { get; set; }
    }

    public class SNS_Post_reactions
    {
        [JsonPropertyName("likes")]
        public int likes { get; set; }

        [JsonPropertyName("dislikes")]
        public int dislikes { get; set; }
    }

}
