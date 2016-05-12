using Newtonsoft.Json;

namespace BringApi.Net
{
    public class BringPackagePrice
    {
        [JsonProperty("amountWithoutVat")]
        public decimal AmountWithoutVat { get; set; }

        [JsonProperty("vat")]
        public decimal Vat { get; set; }

        [JsonProperty("amountWithVat")]
        public decimal AmountWithVat { get; set; }
    }
}
