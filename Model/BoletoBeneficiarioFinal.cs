using CobrancaBBApi.Model.Enum;
using Newtonsoft.Json;

namespace CobrancaBBApi.Model
{
    public class BoletoBeneficiarioFinal
    {
        /// <summary>
        /// Código que identifica o tipo de inscrição do beneficiário final.
        /// Domínios: 1 - CPF; 2 - CNPJ
        /// </summary>
        [JsonProperty("tipoInscricao")]
        public EnumCpfCnpj TipoInscricao { get; set; }

        /// <summary>
        /// Número de registro do beneficiário final. Para o tipo = 1, informar numero do CPF. Para o tipo = 2, informar numero do CNPJ.
        /// </summary>
        [JsonProperty("beneficnumeroInscricaoiarioFinal")]
        public int NumeroInscricao { get; set; }

        /// <summary>
        /// Nome do beneficiário final
        /// </summary>
        [JsonProperty("nome")]
        public string Nome { get; set; }
    }
}
