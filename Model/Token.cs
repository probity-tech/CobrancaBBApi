using Newtonsoft.Json;
using System;

namespace CobrancaBBApi.Model
{
    public class Token
    {
        [JsonProperty("access_token")]
        public string Access_token { get; set; }

        [JsonProperty("token_type")]
        public string Token_type { get; set; }

        [JsonProperty("expires_in")]
        public int? Expires_in { get; set; }

        [JsonIgnore]
        public bool Active
        {
            get
            {
                return !string.IsNullOrEmpty(Access_token) &&
                       Expire_DateTime > DateTime.Now;
            }
        }

        [JsonIgnore]
        public DateTime? Expire_DateTime { get; set; }

        [JsonIgnore]
        public string MessageError { get; set; }
    }
}
