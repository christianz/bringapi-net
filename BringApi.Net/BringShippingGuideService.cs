using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BringApi.Net
{
    public class BringShippingGuideService
    {
        public async Task<BringShipmentResponse> GetShipmentResponse(BringShipmentRequest request)
        {
            var response = await ApiHelper.GetAsync("/shippingguide/products/price.json", request);

            return JsonConvert.DeserializeObject<BringShipmentResponse>(response);
        }
    }
}
