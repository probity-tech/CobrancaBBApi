using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Linq;

namespace CobrancaBBApi.Extension
{
    public static partial class JsonExtensions
    {
        static readonly IContractResolver defaultResolver = JsonSerializer.CreateDefault().ContractResolver;

        public static object GetJsonProperty<T>(T obj, string jsonName, bool exact = false, IContractResolver resolver = null)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));
            resolver = resolver ?? defaultResolver;
            var contract = resolver.ResolveContract(obj.GetType()) as JsonObjectContract;
            if (contract == null)
                throw new ArgumentException(string.Format("{0} is not serialized as a JSON object", obj));
            var property = contract.Properties.GetProperty(jsonName, exact ? StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase);
            if (property == null)
                throw new ArgumentException(string.Format("Property {0} was not found.", jsonName));
            return property.ValueProvider.GetValue(obj); // Maybe check JsonProperty.Readable first, and throw an exception if not?
        }

        public static string[] PropertyNames(Type type)
        {
            return PropertyNames(defaultResolver, type);
        }

        public static string[] PropertyNames(this IContractResolver resolver, Type type)
        {
            if (resolver == null || type == null)
                throw new ArgumentNullException();
            var contract = resolver.ResolveContract(type) as JsonObjectContract;
            if (contract == null)
                return new string[0];
            return contract.Properties.Where(p => !p.Ignored).Select(p => p.PropertyName).ToArray();
        }
    }
}
