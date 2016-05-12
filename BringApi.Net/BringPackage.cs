using System.Collections.Generic;
using Newtonsoft.Json;

namespace BringApi.Net
{
    public class BringPackage
    {
        [JsonProperty("statusDescription")]
        public string StatusDescription { get; set; }

        [JsonProperty("descriptions")]
        public IEnumerable<string> Descriptions { get; set; } 

        [JsonProperty("packageNumber")]
        public string PackageNumber { get; set; }

        [JsonProperty("previousPackageNumber")]
        public string PreviousPackageNumber { get; set; }

        [JsonProperty("productName")]
        public string ProductName { get; set; }

        [JsonProperty("productCode")]
        public string ProductCode { get; set; }

        [JsonProperty("brand")]
        public string Brand { get; set; }

        /// <summary>
        /// Giggity.
        /// </summary>
        [JsonProperty("lengthInCm")]
        public decimal LengthInCm { get; set; }

        [JsonProperty("WidthInCm")]
        public decimal WidthInCm { get; set; }

        [JsonProperty("HeightInCm")]
        public decimal HeightInCm { get; set; }

        [JsonProperty("VolumeInDm3")]
        public decimal VolumeInDm3 { get; set; }

        [JsonProperty("weightinKgs")]
        public decimal WeightInKgs { get; set; }

        [JsonProperty("pickupCode")]
        public string PickupCode { get; set; }

        [JsonProperty("dateOfReturn")]
        public string DateOfReturn { get; set; }

        [JsonProperty("senderName")]
        public string SenderName { get; set; }

        [JsonProperty("senderAddress")]
        public BringAddress SenderAddress { get; set; }

        [JsonProperty("recipientHandlingAddress")]
        public BringAddress RecipientHandlingAddress { get; set; }

        [JsonProperty("eventSet")]
        public IEnumerable<BringTrackingEvent> EventSet { get; set; } 


    }
}
