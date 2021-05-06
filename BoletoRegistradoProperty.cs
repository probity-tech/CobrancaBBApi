using CobrancaBBApi.Model;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace CobrancaBBApi
{
    public partial class BoletoRegistrado
    {
        private Config Configuracao { get; set; }

        public Token TokenAtivo { get; set; }

        public ResponsePublicError Excecao { get; set; }

        private void SetConfiguration()
        {
            Configuracao = new Config()
            {
                ApiClientId = ConfigurationManager.AppSettings["bbApiClientId"],
                ApiClientSecret = ConfigurationManager.AppSettings["bbApiClientSecret"],
                ApiDeveloperApplicationKey = ConfigurationManager.AppSettings["bbApiDeveloperApplicationKey"],
                ApiUrl = ConfigurationManager.AppSettings["bbApiUrl"],
                ApiUrlOAuth = ConfigurationManager.AppSettings["bbApiUrlOAuth"],
                IndicadorPix = ConfigurationManager.AppSettings["bbApiIndicadorPix"]
            };
        }

        private bool LoginApiBB()
        {
            bool resultado = false;

            try
            {
                var client = new RestClient(string.Format("{0}oauth/token", Configuracao.ApiUrlOAuth))
                {
                    Timeout = -1
                };

                var request = new RestRequest(Method.POST);
                SetAuthorization(request);
                IRestResponse response = client.Execute(request);

                switch (response.StatusCode)
                {
                    case System.Net.HttpStatusCode.OK:
                    case System.Net.HttpStatusCode.Created:
                        TokenAtivo = JsonConvert.DeserializeObject<Token>(response.Content);
                        TokenAtivo.Expire_DateTime = GetDateExpire(TokenAtivo.Expires_in);
                        resultado = true;
                        break;
                    default:
                        ResultError(response.StatusCode, response.Content);
                        break;
                }
            }
            catch (Exception ex)
            {
                SetErrorException(ex);
                resultado = false;
            }

            return resultado;
        }

        private void SetAuthorization(RestRequest request)
        {
            string authBasic = string.Format("Basic {0}", EncodeToBase64(string.Format("{0}:{1}", Configuracao.ApiClientId, Configuracao.ApiClientSecret)));
            request.AddHeader("Authorization", authBasic);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("grant_type", "client_credentials");
            request.AddParameter("scope", "cobrancas.boletos-requisicao+cobrancas.boletos-info");
        }

        private void SetHeaderAuthorizationBearer(RestRequest request)
        {
            request.AddHeader("Authorization", string.Format("Bearer {0}", TokenAtivo.Access_token));
            request.AddHeader("Content-Type", "application/json");
        }

        private void ResultError(System.Net.HttpStatusCode StatusCode, string Content)
        {
            Excecao = new ResponsePublicError()
            {
                StatusCode = (int)StatusCode
            };

            try
            {
                if (!string.IsNullOrEmpty(Content))
                {
                    SetTipoErroStatusCode(Content, Excecao);
                    SetTipoErroCodigoMensagem(Content, Excecao);
                    SetTipoErroOcorrencia(Content, Excecao);
                    SetTipoErroCode(Content, Excecao);
                }
            }
            catch
            {
                Excecao = new ResponsePublicError()
                {
                    StatusCode = (int)StatusCode,
                    Erros = new List<string>() { Content }
                };
            }
        }

        /// <summary>
        /// Capturar o Erro da Exceção
        /// </summary>
        /// <param name="ex"></param>
        private void SetErrorException(Exception ex)
        {
            Excecao = new ResponsePublicError()
            {
                StatusCode = (int)System.Net.HttpStatusCode.InternalServerError,
                Erros = new List<string>() { ex.Message }
            };
        }

        /// <summary>
        /// Capturar o Erro enviado pela API
        /// </summary>
        /// <param name="Content"></param>
        /// <param name="result"></param>
        private static void SetTipoErroStatusCode(string Content, ResponsePublicError result)
        {
            if (Content.Contains("statusCode"))
            {
                var r0 = JsonConvert.DeserializeObject<ResponseErrorToken>(Content);

                result.Erros = new List<string>() { r0.Message };
            }
        }

        /// <summary>
        /// Capturar o Erro enviado pela API
        /// </summary>
        /// <param name="Content"></param>
        /// <param name="result"></param>
        private static void SetTipoErroCodigoMensagem(string Content, ResponsePublicError result)
        {
            if (Content.Contains("codigoMensagem"))
            {
                var r0 = JsonConvert.DeserializeObject<ResponseErrorPesquisa>(Content);

                result.Erros = new List<string>();
                foreach (var r in r0.Erros)
                {
                    result.Erros.Add(r.TextoMensagem);
                }
            }
        }

        /// <summary>
        /// Capturar o Erro enviado pela API
        /// </summary>
        /// <param name="Content"></param>
        /// <param name="result"></param>
        private static void SetTipoErroOcorrencia(string Content, ResponsePublicError result)
        {
            if (Content.Contains("ocorrencia"))
            {
                var r0 = JsonConvert.DeserializeObject<ResponseError>(Content);

                result.Erros = new List<string>();
                foreach (var r in r0.Erros)
                {
                    result.Erros.Add(r.Mensagem);
                }
            }
        }

        /// <summary>
        /// Capturar o Erro enviado pela API
        /// </summary>
        /// <param name="Content"></param>
        /// <param name="result"></param>
        private static void SetTipoErroCode(string Content, ResponsePublicError result)
        {
            if (Content.Contains("code"))
            {
                var r0 = JsonConvert.DeserializeObject<ResponseErrorModelo2>(Content);

                result.Erros = new List<string>();
                foreach (var r in r0.Errors)
                {
                    result.Erros.Add(r.Message);
                }
            }
        }

        /// <summary>
        /// Adiciona Segundo a Data de Hora Atual
        /// </summary>
        /// <param name="Seconds"></param>
        /// <returns></returns>
        private DateTime? GetDateExpire(int? Seconds)
        {
            if (Seconds.HasValue)
            {
                var agora = DateTime.Now;
                return new DateTime(agora.Year, agora.Month, agora.Day, agora.Hour, agora.Minute, 0).AddSeconds(Seconds.Value);
            }

            return null;
        }

        /// <summary>
        /// Transforma uma string em BASE64
        /// </summary>
        /// <param name="texto"></param>
        /// <returns></returns>
        private string EncodeToBase64(string texto)
        {
            try
            {
                byte[] textoAsBytes = Encoding.UTF8.GetBytes(texto);
                string resultado = Convert.ToBase64String(textoAsBytes);
                return resultado;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
