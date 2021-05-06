using CobrancaBBApi.Model.Enum;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CobrancaBBApi.Model
{
    public class BoletoDetalhe
    {
        /// <summary>
        /// Campo correpondente à linha digitável do boleto.
        /// </summary>
        [JsonProperty("codigoLinhaDigitavel")]
        public string CodigoLinhaDigitavel { get; set; }

        /// <summary>
        /// E-mail do Pagador
        /// </summary>
        [JsonProperty("textoEmailPagador")]
        public string TextoEmailPagador { get; set; }

        /// <summary>
        /// Mensagem para ser impressa no boleto.
        /// </summary>
        [JsonProperty("textoMensagemBloquetoTitulo")]
        public string TextoMensagemBloquetoTitulo { get; set; }

        /// <summary>
        /// Código para identificação do tipo de multa para o Título de Cobrança.
        /// </summary>
        [JsonProperty("codigoTipoMulta")]
        public EnumTipoMulta CodigoTipoMulta { get; set; }

        /// <summary>
        /// Código para identificação da forma de pagamento e do canal onde foi pago o boleto. Composto por 3 dígitos.
        /// O primeiro dígito é: 1 Espécie 2 Débito em conta 3 Cartão de crédito 4 Cheque
        /// Os dois últimos: 01 Agencias - Postos tradicionais 02 Terminal de Auto-atendimento 03 Internet(home / office banking) 05 Correspondente bancário 06 Central de atendimento(Call Center) 07 Arquivo Eletrônico 08 DDA 61 Pix
        /// </summary>
        [JsonProperty("codigoCanalPagamento")]
        public int CodigoCanalPagamento { get; set; }

        /// <summary>
        /// Código adotado pelo Banco para identificar o Contrato entre este e a Empresa Cliente.
        /// </summary>
        [JsonProperty("numeroContratoCobranca")]
        public int NumeroContratoCobranca { get; set; }

        /// <summary>
        /// Código que identifica o tipo de inscrição da Empresa ou Pessoa Física perante uma Instituição governamental.
        /// </summary>
        [JsonProperty("codigoTipoInscricaoSacado")]
        public EnumCpfCnpj CodigoTipoInscricaoSacado { get; set; }

        /// <summary>
        /// Número de inscrição da Empresa ou Pessoa Física perante uma Instituição governamental.
        /// </summary>
        [JsonProperty("numeroInscricaoSacadoCobranca")]
        public long NumeroInscricaoSacadoCobranca { get; set; }

        /// <summary>
        /// Código da situação atual do boleto.
        /// </summary>
        [JsonProperty("codigoEstadoTituloCobranca")]
        public EnumEstadoTituloCobranca CodigoEstadoTituloCobranca { get; set; }

        /// <summary>
        /// Código para identificar o tipo de boleto de cobrança.
        /// </summary>
        [JsonProperty("codigoTipoTituloCobranca")]
        public EnumTipoTitulo CodigoTipoTituloCobranca { get; set; }

        /// <summary>
        /// Código para identificar a característica dos boletos dentro das modalidades de cobrança existentes no banco.
        /// </summary>
        [JsonProperty("codigoModalidadeTitulo")]
        public EnumCodigoModalidade CodigoModalidadeTitulo { get; set; }

        /// <summary>
        /// Código para identificar se o boleto de cobrança foi aceito (reconhecimento da dívida pelo Pagador).
        /// </summary>
        [JsonProperty("codigoAceiteTituloCobranca")]
        public EnumAceite CodigoAceiteTituloCobranca { get; set; }

        /// <summary>
        /// Código agência da praça do pagador (endereço).
        /// </summary>
        [JsonProperty("codigoPrefixoDependenciaCobrador")]
        public int CodigoPrefixoDependenciaCobrador { get; set; }

        /// <summary>
        /// Código para identificar a moeda referenciada no boleto.
        /// </summary>
        [JsonProperty("codigoIndicadorEconomico")]
        public EnumIndicadorEconomico CodigoIndicadorEconomico { get; set; }

        /// <summary>
        /// Campo destinado para uso da Empresa Beneficiário para identificação do boleto. Equivalente ao SEU NÚMERO ou ao numeroTituloBeneficiario do request do registro
        /// </summary>
        [JsonProperty("numeroTituloCedenteCobranca")]
        public string NumeroTituloCedenteCobranca { get; set; }

        /// <summary>
        /// Código utilizado pela FEBRABAN para identificar o tipo de taxa de juros.
        /// </summary>
        [JsonProperty("codigoTipoJuroMora")]
        public EnumTipoJurosMora CodigoTipoJuroMora { get; set; }

        /// <summary>
        /// Data de emissão do boleto.
        /// </summary>
        [JsonProperty("dataEmissaoTituloCobranca")]
        public string DataEmissaoTituloCobranca { get; set; }

        /// <summary>
        /// Data de registro do boleto.
        /// </summary>
        [JsonProperty("dataRegistroTituloCobranca")]
        public string DataRegistroTituloCobranca { get; set; }

        /// <summary>
        /// Data de vencimento do boleto.
        /// </summary>
        [JsonProperty("dataVencimentoTituloCobranca")]
        public string DataVencimentoTituloCobranca { get; set; }

        /// <summary>
        /// Valor original do boleto indicado quando do registro.
        /// </summary>
        [JsonProperty("valorOriginalTituloCobranca")]
        public decimal ValorOriginalTituloCobranca { get; set; }

        /// <summary>
        /// Valor atualizado do boleto, considerando possíveis multa, juros, mora, descontos, etc., que incidiram sob o valor original
        /// </summary>
        [JsonProperty("valorAtualTituloCobranca")]
        public decimal ValorAtualTituloCobranca { get; set; }

        /// <summary>
        /// Valores já recebidos em pagamentos parciais.
        /// </summary>
        [JsonProperty("valorPagamentoParcialTitulo")]
        public decimal ValorPagamentoParcialTitulo { get; set; }

        /// <summary>
        /// Valor do abatimento (redução do valor do documento, devido a algum problema), expresso em moeda corrente.
        /// </summary>
        [JsonProperty("valorAbatimentoTituloCobranca")]
        public decimal ValorAbatimentoTituloCobranca { get; set; }

        /// <summary>
        /// Percentual do IOF - Imposto sobre Operações Financeiras - de um boleto prêmio de seguro na sua data de emissão, expresso de acordo com o tipo de moeda.
        /// </summary>
        [JsonProperty("percentualImpostoSobreOprFinanceirasTituloCobranca")]
        public decimal PercentualImpostoSobreOprFinanceirasTituloCobranca { get; set; }

        /// <summary>
        /// Valor do IOF - Imposto sobre Operações Financeiras - de um boleto prêmio de seguro na sua data de emissão, expresso de acordo com o tipo de moeda.
        /// </summary>
        [JsonProperty("valorImpostoSobreOprFinanceirasTituloCobranca")]
        public int ValorImpostoSobreOprFinanceirasTituloCobranca { get; set; }

        /// <summary>
        /// Valor do boleto expresso em moeda variável.
        /// </summary>
        [JsonProperty("valorMoedaTituloCobranca")]
        public decimal ValorMoedaTituloCobranca { get; set; }

        /// <summary>
        /// Porcentagem sobre o valor do boleto a ser cobrada de juros de mora.
        /// </summary>
        [JsonProperty("percentualJuroMoraTitulo")]
        public decimal PercentualJuroMoraTitulo { get; set; }

        /// <summary>
        /// Valor sobre o valor do boleto a ser cobrado de juros de mora.
        /// </summary>
        [JsonProperty("valorJuroMoraTitulo")]
        public decimal ValorJuroMoraTitulo { get; set; }

        /// <summary>
        /// Porcentagem sobre o valor do boleto a ser cobrada de multa.
        /// </summary>
        [JsonProperty("percentualMultaTitulo")]
        public int PercentualMultaTitulo { get; set; }

        /// <summary>
        /// Valor sobre o valor do boleto a ser cobrado de multa.
        /// </summary>
        [JsonProperty("valorMultaTituloCobranca")]
        public decimal ValorMultaTituloCobranca { get; set; }

        /// <summary>
        /// Quantidade de parcela do boleto.
        /// </summary>
        [JsonProperty("quantidadeParcelaTituloCobranca")]
        public int QuantidadeParcelaTituloCobranca { get; set; }

        /// <summary>
        /// Data da baixa automática do boleto, conforme cadastrado no convênio.
        /// </summary>
        [JsonProperty("dataBaixaAutomaticoTitulo")]
        public string DataBaixaAutomaticoTitulo { get; set; }

        /// <summary>
        /// Texto de observações destinado ao envio de mensagens livres, a serem impressas no campo de instruções da ficha de compensação do Boleto de Pagamento.
        /// </summary>
        [JsonProperty("textoCampoUtilizacaoCedente")]
        public string TextoCampoUtilizacaoCedente { get; set; }

        /// <summary>
        /// Código para identificação de Rateio de Crédito (partilhamento).
        /// </summary>
        [JsonProperty("indicadorCobrancaPartilhadoTitulo")]
        [JsonConverter(typeof(StringEnumConverter))]
        public EnumSimNao IndicadorCobrancaPartilhadoTitulo { get; set; }

        /// <summary>
        /// Nome que identifica a pessoa, física ou jurídica, a qual se quer fazer referência.
        /// </summary>
        [JsonProperty("nomeSacadoCobranca")]
        public string NomeSacadoCobranca { get; set; }

        /// <summary>
        /// Texto referente a localização da rua/avenida, número, complemento para entrega de correspondência.
        /// </summary>
        [JsonProperty("textoEnderecoSacadoCobranca")]
        public string TextoEnderecoSacadoCobranca { get; set; }

        /// <summary>
        /// Texto referente ao bairro para entrega de correspondência.
        /// </summary>
        [JsonProperty("nomeBairroSacadoCobranca")]
        public string NomeBairroSacadoCobranca { get; set; }

        /// <summary>
        /// Texto referente ao nome do município componente do endereço utilizado para entrega de correspondência.
        /// </summary>
        [JsonProperty("nomeMunicipioSacadoCobranca")]
        public string NomeMunicipioSacadoCobranca { get; set; }

        /// <summary>
        /// Código do estado, unidade da federação componente do endereço utilizado para entrega de correspondência.
        /// </summary>
        [JsonProperty("siglaUnidadeFederacaoSacadoCobranca")]
        public string SiglaUnidadeFederacaoSacadoCobranca { get; set; }

        /// <summary>
        /// Código adotado pelos Correios, para identificação de logradouros.
        /// </summary>
        [JsonProperty("numeroCepSacadoCobranca")]
        public int NumeroCepSacadoCobranca { get; set; }

        /// <summary>
        /// Valor da moeda do abatimento.
        /// </summary>
        [JsonProperty("valorMoedaAbatimentoTitulo")]
        public decimal ValorMoedaAbatimentoTitulo { get; set; }

        /// <summary>
        /// Data para inicialização do processo de cobrança via protesto.
        /// </summary>
        [JsonProperty("dataProtestoTituloCobranca")]
        public string DataProtestoTituloCobranca { get; set; }

        /// <summary>
        /// Código que identifica o tipo de inscrição do Beneficiário original do boleto de cobrança.
        /// </summary>
        [JsonProperty("codigoTipoInscricaoSacador")]
        public EnumCpfCnpj CodigoTipoInscricaoSacador { get; set; }

        /// <summary>
        /// Número de inscrição do Beneficiário original do boleto de cobrança.
        /// </summary>
        [JsonProperty("numeroInscricaoSacadorAvalista")]
        public int NumeroInscricaoSacadorAvalista { get; set; }

        /// <summary>
        /// Nome que identifica a entidade, pessoa física ou jurídica, Beneficiário original do boleto de cobrança.
        /// </summary>
        [JsonProperty("nomeSacadorAvalistaTitulo")]
        public string NomeSacadorAvalistaTitulo { get; set; }

        /// <summary>
        /// Percentual de desconto a ser concedido sobre o boleto de cobrança.
        /// </summary>
        [JsonProperty("percentualDescontoTitulo")]
        public double PercentualDescontoTitulo { get; set; }

        /// <summary>
        /// Data limite do desconto do boleto de cobrança.
        /// </summary>
        [JsonProperty("dataDescontoTitulo")]
        public string DataDescontoTitulo { get; set; }

        /// <summary>
        /// Valor de desconto a ser concedido sobre o boleto de cobrança.
        /// </summary>
        [JsonProperty("valorDescontoTitulo")]
        public decimal ValorDescontoTitulo { get; set; }

        /// <summary>
        /// Código para identificação do tipo de desconto que deverá ser concedido.
        /// </summary>
        [JsonProperty("codigoDescontoTitulo")]
        public EnumTipoDesconto CodigoDescontoTitulo { get; set; }

        /// <summary>
        /// Percentual do segundo desconto a ser concedido sobre o boleto de cobrança.
        /// </summary>
        [JsonProperty("percentualSegundoDescontoTitulo")]
        public double PercentualSegundoDescontoTitulo { get; set; }

        /// <summary>
        /// Data limite do segundo desconto do boleto de cobrança.
        /// </summary>
        [JsonProperty("dataSegundoDescontoTitulo")]
        public string DataSegundoDescontoTitulo { get; set; }

        /// <summary>
        /// Valor do segundo desconto a ser concedido sobre o boleto de cobrança.
        /// </summary>
        [JsonProperty("valorSegundoDescontoTitulo")]
        public decimal ValorSegundoDescontoTitulo { get; set; }

        /// <summary>
        /// Código para identificação do tipo do segundo desconto que deverá ser concedido.
        /// </summary>
        [JsonProperty("codigoSegundoDescontoTitulo")]
        public EnumTipoDesconto CodigoSegundoDescontoTitulo { get; set; }

        /// <summary>
        /// Percentual do terceiro desconto a ser concedido sobre o boleto de cobrança.
        /// </summary>
        [JsonProperty("percentualTerceiroDescontoTitulo")]
        public double PercentualTerceiroDescontoTitulo { get; set; }

        /// <summary>
        /// Data limite do terceiro desconto do boleto de cobrança.
        /// </summary>
        [JsonProperty("dataTerceiroDescontoTitulo")]
        public string DataTerceiroDescontoTitulo { get; set; }

        /// <summary>
        /// Valor do terceiro desconto a ser concedido sobre o boleto de cobrança.
        /// </summary>
        [JsonProperty("valorTerceiroDescontoTitulo")]
        public decimal ValorTerceiroDescontoTitulo { get; set; }

        /// <summary>
        /// Código para identificação do tipo do terceiro desconto que deverá ser concedido.
        /// </summary>
        [JsonProperty("codigoTerceiroDescontoTitulo")]
        public EnumTipoDesconto CodigoTerceiroDescontoTitulo { get; set; }

        /// <summary>
        /// Data para início da cobrança da multa.
        /// </summary>
        [JsonProperty("dataMultaTitulo")]
        public string DataMultaTitulo { get; set; }

        /// <summary>
        /// Número da carteira do convênio de cobrança.
        /// </summary>
        [JsonProperty("numeroCarteiraCobranca")]
        public int NumeroCarteiraCobranca { get; set; }

        /// <summary>
        /// Número da variação da carteira do convênio de cobrança.
        /// </summary>
        [JsonProperty("numeroVariacaoCarteiraCobranca")]
        public int NumeroVariacaoCarteiraCobranca { get; set; }

        /// <summary>
        /// Número de dias decorrentes após a data de vencimento para inicialização do processo de cobrança via protesto.
        /// </summary>
        [JsonProperty("quantidadeDiaProtesto")]
        public int QuantidadeDiaProtesto { get; set; }

        /// <summary>
        /// Número de dias corridos para recebimento do boleto após a data de vencimento.
        /// </summary>
        [JsonProperty("quantidadeDiaPrazoLimiteRecebimento")]
        public int QuantidadeDiaPrazoLimiteRecebimento { get; set; }

        /// <summary>
        /// Data limite para recebimento do boleto após a data de vencimento.
        /// </summary>
        [JsonProperty("dataLimiteRecebimentoTitulo")]
        public string DataLimiteRecebimentoTitulo { get; set; }

        /// <summary>
        /// Código para identificação da autorização de pagamento parcial do boleto.
        /// </summary>
        [JsonProperty("indicadorPermissaoRecebimentoParcial")]
        [JsonConverter(typeof(StringEnumConverter))]
        public EnumSimNao IndicadorPermissaoRecebimentoParcial { get; set; }

        /// <summary>
        /// Código de barras do boleto.
        /// </summary>
        [JsonProperty("textoCodigoBarrasTituloCobranca")]
        public string TextoCodigoBarrasTituloCobranca { get; set; }

        /// <summary>
        /// Código para identificação das ocorrências de retorno do cartório.
        /// </summary>
        [JsonProperty("codigoOcorrenciaCartorio")]
        public EnumOcorrenciaCartorio CodigoOcorrenciaCartorio { get; set; }

        /// <summary>
        /// Valor do IOF recebido.
        /// </summary>
        [JsonProperty("valorImpostoSobreOprFinanceirasRecebidoTitulo")]
        public decimal ValorImpostoSobreOprFinanceirasRecebidoTitulo { get; set; }

        /// <summary>
        /// Valor do abatimento concedido.
        /// </summary>
        [JsonProperty("valorAbatimentoTotal")]
        public decimal ValorAbatimentoTotal { get; set; }

        /// <summary>
        /// Valor dos juros recebidos.
        /// </summary>
        [JsonProperty("valorJuroMoraRecebido")]
        public decimal ValorJuroMoraRecebido { get; set; }

        /// <summary>
        /// Valor de desconto utilizado pelo pagador.
        /// </summary>
        [JsonProperty("valorDescontoUtilizado")]
        public decimal ValorDescontoUtilizado { get; set; }

        /// <summary>
        /// Valor pago.
        /// </summary>
        [JsonProperty("valorPagoSacado")]
        public decimal ValorPagoSacado { get; set; }

        /// <summary>
        /// Valor líquido creditado ao beneficiário.
        /// </summary>
        [JsonProperty("valorCreditoCedente")]
        public decimal ValorCreditoCedente { get; set; }

        /// <summary>
        /// Código para identificação do tipo de liquidação.
        /// </summary>
        [JsonProperty("codigoTipoLiquidacao")]
        public EnumTipoLiquidacao CodigoTipoLiquidacao { get; set; }

        /// <summary>
        /// Data a qual será creditado o valor inerente ao título (este campo só será preenchido após a liquidação, ou seja, após codigoEstadoTituloCobranca = 6).
        /// </summary>
        [JsonProperty("dataCreditoLiquidacao")]
        public string DataCreditoLiquidacao { get; set; }

        /// <summary>
        /// Data para a qual foi agendado o recebimento/pagamento do título.
        /// </summary>
        [JsonProperty("dataRecebimentoTitulo")]
        public string DataRecebimentoTitulo { get; set; }

        /// <summary>
        /// Código agência da praça do recebimento do boleto.
        /// </summary>
        [JsonProperty("codigoPrefixoDependenciaRecebedor")]
        public int CodigoPrefixoDependenciaRecebedor { get; set; }

        /// <summary>
        /// Código para identificar as ocorrências (rejeições, tarifas, custas, liquidação e baixas) do boleto.
        /// </summary>
        [JsonProperty("codigoNaturezaRecebimento")]
        public EnumNaturezaRecebimento CodigoNaturezaRecebimento { get; set; }

        /// <summary>
        /// Número de identidade do sacado do título.
        /// </summary>
        [JsonProperty("numeroIdentidadeSacadoTituloCobranca")]
        public string NumeroIdentidadeSacadoTituloCobranca { get; set; }

        /// <summary>
        /// Código para identificação do sistema/usuário responsável pela atualização do boleto.
        /// </summary>
        [JsonProperty("codigoResponsavelAtualizacao")]
        public string CodigoResponsavelAtualizacao { get; set; }

        /// <summary>
        /// Código para identificação do tipo de baixa do boleto.
        /// </summary>
        [JsonProperty("codigoTipoBaixaTitulo")]
        public EnumTipoBaixaTitulo CodigoTipoBaixaTitulo { get; set; }

        /// <summary>
        /// Valor de multa recebido.
        /// </summary>
        [JsonProperty("valorMultaRecebido")]
        public decimal ValorMultaRecebido { get; set; }

        /// <summary>
        /// Valor do reajuste (índice econômico).
        /// </summary>
        [JsonProperty("valorReajuste")]
        public decimal ValorReajuste { get; set; }

        /// <summary>
        /// Outros valores recebidos.
        /// </summary>
        [JsonProperty("valorOutroRecebido")]
        public decimal ValorOutroRecebido { get; set; }

        /// <summary>
        /// Código do índice econômico utilizado para o cálculo de juros/multa.
        /// </summary>
        [JsonProperty("codigoIndicadorEconomicoUtilizadoInadimplencia")]
        public decimal CodigoIndicadorEconomicoUtilizadoInadimplencia { get; set; }
    }
}
