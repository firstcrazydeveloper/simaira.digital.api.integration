namespace Ecolab.Simaira.Digital.CustomerPortal.Model.Process
{
    using global::System.Collections.Generic;

    public class DAXInputParamTypes<T>
    {
        public string KeyName { get; set; }
        public IList<T> ValueCollection { get; set; }
    }
}
