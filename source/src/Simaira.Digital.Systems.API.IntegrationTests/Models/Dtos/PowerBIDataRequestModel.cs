namespace Ecolab.Simaira.Digital.CustomerPortal.Model.Dtos
{
    using global::System.Collections.Generic;

    public class PowerBIDataRequestModel
    {
        public IEnumerable<string> CdmSiteKeys { get; set; }
        public IEnumerable<string> GraphNodeSiteKeys { get; set; }
    }
}