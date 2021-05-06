using System.Reflection;

namespace RestSharp
{
    public static class RequestExtension
    {
        public static void AddParameterPequisaBoleto(this RestRequest Request, object Filtros)
        {

            var propFiltro = Filtros.GetType().GetProperties();

            foreach (var propriedade in propFiltro)
            {
                PropertyInfo propInfo = Filtros.GetType().GetProperty(propriedade.Name);

                if (propInfo != null)
                {
                    object valorProp = propInfo.GetValue(Filtros);

                    if (valorProp != null)
                    {
                        string name = char.ToLowerInvariant(propriedade.Name[0]) + propriedade.Name.Substring(1);
                        Request.AddParameter(name, valorProp);
                    }
                }
            }
        }
    }
}
