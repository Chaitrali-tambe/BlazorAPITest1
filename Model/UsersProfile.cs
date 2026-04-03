using System.Text.Json.Serialization;

namespace BlazorWebAppTest.Model
{
    public class UsersProfile
    {
        [JsonPropertyName("id")]
        public int id { get; set; }

        [JsonPropertyName("name")]
        public string? name { get; set; }

        [JsonPropertyName("username")]
        public string? username { get; set; }

        [JsonPropertyName("email")]
        public string? email { get; set; }

        [JsonPropertyName("phone")]
        public string? phone { get; set; }

        [JsonPropertyName("website")]
        public string? website { get; set; }


        [JsonPropertyName("company")]
        public UserCompany? Company { get; set; }
        public string? CompanyName => Company?.companyname;
        public string? CatchPhrase => Company?.catchPhrase;
        public string? Bs => Company?.bs;


        [JsonPropertyName("address")]
        public UserAddress? Address { get; set; }
        public string? Street => Address?.street;
        public string? Suite => Address?.suite;
        public string? City => Address?.city;
        public string? Zipcode => Address?.zipcode;
    }
    public class UserAddress
    {
        [JsonPropertyName("street")]
        public string? street { get; set; }

        [JsonPropertyName("suite")]
        public string? suite { get; set; }

        [JsonPropertyName("city")]
        public string? city { get; set; }

        [JsonPropertyName("zipcode")]
        public string? zipcode { get; set; }
    }

    public class UserCompany
    {
        [JsonPropertyName("name")]
        public string? companyname { get; set; }

        [JsonPropertyName("catchPhrase")]
        public string? catchPhrase { get; set; }

        [JsonPropertyName("bs")]
        public string? bs { get; set; }
    }
}
