using System.Collections.Generic;
using Newtonsoft.Json;

namespace BringApi.Net
{
    public class BringPickupPointResponse
    {
        [JsonProperty("pickupPoint")]
        public IEnumerable<BringPickupPoint> PickupPoints { get; set; }
    }
}
