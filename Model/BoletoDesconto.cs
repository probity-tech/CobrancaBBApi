using Newtonsoft.Json;

namespace CobrancaBBApi.Model
{
    public class BoletoDesconto
    {
        /// <summary>
        /// Se tipo <> "SEMDESCONTO", Definir uma data de expiração do desconto, no formato "dd.mm.aaaa"
        /// </summary>
        [JsonProperty("dataExpiracao")]
        public string DataExpiracao { get; set; }

        /// <summary>
        /// Se tipo = 'PERCENTUALATEADATAINFORMADA', definir uma porcentagem de desconto >= 0.00 (formato decimal separado por ".")
        /// </summary>        
        [JsonProperty("porcentagem")]
        public decimal? Porcentagem { get; set; }

        /// <summary>
        /// Se tipo = 'VLRFIXOATEADATAINFORMADA', definir um valor de desconto >= 0.00 (formato decimal separado por ".").
        /// </summary>
        [JsonProperty("valor")]
        public decimal? Valor { get; set; }
    }
}
