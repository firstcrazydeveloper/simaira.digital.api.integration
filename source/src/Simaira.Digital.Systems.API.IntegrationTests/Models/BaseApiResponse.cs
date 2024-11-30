namespace Ecolab.Simaira.Digital.CustomerPortal.Model
{
    public class BaseApiResponse
    {
        public BaseApiResponse()
        {
            HttpStatusCode = 400; // Default Bad Request
        }
        public bool Status { get; set; }
        public int? Id { get; set; }
        public string StrCode { get; set; }
        public int HttpStatusCode { get; set; }
        public string ErrorMessage { get; set; }
    }
}
