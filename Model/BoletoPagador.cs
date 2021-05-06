using CobrancaBBApi.Model.Enum;
using Newtonsoft.Json;

namespace CobrancaBBApi.Model
{
    public class BoletoPagador
    {
        /// <summary>
        /// Código que identifica o tipo de inscrição do Pagador.
        /// </summary>
        [JsonProperty("tipoInscricao")]
        public EnumCpfCnpj TipoInscricao { get; set; }

        /// <summary>
        /// Número de inscrição do pagador. Para o tipo = 1, informar numero do CPF. Para o tipo = 2, informar numero do CNPJ.
        /// </summary>
        [JsonProperty("numeroInscricao")]
        public long NumeroInscricao { get; set; }

        /// <summary>
        /// Nome do pagador.
        /// </summary>
        [JsonProperty("nome")]
        public string Nome { get; set; }

        /// <summary>
        /// Endereço do pagador.
        /// </summary>
        [JsonProperty("endereco")]
        public string Endereco { get; set; }

        /// <summary>
        /// Código postal do pagador.
        /// </summary>
        [JsonProperty("cep")]
        public int Cep { get; set; }

        /// <summary>
        /// Cidade do pagador.
        /// </summary>
        [JsonProperty("cidade")]
        public string Cidade { get; set; }

        /// <summary>
        /// Bairro do pagador.
        /// </summary>
        [JsonProperty("bairro")]
        public string Bairro { get; set; }

        /// <summary>
        /// Sigla do unidade federativa em que o pagador vive.
        /// </summary>
        [JsonProperty("uf")]
        public string Uf { get; set; }

        /// <summary>
        /// Número de telefone do pagador.
        /// </summary>
        [JsonProperty("telefone")]
        public string Telefone { get; set; }
    }
}
