using System.Text.Json.Serialization;

namespace BlazorWebAppTest.Model.SNS
{
    
    public class Company1
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("company")]
        public Companydetails? Companydetails { get; set; }
        public string? CompanyName => Companydetails?.companyname;
        public string? title => Companydetails?.title;
        public string? department => Companydetails?.department;
        
        
    }
    public class Companydetails
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
