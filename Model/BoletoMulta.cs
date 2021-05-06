using Newtonsoft.Json;

namespace CobrancaBBApi.Model
{
    public class BoletoMulta : BoletoJurosMora
    {
        /// <summary>
        /// Se tipo <> 'DISPENSAR', Definir uma data de multa, no formato "dd.mm.aaaa"
        /// </summary>
        [JsonProperty("data")]
        public string Data { get; set; }
    }
}
