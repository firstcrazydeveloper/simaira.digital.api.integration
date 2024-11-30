namespace Ecolab.Simaira.Digital.CustomerPortal.Model.RequestModels
{
    using global::System.ComponentModel.DataAnnotations;
    using Newtonsoft.Json;
    public class SiteRequest
    {
        [RegularExpression(Constants.EmailRegExpression, ErrorMessage = "Please enter correct email")]
        [DataType(DataType.EmailAddress)]
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }
    }
}
