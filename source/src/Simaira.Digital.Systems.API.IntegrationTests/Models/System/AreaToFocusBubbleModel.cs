namespace Ecolab.Simaira.Digital.CustomerPortal.Model.System
{
    using global::System.Collections.Generic;

    public class BubbleChartModel
    {
        public string Label { get; set; }
        public int Count { get; set; }
        public IEnumerable<string> CdmSiteKeys { get; set; }
        public IEnumerable<string> GraphNodeSiteKeys { get; set; }
        
    }
}
