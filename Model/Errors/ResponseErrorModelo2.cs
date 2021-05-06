using Newtonsoft.Json;
using System.Collections.Generic;

namespace CobrancaBBApi.Model
{
    public class ResponseErrorModelo2
    {
        [JsonProperty("errors")]
        public List<ItemResponseErrorModelo2> Errors { get; set; }
    }

    public class ItemResponseErrorModelo2
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("Message")]
        public string Message { get; set; }
    }
}
