using System.Text.Json.Serialization;

namespace BlazorWebAppTest.Model.SNS
{
    public class User1
    {

        [JsonPropertyName("id")]
        public int id { get; set; }

        [JsonPropertyName("role")]
        public string? role { get; set; }

        [JsonPropertyName("username")]
        public string? username { get; set; }

        [JsonPropertyName("password")]
        public string? password { get; set; }

        [JsonPropertyName("firstName")]
        public string? firstName { get; set; }

        [JsonPropertyName("lastName")]
        public string? lastName { get; set; }

        [JsonPropertyName("maidenName")]
        public string? maidenName { get; set; }

        [JsonPropertyName("email")]
        public string? email { get; set; }

        [JsonPropertyName("phone")]
        public string? phone { get; set; }

        //[JsonPropertyName("website")]
        //public string? website { get; set; }

        [JsonPropertyName("age")]
        public int age { get; set; }

        [JsonPropertyName("gender")]
        public string? gender { get; set; }

        [JsonPropertyName("birthDate")]
        public string? birthDate { get; set; }

        [JsonPropertyName("bloodGroup")]
        public string? bloodGroup { get; set; }

        [JsonPropertyName("height")]
        public float height { get; set; }

        [JsonPropertyName("image")]
        public string? image { get; set; }

        [JsonPropertyName("university")]
        public string? university { get; set; }
        


        [JsonPropertyName("company")]
        public UserCompany? Company { get; set; }
        public string? CompanyName => Company?.companyname;
        public string? title => Company?.title;
        public string? department => Company?.department;
        //public string? CompSuite => Company?.CompSuite;
        public string? CompCity => Company?.CompCity;
        public string? CompPostalCode => Company?.CompPostalCode;
        public string? CompState => Company?.CompState;


        [JsonPropertyName("address")]
        public Address? Address { get; set; }
        public string? apt => Address?.apt;
        public string? Street => Address?.street;
        //public string? Suite => Address?.suite;
        public string? City => Address?.city;
        public string? postalCode => Address?.postalCode;
        public string? country => Address?.country;
    }
    public class Address
    {
        [JsonPropertyName("street")]
        public string? street { get; set; }

        [JsonPropertyName("address")]
        public string? apt { get; set; }

        //[JsonPropertyName("suite")]
        //public string? suite { get; set; }

        [JsonPropertyName("city")]
        public string? city { get; set; }

        [JsonPropertyName("state")]
        public string? state { get; set; }

        [JsonPropertyName("postalCode")]
        public string? postalCode { get; set; }

        [JsonPropertyName("country")]
        public string? country { get; set; }
    }

    public class UserCompany
    {
        [JsonPropertyName("name")]
        public string? companyname { get; set; }

        [JsonPropertyName("department")]
        public string? department { get; set; }

        [JsonPropertyName("title")]
        public string? title { get; set; }

        //[JsonPropertyName("bs")]
        //public string? bs { get; set; }

        [JsonPropertyName("address")]
        public Address? CompanyAddr { get; set; }
        public string? CompStreet => CompanyAddr?.street;
        public string? CompApt => CompanyAddr?.apt;
        //public string? CompSuite => CompanyAddr?.suite;
        public string? CompCity => CompanyAddr?.city;
        public string? CompPostalCode => CompanyAddr?.postalCode;
        public string? CompState => CompanyAddr?.state;
        public string? CompCountry => CompanyAddr?.country;



    }
}
