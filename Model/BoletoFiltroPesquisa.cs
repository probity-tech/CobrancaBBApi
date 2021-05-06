using CobrancaBBApi.Model.Enum;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CobrancaBBApi.Model
{
    public class BoletoFiltroPesquisa
    {
        /// <summary>
        /// Situação do boleto. Campo obrigatoriamente MAIÚSCULO. Domínios: A - Em ser B - Baixados/Protestados/Liquidados
        /// </summary>
        [JsonProperty("indicadorSituacao")]
        [JsonConverter(typeof(StringEnumConverter))]
        public EnumIndicadorSituacao IndicadorSituacao { get; set; }

        /// <summary>
        /// Número da agência do beneficiário, sem o dígito verificador. Ex: 452. CAMPO OBRIGATÓRIO.
        /// </summary>
        [JsonProperty("agenciaBeneficiario")]
        public int AgenciaBeneficiario { get; set; }

        /// <summary>
        /// Número da conta do beneficiário, sem o dígito verificador. Ex: 123873. CAMPO OBRIGATÓRIO.
        /// </summary>
        [JsonProperty("contaBeneficiario")]
        public int ContaBeneficiario { get; set; }

        /// <summary>
        /// Número da carteira do convênio de cobrança. Ex: 17
        /// </summary>
        [JsonProperty("carteiraConvenio")]
        public int? CarteiraConvenio { get; set; }

        /// <summary>
        /// Número da variação da carteira do convênio de cobrança. Ex: 35
        /// </summary>
        [JsonProperty("variacaoCarteiraConvenio")]
        public int? VariacaoCarteiraConvenio { get; set; }

        /// <summary>
        /// Número da carteira do convênio de cobrança. Ex: 17
        /// </summary>
        [JsonProperty("modalidadeCobranca")]
        public int? ModalidadeCobranca { get; set; }

        /// <summary>
        /// CNPJ do pagador Ex: 123456789012
        /// </summary>
        [JsonProperty("cnpjPagador")]
        public long? CnpjPagador { get; set; }

        /// <summary>
        /// Dígito verificador do CNPJ do pagador Ex: 12
        /// </summary>
        [JsonProperty("digitoCNPJPagador")]
        public long? DigitoCNPJPagador { get; set; }

        /// <summary>
        /// CPF do pagador sem o dígito. Ex: 711285901
        /// </summary>
        [JsonProperty("cpfPagador")]
        public long? CpfPagador { get; set; }

        /// <summary>
        /// Dígito verificador do CPF do pagador. Ex: 82
        /// </summary>
        [JsonProperty("digitoCNPJPagador")]
        public long? DigitoCPFPagador { get; set; }

        /// <summary>
        /// Data inicial de vencimento do boleto que delimita o período da consulta. Campo não obrigatório. Se informado Data Início, deixando em branco a Data Fim, o sistema deve assumir a data atual como Data Fim. Ex: 22.04.2020
        /// </summary>
        [JsonProperty("dataInicioVencimento")]
        public string DataInicioVencimento { get; set; }

        /// <summary>
        /// Data final de vencimento do boleto que delimita o período da consulta - deverá ser maior que a data de início. Campo não obrigatório. Se informado, deverá ser preenchido dataInicioVencimento. Ex: 28.04.2020
        /// </summary>
        [JsonProperty("dataFimVencimento")]
        public string DataFimVencimento { get; set; }

        /// <summary>
        /// Data inicial do registro do boleto que delimita o período da consulta. Ex: 22.04.2020
        /// </summary>
        [JsonProperty("dataInicioRegistro")]
        public string DataInicioRegistro { get; set; }

        /// <summary>
        /// Data final do registro do boleto que delimita o período da consulta - deverá ser maior que a data de início. Campo não obrigatório. Se informado, deverá ser preenchido dataInicioRegistro. Ex: 28.04.2020
        /// </summary>
        [JsonProperty("dataFimRegistro")]
        public string DataFimRegistro { get; set; }

        /// <summary>
        /// Delimita o período da consulta de boletos liquidados, baixados ou protestados, caso seja informado, no campo codigoEstadoTituloCobranca os códigos 05, 06, 07 ou 09. Ex: 22.04.2020
        /// </summary>
        [JsonProperty("dataInicioMovimento")]
        public string DataInicioMovimento { get; set; }

        /// <summary>
        /// Data final do movimento que delimita o período da consulta de boletos liquidados, baixados ou protestados, caso seja informado, no campo codigoEstadoTituloCobranca os códigos 05, 06, 07 ou 09. Data fim deverá ser maior que a data de início. Campo não obrigatório. Se informado, deverá ser preenchido dataInicioMovimento. Ex: 28.04.2020
        /// </summary>
        [JsonProperty("dataFimMovimento")]
        public string DataFimMovimento { get; set; }

        /// <summary>
        /// Código da situação atual do boleto.
        /// </summary>
        [JsonProperty("codigoEstadoTituloCobranca")]
        public int? CodigoEstadoTituloCobranca { get; set; }

        /// <summary>
        /// Indica se o Boleto está vencido ou não. Campo obrigatoriamente MAIÚSCULO. Domínio: S para boletos vencidos N para boletos não vencidos
        /// </summary>
        [JsonProperty("boletoVencido")]
        [JsonConverter(typeof(StringEnumConverter))]
        public EnumSimNao? BoletoVencido { get; set; }

        /// <summary>
        /// Somente deve ser utilizado em caso de pesquisas que retornem mais de 300 boletos. Caso o campo RPST "Indicador Continuidade" retorne com o valor "S", o usuário deve informar o conteúdo do campo RPST "proximoIndice" a partir do qual será iniciada nova consulta.
        /// </summary>
        [JsonProperty("indice")]
        public long? Indice { get; set; }
    }
}
