using CobrancaBBApi.Model.Enum;
using Newtonsoft.Json;

namespace CobrancaBBApi.Model
{
    public class BoletoJurosMora
    {
        /// <summary>
        /// Código utilizado pela FEBRABAN para identificar o tipo de taxa de juros.
        /// </summary>
        [JsonProperty("tipo")]
        public EnumTipoJurosMora Tipo { get; set; }

        /// <summary>
        /// Se tipo = 'TAXAMENSAL', definir uma porcentagem de juros >= 0.00 (formato decimal separado por ".").
        /// </summary>
        [JsonProperty("porcentagem")]
        public decimal? Porcentagem { get; set; }

        /// <summary>
        /// Se tipo = 'VALORDIAATRASO', definir um valor de juros >= 0.00 (formato decimal separado por ".").
        /// </summary>
        [JsonProperty("valor")]
        public decimal? Valor { get; set; }
    }
}
