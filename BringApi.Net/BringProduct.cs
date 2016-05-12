using Newtonsoft.Json;

namespace BringApi.Net
{
    public class BringProduct
    {
        [JsonProperty("productId")]
        public string ProductId { get; set; }

        [JsonProperty("productCodeInProductionSystem")]
        public int? ProductCodeInProductionSystem { get; set; }

        [JsonProperty("price")]
        public BringPrice Price { get; set; }
    }
}
