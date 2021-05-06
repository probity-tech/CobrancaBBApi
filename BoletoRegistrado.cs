using CobrancaBBApi.Model;
using Newtonsoft.Json;
using RestSharp;
using System;

namespace CobrancaBBApi
{
    public partial class BoletoRegistrado : IBoletoRegistrado, IDisposable
    {
        private bool disposedValue;

        public BoletoRegistrado()
        {
            SetConfiguration();
        }

        /// <summary>
        /// Registra o Boleto
        /// </summary>
        /// <param name="Boleto"></param>
        /// <returns></returns>
        public Model.BoletoRegistrado RegistrarBoleto(Boleto Boleto)
        {
            Excecao = null;
            if (LoginApiBB())
            {
                var client = new RestClient(string.Format("{0}boletos?{1}", Configuracao.ApiUrl, Configuracao.ApiDeveloperApplicationKey))
                {
                    Timeout = -1
                };

                string bodyJson = JsonConvert.SerializeObject(Boleto);

                var request = new RestRequest(Method.POST);
                SetHeaderAuthorizationBearer(request);
                request.AddParameter("application/json", bodyJson, ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);

                switch (response.StatusCode)
                {
                    case System.Net.HttpStatusCode.OK:
                        return JsonConvert.DeserializeObject<Model.BoletoRegistrado>(response.Content);
                    default:
                        ResultError(response.StatusCode, response.Content);
                        return null;
                }
            }

            return null;
        }

        /// <summary>
        /// Retorna uma listagem de Boletos baseado no filtro de Pesquisa
        /// </summary>
        /// <param name="Parametros"></param>
        /// <returns></returns>
        public Model.BoletoResult PesquisaBoleto(BoletoFiltroPesquisa Parametros)
        {
            try
            {
                if (LoginApiBB())
                {
                    var client = new RestClient(string.Format("{0}boletos?{1}", Configuracao.ApiUrl, Configuracao.ApiDeveloperApplicationKey))
                    {
                        Timeout = -1
                    };

                    var request = new RestRequest(Method.GET);
                    SetHeaderAuthorizationBearer(request);
                    request.AddParameterPequisaBoleto(Parametros);

                    IRestResponse response = client.Execute(request);

                    switch (response.StatusCode)
                    {
                        case System.Net.HttpStatusCode.OK:
                            return JsonConvert.DeserializeObject<BoletoResult>(response.Content);
                        default:
                            ResultError(response.StatusCode, response.Content);
                            break;
                    }
                }

                return null;
            }
            catch (Exception ex)
            {
                SetErrorException(ex);

                return null;
            }
        }



        /// <summary>
        /// Retorna detalhes de um Boleto
        /// </summary>
        /// <param name="NumeroBoleto"></param>
        /// <returns></returns>
        public BoletoDetalhe PequisaBoleto(string NossoNumero, int NumeroConvenio)
        {
            try
            {
                if (LoginApiBB())
                {
                    var client = new RestClient(string.Format("{0}boletos/{1}?{2}&numeroConvenio={3}", Configuracao.ApiUrl, NossoNumero, Configuracao.ApiDeveloperApplicationKey, NumeroConvenio))
                    {
                        Timeout = -1
                    };

                    var request = new RestRequest(Method.GET);
                    SetHeaderAuthorizationBearer(request);
                    IRestResponse response = client.Execute(request);

                    switch (response.StatusCode)
                    {
                        case System.Net.HttpStatusCode.OK:
                            return JsonConvert.DeserializeObject<BoletoDetalhe>(response.Content);
                        default:
                            ResultError(response.StatusCode, response.Content);
                            break;
                    }
                }

                return null;
            }
            catch (Exception ex)
            {
                SetErrorException(ex);
                return null;
            }
        }



        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                }

                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}

