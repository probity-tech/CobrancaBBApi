using CobrancaBBApi.Model.Enum;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace CobrancaBBApi.Model
{
    /// <summary>
    /// Pesquisa de Boletos
    /// </summary>
    public class BoletoResult
    {
        /// <summary>
        /// Indica se há mais registros a serem pesquisados
        /// </summary>
        [JsonProperty("indicadorContinuidade")]
        public string IndicadorContinuidade { get; set; }

        /// <summary>
        /// Quantidade de Registros Retornados
        /// </summary>
        [JsonProperty("quantidadeRegistros")]
        public int QuantidadeRegistros { get; set; }

        /// <summary>
        /// Indice que deve ser utilizado para a próxima pesquisa
        /// </summary>
        [JsonProperty("proximoIndice")]
        public int ProximoIndice { get; set; }

        /// <summary>
        /// Lista de boletos retornados
        /// </summary>
        [JsonProperty("boletos")]
        public List<BoleroResultItem> Boletos { get; set; }
    }

    /// <summary>
    /// Pesquisa de Boletos - Item de Boleto
    /// </summary>
    public class BoleroResultItem
    {
        /// <summary>
        /// Número do Boleto
        /// </summary>
        [JsonProperty("numeroBoletoBB")]
        public string NumeroBoletoBB { get; set; }

        /// <summary>
        /// Data de Registro do BB
        /// </summary>
        [JsonProperty("dataRegistro")]
        public string DataRegistro { get; set; }

        /// <summary>
        /// Data de Vencimento do Boleto
        /// </summary>
        [JsonProperty("dataVencimento")]
        public string DataVencimento { get; set; }

        /// <summary>
        /// Valor do Boleto
        /// </summary>
        [JsonProperty("valorOriginal")]
        public double ValorOriginal { get; set; }

        /// <summary>
        /// Número da carteira do convênio de cobrança. Ex: 17
        /// </summary>
        [JsonProperty("carteiraConvenio")]
        public int CarteiraConvenio { get; set; }

        /// <summary>
        /// Número da variação da carteira do convênio de cobrança. Ex: 35
        /// </summary>
        [JsonProperty("variacaoCarteiraConvenio")]
        public int VariacaoCarteiraConvenio { get; set; }

        /// <summary>
        /// Código da situação atual do boleto.
        /// </summary>
        [JsonProperty("codigoEstadoTituloCobranca")]
        public EnumEstadoTituloCobranca CodigoEstadoTituloCobranca { get; set; }

        /// <summary>
        /// Desrição da situação atual do boleto.
        /// </summary>
        [JsonProperty("estadoTituloCobranca")]
        public string EstadoTituloCobranca { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("contrato")]
        public int Contrato { get; set; }

        /// <summary>
        /// Data de Movimento
        /// </summary>
        [JsonProperty("dataMovimento")]
        public string DataMovimento { get; set; }

        /// <summary>
        /// Data de Credito
        /// </summary>
        [JsonProperty("dataCredito")]
        public string DataCredito { get; set; }

        /// <summary>
        /// Valor Atual
        /// </summary>
        [JsonProperty("valorAtual")]
        public decimal? ValorAtual { get; set; }

        /// <summary>
        /// Valor Pago
        /// </summary>
        [JsonProperty("valorPago")]
        public decimal? ValorPago { get; set; }
    }
}
