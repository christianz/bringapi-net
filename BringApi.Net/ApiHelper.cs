using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;

namespace BringApi.Net
{
    internal static class ApiHelper
    {
        private const string BaseUri = "https://api.bring.com";

        internal static async Task<string> GetAsync<T>(string relativeUri, T parameters) where T : class
        {
            using (var http = BuildHttpClient())
            {
                var properties = from p in parameters.GetType().GetProperties()
                                 let val = p.GetValue(parameters, null)
                                 where val != null
                                 let s = val.ToString()
                                 where s != "" && s != "0"
                                 select StringUtilities.ToCamelCase(p.Name) + "=" + HttpUtility.UrlEncode(s);

                var requestUrl = BaseUri + relativeUri + "?" + string.Join("&", properties.ToArray());

                var response = await http.GetAsync(requestUrl, CancellationToken.None);

                return await response.Content.ReadAsStringAsync();
            }
        }


        private static HttpClient BuildHttpClient()
        {
            var http = new HttpClient();

            return http;
        }
    }

    static class StringUtilities
    {
        internal static string ToCamelCase(string input)
        {
            input = char.ToLower(input[0]) + input.Substring(1);

            return input;
        }
    }
}
