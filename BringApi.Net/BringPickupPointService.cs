using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BringApi.Net
{
    public class BringPickupPointService
    {
        private const string PickupPointBaseUrl = "/pickuppoint/api/pickuppoint/";

        public async Task<BringPickupPointResponse> GetPickupPointsForPostalCode(string countryCode, string postalCode, BringPickupPointRequest request = null) => await GetResponse($"{countryCode}/postalCode/{postalCode}.json", request);
        public async Task<BringPickupPointResponse> GetPickupPointsForLocation(string countryCode, string latitude, string longitude, BringPickupPointRequest request = null) => await GetResponse($"{countryCode}/location/{latitude},{longitude}.json", request);
        public async Task<BringPickupPointResponse> GetPickupPointById(string countryCode, string id, BringPickupPointRequest request = null) => await GetResponse($"{countryCode}/id/{id}.json", request);
        public async Task<BringPickupPointResponse> GetPickupPointsForCountry(string countryCode, BringPickupPointRequest request = null) => await GetResponse($"{countryCode}/all.json", request);

        private static async Task<BringPickupPointResponse> GetResponse(string relativeUrl, BringPickupPointRequest request)
        {
            var response = await ApiHelper.GetAsync(PickupPointBaseUrl + relativeUrl, request);

            return JsonConvert.DeserializeObject<BringPickupPointResponse>(response);
        }
    }
}
