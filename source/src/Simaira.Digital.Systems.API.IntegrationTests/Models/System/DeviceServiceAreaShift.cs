namespace Ecolab.Simaira.Digital.CustomerPortal.Model.System
{
    using Ecolab.Simaira.Digital.CustomerPortal.Model.System.ShiftModels;
    using global::System.Collections.Generic;

    public class DeviceServiceAreaShift : DeviceServiceArea
    {
        public IEnumerable<ShiftFlatModel> Shifts { get; set; }
    }
}
