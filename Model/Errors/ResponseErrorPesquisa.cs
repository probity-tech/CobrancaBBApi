using Newtonsoft.Json;
using System.Collections.Generic;

namespace CobrancaBBApi.Model
{
    public class ResponseErrorPesquisa
    {
        [JsonProperty("erros")]
        public List<ItemResponseErrorPesquisa> Erros { get; set; }
    }

    public class ItemResponseErrorPesquisa
    {
        [JsonProperty("codigoMensagem")]
        public string CodigoMensagem { get; set; }

        [JsonProperty("versaoMensagem")]
        public string VersaoMensagem { get; set; }

        [JsonProperty("textoMensagem")]
        public string TextoMensagem { get; set; }

        [JsonProperty("codigoRetorno")]
        public string CodigoRetorno { get; set; }
    }
}
