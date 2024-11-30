

namespace Ecolab.Simaira.Digital.CustomerPortal.Model
{
    using global::System.Collections.Generic;
    using global::System.ComponentModel.DataAnnotations;

    public class AllAlertInput
    {
        [Required]
        public string Category { get; set; }
        [Required]
        public int Days { get; set; }
        public string CdmSiteKey { get; set; }
        public IEnumerable<string> GraphNodeSiteKeys { get; set; }
        [Required]
        public string UserRole { get; set; }
        public string ServiceArea { get; set; }
        public string DeviceIds { get; set; }
        public string AccountNumber { get; set; }
        public int CustomerKey { get; set; }
        public string SelectColumns { get; set; }
    }
}
