using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace BringApi.Net
{
    internal static class ApiHelper
    {
        internal static async Task<string> GetAsync<T>(string requestUrl, T parameters) where T : class
        {
            using (var http = BuildHttpClient())
            {
                if (parameters != null)
                {
                    var properties = from p in parameters.GetType().GetProperties()
                        let val = p.GetValue(parameters, null)
                        where val != null
                        let s = val.ToString()
                        where s != "" && s != "0"
                        select StringUtilities.ToCamelCase(p.Name) + "=" + HttpUtility.UrlEncode(s);

                    if (requestUrl.Contains("?"))
                    {
                        requestUrl += "&";
                    }
                    else
                    {
                        requestUrl += "?";
                    }

                    requestUrl += string.Join("&", properties.ToArray());
                }

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
