namespace Ecolab.Simaira.Digital.CustomerPortal.Model.System
{
    using global::System.ComponentModel.DataAnnotations;
    using global::System.Collections.Generic;

    public class AreaToFocusBubbleRequest
    {
        [Required]
        public IEnumerable<string> Categories { get; set; }

        [Required]
        public int Days { get; set; }

        public IEnumerable<string> CdmSiteKeys { get; set; }

        public IEnumerable<string> GraphNodeSiteKeys { get; set; }
    }
}
