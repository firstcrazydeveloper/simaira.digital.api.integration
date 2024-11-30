using Newtonsoft.Json;

namespace Ecolab.Simaira.Digital.CustomerPortal.Model.RequestModels
{
    public interface IUser
    {
        [JsonProperty(PropertyName = "user")]
        User UserInfo { get; set; }
    }
}
