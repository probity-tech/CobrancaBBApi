using CobrancaBBApi.Model.Enum;
using Newtonsoft.Json;

namespace CobrancaBBApi.Model
{
    public class BoletoDescontoTipo : BoletoDesconto
    {
        /// <summary>
        /// Como o desconto será concedido
        /// </summary>
        [JsonProperty("tipo")]
        public EnumTipoDesconto Tipo { get; set; }
    }
}
