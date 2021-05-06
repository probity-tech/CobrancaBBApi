using Newtonsoft.Json;

namespace CobrancaBBApi.Model
{
    public class ResponseErrorToken
    {
        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }
    }
}
