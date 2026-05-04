using System.Text.Json.Serialization;

namespace BlazorWebAppTest.Model.SNS
{
    public class Comment1
    {
        [JsonPropertyName("postId")]
        public int postId { get; set; }

        [JsonPropertyName("id")]
        public int id { get; set; }

        [JsonPropertyName("body")]
        public string? body { get; set; }

        [JsonPropertyName("likes")]
        public int likes { get; set; }

        [JsonPropertyName("user")]
        public Comment1User? CommentUser { get; set; }

        public int? userId => CommentUser.userId;

    }

    public class Comment1User
    {
        [JsonPropertyName("id")]
        public int? userId { get; set; }

    }

}
