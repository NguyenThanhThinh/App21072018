using Newtonsoft.Json;

namespace App21072018.Web.ViewModels.Error
{
    public class ErrorDetails
    {
        public string StatusCode { get; set; }

        public string Message { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
