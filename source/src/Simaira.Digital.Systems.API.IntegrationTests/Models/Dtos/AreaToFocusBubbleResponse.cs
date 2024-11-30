namespace Ecolab.Simaira.Digital.CustomerPortal.Model.Dtos
{
    using Ecolab.Simaira.Digital.CustomerPortal.Model.System;
    using global::System.Collections.Generic;

    public class AreaToFocusBubbleResponse : BaseApiResponse
    {
        public IEnumerable<BubbleChartModel> ChartData { get; set; }
    }
}
