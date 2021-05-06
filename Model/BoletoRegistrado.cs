using Newtonsoft.Json;

namespace CobrancaBBApi.Model
{
    public class BoletoRegistrado
    {
        [JsonProperty("numero")]
        public string Numero { get; set; }

        [JsonProperty("numeroCarteira")]
        public int NumeroCarteira { get; set; }

        [JsonProperty("numeroVariacaoCarteira")]
        public int NumeroVariacaoCarteira { get; set; }

        [JsonProperty("codigoCliente")]
        public int CodigoCliente { get; set; }

        [JsonProperty("linhaDigitavel")]
        public string LinhaDigitavel { get; set; }

        [JsonProperty("codigoBarraNumerico")]
        public string CodigoBarraNumerico { get; set; }

        [JsonProperty("numeroContratoCobranca")]
        public int NumeroContratoCobranca { get; set; }

        [JsonProperty("beneficiario")]
        public BoletoRegistradoBeneficiario Beneficiario { get; set; }

        [JsonProperty("qrCode")]
        public QrCode QrCode { get; set; }
    }
}
