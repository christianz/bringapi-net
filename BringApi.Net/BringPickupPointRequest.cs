using Newtonsoft.Json;

namespace BringApi.Net
{
    public class BringPickupPointRequest
    {
        /// <summary>
        /// OPTIONAL
        /// </summary>
        [JsonProperty("searchForText")]
        public string SearchForText { get; set; }

        /// <summary>
        /// OPTIONAL
        /// </summary>
        [JsonProperty("openingHoursSearchType")]
        public string OpeningHoursSearchType { get; set; }

        /// <summary>
        /// OPTIONAL
        /// </summary>
        [JsonProperty("openOnOrBefore")]
        public string OpenOnOrBefore { get; set; }

        /// <summary>
        /// OPTIONAL
        /// </summary>
        [JsonProperty("openOnOrAfter")]
        public string OpenOnOrAfter { get; set; }

        /// <summary>
        /// OPTIONAL
        /// </summary>
        [JsonProperty("pickupPointType")]
        public string PickupPointType { get; set; }

        /// <summary>
        /// OPTIONAL
        /// </summary>
        [JsonProperty("numberOfResponses")]
        public int NumberOfResponses { get; set; }

        /// <summary>
        /// OPTIONAL
        /// </summary>
        [JsonProperty("street")]
        public string Street { get; set; }

        /// <summary>
        /// OPTIONAL
        /// </summary>
        [JsonProperty("streetNumber")]
        public string StreetNumber { get; set; }

        /// <summary>
        /// OPTIONAL
        /// </summary>
        [JsonProperty("requestCountryCode")]
        public string RequestCountryCode { get; set; }
    }
}
