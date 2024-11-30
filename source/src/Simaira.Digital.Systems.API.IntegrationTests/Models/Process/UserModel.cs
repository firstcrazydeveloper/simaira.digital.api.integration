namespace Ecolab.Simaira.Digital.CustomerPortal.Model
{
    using global::System.Collections.Generic;
    using global::System.ComponentModel.DataAnnotations;

    public class UserModel
    {
        public string Id { get; set; }

        [RegularExpression(Constants.EmailRegExpression, ErrorMessage = "Please enter correct email")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email address")]
        public string Email { get; set; }

        public IList<string> AccountNumber { get; set; }

        public IList<string> Categories { get; set; }

        public IList<string> CdmSite { get; set; }

        public IList<string> GraphNodeSiteKeys { get; set; }

        public string Role { get; set; }

        public int? CustomerKey { get; set; }

        public string FullName { get; set; }

        public int day { get; set; }

        public string H7Id { get; set; }
    }
}