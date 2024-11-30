namespace Ecolab.Simaira.Digital.CustomerPortal.Model
{
    using global::System.Collections.Generic;
    
    public class AlertFilterUiInput
    {

        public IList<string> ServiceArea { get; set; }       

        public IList<string> DeviceIds { get; set; }

        public int Days { get; set; }
    }
}