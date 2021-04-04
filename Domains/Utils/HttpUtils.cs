using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace FatecMauaJobNewsletter.Domains.Utils
{
    public static class HttpUtils
    {
        public static string JwtToken = "";

        public static async Task<HttpResponseMessage> Get(this HttpClient http, string requestUri, IEnumerable<string> queryParameters = null)
        {
            ConstructHeader(http);
            ConstructUriWithParameters(ref requestUri, queryParameters);
            return await http.GetAsync(requestUri);
        }

        public static async Task<HttpResponseMessage> Delete(this HttpClient http, string requestUri, IEnumerable<string> queryParameters = null)
        {
            ConstructHeader(http);
            ConstructUriWithParameters(ref requestUri, queryParameters);
            return await http.DeleteAsync(requestUri);
        }

        public static async Task<HttpResponseMessage> Post<T>(this HttpClient http, string requestUri, T request, IEnumerable<string> queryParameters = null)
        {
            ConstructHeader(http);
            ConstructUriWithParameters(ref requestUri, queryParameters);
            return await http.PostAsync(requestUri, request.FormatToJsonContent());
        }

        public static async Task<HttpResponseMessage> Post(this HttpClient http, string requestUri, IEnumerable<string> queryParameters = null)
        {
            ConstructHeader(http);
            ConstructUriWithParameters(ref requestUri, queryParameters);
            return await http.PostAsync(requestUri, null);
        }

        public static async Task<HttpResponseMessage> Put<T>(this HttpClient http, string requestUri, T request, IEnumerable<string> queryParameters = null)
        {
            ConstructHeader(http);
            ConstructUriWithParameters(ref requestUri, queryParameters);
            return await http.PutAsync(requestUri, request.FormatToJsonContent());
        }

        private static void ConstructUriWithParameters(ref string uri, IEnumerable<string> queryParameters)
        {
            if (queryParameters is null || !queryParameters.Any())
                return;

            foreach(string parameter in queryParameters)            
                uri += $"/{parameter}";
        }

        private static void ConstructHeader(HttpClient http)
        {
            if (string.IsNullOrEmpty(JwtToken))
                return;

            http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", JwtToken);
        }
    }
}
