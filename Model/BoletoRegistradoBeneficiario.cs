using Newtonsoft.Json;

namespace CobrancaBBApi.Model
{
    public class BoletoRegistradoBeneficiario
    {
        [JsonProperty("agencia")]
        public int Agencia { get; set; }

        [JsonProperty("contaCorrente")]
        public int ContaCorrente { get; set; }

        [JsonProperty("tipoEndereco")]
        public int TipoEndereco { get; set; }

        [JsonProperty("logradouro")]
        public string Logradouro { get; set; }

        [JsonProperty("bairro")]
        public string Bairro { get; set; }

        [JsonProperty("cidade")]
        public string Cidade { get; set; }

        [JsonProperty("codigoCidade")]
        public int CodigoCidade { get; set; }

        [JsonProperty("uf")]
        public string Uf { get; set; }

        [JsonProperty("cep")]
        public int Cep { get; set; }

        [JsonProperty("indicadorComprovacao")]
        public string IndicadorComprovacao { get; set; }
    }
}
