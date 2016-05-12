using Newtonsoft.Json;

namespace BringApi.Net
{
    public class BringTrackingEvent
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("recipientSignature")]
        public BringRecipientSignature RecipientSignature { get; set; }
        
        [JsonProperty("unitId")]
        public string UnitId { get; set; }

        [JsonProperty("unitInformationUrl")]
        public string UnitInformationUrl { get; set; }

        [JsonProperty("unitType")]
        public string UnitType { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("dateIso")]
        public string DateIso { get; set; }

        [JsonProperty("displayDate")]
        public string DisplayDate { get; set; }

        [JsonProperty("displayTime")]
        public string DisplayTime { get; set; }

        [JsonProperty("consignmentEvent")]
        public bool ConsignmentEvent { get; set; }
    }
}
