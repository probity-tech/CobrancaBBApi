using System.Collections.Generic;

namespace CobrancaBBApi.Model
{
    public class ResponsePublicError
    {
        public int StatusCode { get; set; }
        public List<string> Erros { get; set; }
    }
}
