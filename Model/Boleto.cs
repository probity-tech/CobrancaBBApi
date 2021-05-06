using CobrancaBBApi.Model.Enum;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CobrancaBBApi.Model
{
    public class Boleto
    {
        /// <summary>
        /// Número do convênio de Cobrança do Cliente. 
        /// Identificador determinado pelo sistema Cobrança para controlar a emissão de boletos, 
        /// liquidação, crédito de valores ao Beneficiário e intercâmbio de dados com o cliente.
        /// </summary>
        [JsonProperty("numeroConvenio")]
        public int NumeroConvenio { get; set; }

        /// <summary>
        /// Características do serviço de boleto bancário e como ele deve ser tratado pelo banco.
        /// </summary>
        [JsonProperty("numeroCarteira")]
        public int NumeroCarteira { get; set; }

        /// <summary>
        /// Número da variação da carteira do convênio de cobrança.
        /// </summary>
        [JsonProperty("numeroVariacaoCarteira")]
        public int NumeroVariacaoCarteira { get; set; }

        /// <summary>
        /// Identifica a característica dos boletos dentro das modalidades de cobrança existentes no banco.
        /// </summary>
        [JsonProperty("codigoModalidade")]
        public EnumCodigoModalidade CodigoModalidade { get; set; }

        /// <summary>
        /// Data de emissão do boleto (formato "dd.mm.aaaaa").
        /// </summary>
        [JsonProperty("dataEmissao")]
        public string DataEmissao { get; set; }

        /// <summary>
        /// Data de vencimento do boleto (formato "dd.mm.aaaaa").
        /// </summary>
        [JsonProperty("dataVencimento")]
        public string DataVencimento { get; set; }

        /// <summary>
        /// Valor de cobrança > 0.00, emitido em Real (formato decimal separado por "."). 
        /// Valor do boleto no registro. Deve ser maior que a soma dos campos “VALOR DO DESCONTO DO TÍTULO” e 
        /// “VALOR DO ABATIMENTO DO TÍTULO”, se informados. 
        /// Informação não passível de alteração após a criação. 
        /// No caso de emissão com valor equivocado, sugerimos cancelar e emitir novo boleto.
        /// </summary>
        [JsonProperty("valorOriginal")]
        public decimal ValorOriginal { get; set; }

        /// <summary>
        /// Valor de dedução do boleto >= 0.00 (formato decimal separado por ".").
        /// </summary>
        [JsonProperty("valorAbatimento")]
        public decimal? ValorAbatimento { get; set; }

        /// <summary>
        /// Quantos dias após a data de vencimento do boleto para iniciar o 
        /// processo de cobrança através de protesto. (valor inteiro >= 0).
        /// </summary>
        [JsonProperty("quantidadeDiasProtesto")]
        public int? QuantidadeDiasProtesto { get; set; }

        /// <summary>
        /// Quantos dias após a data de vencimento do boleto para iniciar o 
        /// processo de negativação através da opção escolhida no campo orgaoNegativador. (valor inteiro >= 0).
        /// </summary>
        [JsonProperty("quantidadeDiasNegativacao")]
        public int? QuantidadeDiasNegativacao { get; set; }

        /// <summary>
        /// Código do Órgão Negativador.
        /// Domínio: 10 - SERASA
        /// </summary>
        [JsonProperty("orgaoNegativador")]
        public int? OrgaoNegativador { get; set; }

        /// <summary>
        /// Indicador de que o boleto pode ou não ser recebido após o vencimento. Campo não obrigatório
        /// Se não informado, será assumido a informação de limite de recebimento que está definida 
        /// no convênio.
        /// Quando informado "S" em conjunto com o campo "numeroDiasLimiteRecebimento", será definido 
        /// a quantidade de dias(corridos) que este boleto ficará disponível para pagamento após seu 
        /// vencimento.
        /// 
        /// Obs.: Se definido "S" e o campo "numeroDiasLimiteRecebimento" ficar com valor zero 
        /// também será assumido a informação de limite de recebimento que está definida no convênio.
        /// 
        /// Quando informado "N", fica definindo que o boleto NÃO permite pagamento em atraso, 
        /// portanto só aceitará pagamento até a data do vencimento ou o próximo dia útil, 
        /// quando o vencimento ocorrer em dia não útil.
        /// Quando informado qualquer valor diferente de "S" ou "N" será assumido a informação de 
        /// limite de recebimento que está definida no convênio.
        /// </summary>
        [JsonProperty("indicadorAceiteTituloVencido")]
        [JsonConverter(typeof(StringEnumConverter))]
        public EnumSimNao? IndicadorAceiteTituloVencido { get; set; }

        /// <summary>
        /// Número de dias limite para recebimento. Informar valor inteiro > 0.
        /// </summary>
        [JsonProperty("numeroDiasLimiteRecebimento")]
        public int? NumeroDiasLimiteRecebimento { get; set; }

        /// <summary>
        /// Código para identificar se o boleto de cobrança foi aceito 
        /// (reconhecimento da dívida pelo Pagador).
        /// </summary>
        [JsonProperty("codigoAceite")]
        [JsonConverter(typeof(StringEnumConverter))]
        public EnumAceite CodigoAceite { get; set; }

        /// <summary>
        /// Código para identificar o tipo de boleto de cobrança.
        /// </summary>
        [JsonProperty("codigoTipoTitulo")]
        public EnumTipoTitulo CodigoTipoTitulo { get; set; }

        /// <summary>
        /// Descrição do tipo de boleto.
        /// </summary>
        [JsonProperty("descricaoTipoTitulo")]
        public string DescricaoTipoTitulo { get; set; }

        /// <summary>
        /// Código para identificação da autorização de pagamento parcial do boleto.
        /// </summary>
        [JsonProperty("indicadorPermissaoRecebimentoParcial")]
        public EnumSimNao IndicadorPermissaoRecebimentoParcial { get; set; }

        /// <summary>
        /// Número de identificação do boleto (correspondente ao SEU NÚMERO), 
        /// no formato STRING (Limitado a 15 caracteres - Letras Maiúsculas).
        /// </summary>
        [JsonProperty("numeroTituloBeneficiario")]
        public string NumeroTituloBeneficiario { get; set; }

        /// <summary>
        /// Informações adicionais sobre o beneficiário.
        /// </summary>
        [JsonProperty("campoUtilizacaoBeneficiario")]
        public string CampoUtilizacaoBeneficiario { get; set; }

        /// <summary>
        /// Número de identificação do boleto (correspondente ao NOSSO NÚMERO), 
        /// no formato STRING, com 20 dígitos, que deverá ser formatado da seguinte forma: 
        /// “000” + (número do convênio com 7 dígitos) + (10 algarismos - se necessário, completar com zeros à esquerda).
        /// </summary>
        [JsonProperty("numeroTituloCliente")]
        public string NumeroTituloCliente { get; set; }

        /// <summary>
        /// Mensagem definida pelo beneficiário para ser impressa no boleto. (Limitado a 30 caracteres)
        /// </summary>
        [JsonProperty("mensagemBloquetoOcorrencia")]
        public string MensagemBloquetoOcorrencia { get; set; }

        /// <summary>
        /// Define a ausência ou a forma como será concedido o desconto para o Título de Cobrança.
        /// </summary>
        [JsonProperty("desconto")]
        public BoletoDescontoTipo Desconto { get; set; }

        /// <summary>
        /// Define a ausência ou a forma como será concedido o desconto para o Título de Cobrança.
        /// </summary>
        [JsonProperty("segundoDesconto")]
        public BoletoDesconto SegundoDesconto { get; set; }

        /// <summary>
        /// Define a ausência ou a forma como será concedido o desconto para o Título de Cobrança.
        /// </summary>
        [JsonProperty("terceiroDesconto")]
        public BoletoDesconto TerceiroDesconto { get; set; }

        /// <summary>
        /// O valor de juros e multa incidem sobre o valor atual do boleto (valor do boleto - valor de abatimento).
        /// Se o tipo for = 'DISPENSAR' não informar os valores
        /// </summary>
        [JsonProperty("jurosMora")]
        public BoletoJurosMora JurosMora { get; set; }

        /// <summary>
        /// O valor de juros e multa incidem sobre o valor atual do boleto (valor do boleto - valor de abatimento).
        /// Se o tipo for = 'DISPENSAR' não informar os valores
        /// </summary>
        [JsonProperty("multa")]
        public BoletoMulta Multa { get; set; }

        [JsonProperty("pagador")]
        public BoletoPagador Pagador { get; set; }

        [JsonProperty("beneficiarioFinal")]
        public BoletoBeneficiarioFinal BeneficiarioFinal { get; set; }

        /// <summary>
        /// Código para informar se o boleto terá um QRCode Pix atrelado. 
        /// Se informado caracter inválido, assumirá 'N'.
        /// Domínios: 'S' - QRCODE DINAMICO; 'N' - SEM PIX; OUTRO - SEM PIX
        /// </summary>
        [JsonProperty("indicadorPix")]
        public string IndicadorPix { get; set; }
    }
}
