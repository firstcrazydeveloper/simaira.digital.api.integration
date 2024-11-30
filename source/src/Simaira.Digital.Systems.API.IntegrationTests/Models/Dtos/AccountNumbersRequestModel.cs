namespace Ecolab.Simaira.Digital.CustomerPortal.Model.Dtos
{
    using global::System.Collections.Generic;
    using global::System.ComponentModel.DataAnnotations;

    public class AccountNumbersRequestModel
    {
        [Required]
        public IEnumerable<string> AccountNumbers { get; set; }
    }
}
