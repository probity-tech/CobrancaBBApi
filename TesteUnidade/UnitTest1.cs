using CobrancaBBApi;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TesteUnidade
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Registro de Boleto
        /// </summary>
        [TestMethod]
        public void RegistrarBoleto()
        {
            var boleto = new BoletoRegistrado();

            var dadosBoleto = new CobrancaBBApi.Model.Boleto()
            {
                NumeroConvenio = 3128557,
                NumeroCarteira = 17,
                NumeroVariacaoCarteira = 35,
                CodigoModalidade = CobrancaBBApi.Model.Enum.EnumCodigoModalidade.SIMPLES,
                DataEmissao = "26/04/2021",
                DataVencimento = "05/05/2021",
                ValorOriginal = 88.78M,
                CodigoAceite = CobrancaBBApi.Model.Enum.EnumAceite.A,
                IndicadorPermissaoRecebimentoParcial = CobrancaBBApi.Model.Enum.EnumSimNao.N,
                CodigoTipoTitulo = CobrancaBBApi.Model.Enum.EnumTipoTitulo.DUPLICATADESERVICO,
                NumeroTituloCliente = "00031285570210000003",
                Pagador = new CobrancaBBApi.Model.BoletoPagador()
                {
                    TipoInscricao = CobrancaBBApi.Model.Enum.EnumCpfCnpj.CPF,
                    NumeroInscricao = 17234128808,
                    Nome = "NOME DO PAGADOR",
                    Endereco = "ENDERECO COMPLETO DO PAGADOR",
                    Cep = 999999999,
                    Cidade = "MAUÁ",
                    Bairro = "BAIRRO",
                    Uf = "SP",
                },
                IndicadorPix = "S - 28779295827"
            };

            var result = boleto.RegistrarBoleto(dadosBoleto);

            Assert.IsTrue(result != null);
        }

        /// <summary>
        /// Retorna uma lista de Boletos conforme o filtro de pesquisa
        /// </summary>
        [TestMethod]
        public void PesquisarBoleto()
        {
            var boleto = new BoletoRegistrado();

            var filtro = new CobrancaBBApi.Model.BoletoFiltroPesquisa()
            {
                AgenciaBeneficiario = 452,
                ContaBeneficiario = 123873,
                ModalidadeCobranca = (int)CobrancaBBApi.Model.Enum.EnumCodigoModalidade.SIMPLES,
                CodigoEstadoTituloCobranca = (int)CobrancaBBApi.Model.Enum.EnumEstadoTituloCobranca.NORMAL,
                IndicadorSituacao = CobrancaBBApi.Model.Enum.EnumIndicadorSituacao.A,
                DataInicioRegistro = string.Format("{0:dd.MM.yyyy}", new DateTime(2000, 04, 27)),
                DataFimRegistro = string.Format("{0:dd.MM.yyyy}", new DateTime(2000, 04, 26))
            };

            var result = boleto.PesquisaBoleto(filtro);

            Assert.IsTrue(result != null);
        }

        /// <summary>
        /// Pequisa um boleto por NossoNumero e Número de convênio
        /// </summary>
        [TestMethod]
        public void PesquisarBoletoUnico()
        {
            var boleto = new BoletoRegistrado();

            var result = boleto.PequisaBoleto("00031285570210000006", 3128557);
            Assert.IsTrue(result != null);
        }
    }
}
