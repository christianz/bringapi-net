using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BringApi.Net
{
    public class BringShippingGuideService
    {
        private const string ShippingGuideBaseUrl = "https://api.bring.com/shippingguide/products/";

        public async Task<BringShipmentResponse> GetShipmentPrices(BringShipmentRequest request) => await GetResponse("price.json", request);
        public async Task<BringShipmentResponse> GetEstimatedDeliveryTime(BringShipmentRequest request) => await GetResponse("expectedDelivery.json", request);
        public async Task<BringShipmentResponse> GetAllShipmentInfo(BringShipmentRequest request) => await GetResponse("all.json", request);

        private static async Task<BringShipmentResponse> GetResponse(string relativeUrl, BringShipmentRequest request)
        {
            var response = await ApiHelper.GetAsync(ShippingGuideBaseUrl + relativeUrl, request);

            return JsonConvert.DeserializeObject<BringShipmentResponse>(response);
        }
    }
}
