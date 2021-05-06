using Newtonsoft.Json;
using System.Collections.Generic;

namespace CobrancaBBApi.Model
{
    public class ResponseError
    {
        [JsonProperty("erros")]
        public List<ItemResponseError> Erros { get; set; }
    }

    public class ItemResponseError
    {
        [JsonProperty("codigo")]
        public string Codigo { get; set; }

        [JsonProperty("versao")]
        public string Versao { get; set; }

        [JsonProperty("mensagem")]
        public string Mensagem { get; set; }

        [JsonProperty("ocorrencia")]
        public string Ocorrencia { get; set; }
    }
}
