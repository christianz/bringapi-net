using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BringApi.Net
{
    public class BringTrackingService
    {
        private const string TrackingBaseUrl = "https://tracking.bring.com/";

        public async Task<BringTrackingResponse> GetTrackingInformation(string q)
        {
            var response = await ApiHelper.GetAsync(TrackingBaseUrl + "tracking.json", new { q });

            return JsonConvert.DeserializeObject<BringTrackingResponse>(response);
        }
    }
}
