using Newtonsoft.Json;

namespace BringApi.Net
{
    public class BringPostalCodeResponse
    {
        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("valid")]
        public bool Valid { get; set; }

        [JsonProperty("postalCodeType")]
        public string PostalCodeType { get; set; }
    }
}
