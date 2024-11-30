namespace Ecolab.Simaira.Digital.CustomerPortal.Model.ResponseModels
{
    public class Response<T>
    {
        public int StatusCode { get; set; }

        public string ErrorMessage { get; set; }

        public T Value { get; set; }
    }
}
