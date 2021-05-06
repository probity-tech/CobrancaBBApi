using Newtonsoft.Json;

namespace CobrancaBBApi.Model
{
    public class QrCode
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("txId")]
        public string TxId { get; set; }

        [JsonProperty("emv")]
        public string Emv { get; set; }
    }
}
