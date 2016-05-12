using Newtonsoft.Json;

namespace BringApi.Net
{
    public class BringPrice
    {
        [JsonProperty("currencyIdentificationCode")]
        public string CurrencyIdentificationCode { get; set; }

        [JsonProperty("packagePriceWithoutAdditionalServices")]
        public BringPackagePrice PackagePriceWithoutAdditionalServices { get; set; }

        [JsonProperty("packagePriceWithAdditionalServices")]
        public BringPackagePrice PackagePriceWithAdditionalServices { get; set; }
    }
}
