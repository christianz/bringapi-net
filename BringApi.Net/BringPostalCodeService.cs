using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BringApi.Net
{
    public class BringPostalCodeService
    {
        public async Task<BringPostalCodeResponse> GetPostalCode(string clientUrl, string postalCode, string country = null)
        {
            country = country ?? BringCountry.Norway;

            var response = await ApiHelper.GetAsync("https://api.bring.com/shippingguide/api/postalCode.json", new { clientUrl, pnr = postalCode, country });

            return JsonConvert.DeserializeObject<BringPostalCodeResponse>(response);
        }
    }
}
