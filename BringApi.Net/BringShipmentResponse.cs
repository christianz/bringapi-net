using System.Collections.Generic;
using Newtonsoft.Json;

namespace BringApi.Net
{
    public class BringShipmentResponse
    {
        [JsonProperty("@packageId")]
        public string PackageId { get; set; }

        [JsonProperty("Product")]
        public IEnumerable<BringProduct> Products { get; set; } 
    }
}
